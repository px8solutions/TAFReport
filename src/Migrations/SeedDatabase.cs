using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(2016032902)]
    public class SeedDatabase : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("locations").Row(new { name = "ATS118", description= "Academic Technology Services" });
            Insert.IntoTable("locations").Row(new { name = "BRH214", description= "Brown Hall 214" });
            Insert.IntoTable("locations").Row(new { name = "BRH264", description = "Brown Hall 264" });
            Insert.IntoTable("locations").Row(new { name = "DISSERV", description = "DISSERV" });
            Insert.IntoTable("locations").Row(new { name = "GIH104", description = "Gilbreath Hall 104" });
            Insert.IntoTable("locations").Row(new { name = "GIH115", description = "Gilbreath Hall 115" });
            Insert.IntoTable("locations").Row(new { name = "HONORS", description = "Honors House" });
            Insert.IntoTable("locations").Row(new { name = "LIBMED", description = "ETSU Medical Library" });
            Insert.IntoTable("locations").Row(new { name = "LIBSHL1", description = "Sherrod Library - Floor 1" });
            Insert.IntoTable("locations").Row(new { name = "LIBSHL2", description = "Sherrod Library - Floor 2" });
            Insert.IntoTable("locations").Row(new { name = "LIBSHL3", description = "Sherrod Library - Floor 3" });
            Insert.IntoTable("locations").Row(new { name = "SWH318", description ="Sam Wilson Hall 318" });
            Insert.IntoTable("locations").Row(new { name = "VA178C017", description = "Stanton-Gerber Hall" });
            Insert.IntoTable("locations").Row(new { name = "VA4216", description = "Pharmacy School" });
            Insert.IntoTable("locations").Row(new { name = "WPH207", description = "Warf Pickel Hall" }); 
            Insert.IntoTable("locations").Row(new { name = "WWH203", description = "Wilson Wallis Hall 203" }); 
            Insert.IntoTable("locations").Row(new { name = "WWH206", description = "Wilson Wallis Hall 206" });


        }

        public override void Down()
        {
            
        }
    }
}
