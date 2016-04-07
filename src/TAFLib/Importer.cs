using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TAFLib
{
   public class Importer
   {

        public static void Import(string filePath, string connectionString, string spreadsheet)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            SqlDataReader reader = null;
            connection.Open();


            //load locations
            List<string> locations = new List<string>();
            command.CommandText = "select * from locations";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                locations.Add((string)reader["name"]);
            }
            reader.Close();


            //read csv file
            TextFieldParser csv = new TextFieldParser(filePath);
            csv.SetDelimiters(new string[] { "," });
            csv.HasFieldsEnclosedInQuotes = true;
            csv.ReadLine();

            while (!csv.EndOfData)
            {
                //create entry object from cvs fields
                string[] fields = csv.ReadFields();
                Entry entry = new Entry(fields);

                //look up locations from database and try to match
                string workstationLocation = "UNKNOWN";

                foreach (string location in locations)
                {
                    if (entry.Name1.StartsWith(location))
                    {
                        workstationLocation = location;
                        break;
                    }
                }

                //insert key server entry record
                string sql = "INSERT INTO key_server_entry";
                sql += "(spreadsheet,name,location,total_time,total_count,last_session)";
                sql += " VALUES ";
                sql += "('" + spreadsheet + "','" + entry.Name1 + "','" + workstationLocation + "'," + entry.TotalTime.TotalDays + "," + entry.TotalCount + ",'" + entry.LastSession + "')";

                command.CommandText = sql;

                try
                {
                    Console.WriteLine(entry.Name1 + " [" + entry.Name1 + "]");
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("***ERROR*** [" + entry.Name1 + "]" + ex.Message);
                }


            }

            connection.Close();
            csv.Close();

        }

     


   }
}
