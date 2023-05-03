using CsvDataTransfer.Interfaces;
using CsvDataTransfer.Reflection;
using System.Globalization;

namespace CsvDataTransfer.Processing
{
    public class ParserCsv : ICsvParsable
    {
        public ParserCsv(ICsvModelRepository csvModelReposity)
        {
            _csvModelRepository = csvModelReposity;
        }

        private readonly ICsvModelRepository _csvModelRepository;

        public IEnumerable<T> ParseCsvRows<T>(IEnumerable<string> csvrows)
            where T : class, new()
        {
            IEnumerable<T> models = csvrows.Select(l => ParseRow<T>(l))
                .Where(m => m != null);

            return models.ToArray();
        }

        private T ParseRow<T>(string csvline)
            where T : class, new()
        {
            if (string.IsNullOrEmpty(csvline.Trim()) || csvline.Trim().StartsWith("#"))
            {
                return default;
            }

            string[] csvfields = csvline.Split(';').Select(i => i.Trim()).ToArray();

            CsvProperty[] csvModelProperties = _csvModelRepository.GetModelProperties<T>();

            T model = BuildModel<T>(csvModelProperties, csvfields);

            return model;
        }

        private T BuildModel<T>(IEnumerable<CsvProperty> csvModelProperties, string[] csvfields)
            where T : class, new()
        {
            T model = new();

            foreach (CsvProperty property in csvModelProperties.OrderBy(p => p.Position))
            {
                var field = csvfields[property.Position];
                try
                {
                    if (new[] { typeof(int), typeof(int?) }.Contains(property.PropertyInfo.PropertyType))
                    {
                        if (!int.TryParse(field, out int intValue))
                        {
                            throw new InvalidDataException($"Invalid csv decimal data in field:{field}, type:{property.PropertyInfo.PropertyType.Name}");
                        }
                        property.PropertyInfo.SetValue(model, intValue);
                    }
                    else if (new[] { typeof(decimal), typeof(decimal?) }.Contains(property.PropertyInfo.PropertyType))
                    {
                        NumberFormatInfo nfi = new()
                        {
                            NumberDecimalSeparator = ","
                        };
                        if (!decimal.TryParse(field, NumberStyles.Any, nfi, out decimal decimalValue))
                        {
                            throw new InvalidDataException($"Invalid csv decimal data in field:{field}, type:{property.PropertyInfo.PropertyType.Name}");
                        }
                        property.PropertyInfo.SetValue(model, decimalValue);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
                catch (Exception exception)
                {
                    throw new InvalidDataException($"Invalid csv format field:{field}, type:{property.PropertyInfo.PropertyType.Name}");
                }
            }
            return model;
        }
    }
}
