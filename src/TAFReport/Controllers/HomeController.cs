using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TAFReport.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //connect to database
            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TAFReportSimple;Integrated Security=True");
            SqlCommand command = connection.CreateCommand();
            SqlDataReader reader = null;
            connection.Open();



            List<List<string>> rows = new List<List<string>>();

            command.CommandText = "SELECT * FROM vLocationReport WHERE spreadsheet = 'F2013' ORDER BY location";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                //entries.Add((string)reader["name"]);
                List<string> row = new List<string>();

                row.Add((string)reader["spreadsheet"]);
                row.Add((string)reader["location"]);
                row.Add((string)reader["Total PC count"].ToString());
                row.Add((string)reader["Avg Total time/PC (hr)"].ToString());
                row.Add((string)reader["Avg Login count/PC total"].ToString());
                row.Add((string)reader["Avg Total time/PC/week (hr)"].ToString());
                row.Add((string)reader["Avg Total count/PC/week"].ToString());
                row.Add((string)reader["Avg Total time/PC/day"].ToString());
                // row.Add(reader["total_time"].ToString());
                // row.Add(reader["total_count"].ToString());
                // row.Add(reader["last_session"].ToString());
                row.Add(reader["reduce"].ToString());


                rows.Add(row);
            }
            reader.Close();

            //ViewBag.entries = entries;
            return View(rows);
        }
    }
}