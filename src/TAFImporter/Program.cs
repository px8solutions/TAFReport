using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFLib;

namespace TAFImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            string csvPath = @"..\..\..\..\data\KeyReportFall2013.csv";
            string spreadsheet = "F2013";
            Importer.Import(csvPath, connectionString, spreadsheet);

             csvPath = @"..\..\..\..\data\KeyReportSpring2014.csv";
             spreadsheet = "S2014";
            Importer.Import(csvPath, connectionString, spreadsheet);

        }
    }
}
