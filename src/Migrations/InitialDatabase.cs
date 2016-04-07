using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(2016032901)]
    public class InitalDatabase : Migration
    {
       public override void Up()
       {
          Create.Table("locations")
             .WithColumn("name").AsString().PrimaryKey()
             .WithColumn("description").AsString();


            Create.Table("key_server_entry")
               .WithColumn("id").AsInt32().PrimaryKey().Identity()
               .WithColumn("spreadsheet").AsString()
               .WithColumn("name").AsString()
               .WithColumn("location").AsString()
               .WithColumn("total_time").AsFloat()
               .WithColumn("total_count").AsInt32()
               .WithColumn("last_session").AsDateTime();

          Create.Index("key_server_entry_unq_entry")
             .OnTable("key_server_entry")
             .OnColumn("spreadsheet")
             .Unique()
             .OnColumn("name")
             .Unique();


       }




       public override void Down()
        {
            Delete.Table("key_server_entry");
            Delete.Table("locations");
        }
    }
}
