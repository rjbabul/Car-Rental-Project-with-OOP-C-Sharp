using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareRentApplication.Company;
using Microsoft.EntityFrameworkCore;


namespace CareRentApplication.DataBase
{
    public class DataBaseAppication : DbContext
    {
        public DbSet<Car> cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server = (local) ; Database = CarDatabase; Trusted_Connection = true;  TrustServerCertificate = True;";

            optionsBuilder.UseSqlServer(connection);
        }


    }
}
