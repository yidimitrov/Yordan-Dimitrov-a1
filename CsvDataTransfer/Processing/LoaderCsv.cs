﻿using CsvDataTransfer.Interfaces;

namespace CsvDataTransfer.Processing
{
    public class LoaderCsv : ICsvLoadable
    {
        public IEnumerable<string> LoadCsv(string csvfilename)
        {
            if (string.IsNullOrEmpty(csvfilename) || !File.Exists(csvfilename))
            {
                throw new ApplicationException($"{csvfilename} is not valid");
            }

            string[] content = File.ReadAllLines(csvfilename);

            return content;
        }
    }
}