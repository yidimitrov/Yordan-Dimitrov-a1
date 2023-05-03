using CsvDataTransfer.Attributes;
using CsvDataTransfer.Interfaces;
using System.Reflection;

namespace CsvDataTransfer.Reflection
{
    using ReflectedCollection = Dictionary<Type, CsvProperty[]>;
    public class CsvModelsRepository : ICsvModelRepository
    {
        public CsvModelsRepository()
        {
            _reflectedCollection = new();
        }

        private readonly ReflectedCollection _reflectedCollection;

        public CsvProperty[] GetModelProperties<TCsv>()
        {
            if (!_reflectedCollection.ContainsKey(typeof(TCsv)))
            {
                IEnumerable<CsvProperty> properties = ReflectCsvModels<TCsv>();
                _reflectedCollection[typeof(TCsv)] = properties.ToArray();
            }
            return _reflectedCollection[typeof(TCsv)];
        }

        private IEnumerable<CsvProperty> ReflectCsvModels<TCsv>()
        {
            Type model = Assembly.GetExecutingAssembly().GetTypes()
                .Single(t => t.IsClass && t.Equals(typeof(TCsv)) && t.GetCustomAttribute(typeof(CsvDataAttribute)) != null);

            T getAttribute<T>(PropertyInfo propertyInfo) where T : Attribute =>
                propertyInfo.GetCustomAttribute<T>();

            IEnumerable<CsvProperty> reflecedModel =
                model.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(property => property.GetCustomAttribute<CsvFieldAttribute>() != null)
                .Select(property =>
                new CsvProperty
                {
                    Position = getAttribute<CsvFieldAttribute>(property).Position,
                    PropertyInfo = property,
                });

            return reflecedModel;
        }
    }
}
