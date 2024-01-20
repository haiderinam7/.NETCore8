using System;
using System.Collections;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace MyApp
{
    internal class Computer
    {
        public string Motherboard { get; private set; }
        public bool HasWifi { get; private set; }
        public bool HasLTE { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public decimal Price { get; private set; }
        public string VideoCard { get; private set; }

        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;User Id=sa;Password=SQLConnect1;";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 943.87m,
                VideoCard = "RTX 2060"
            };

            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) VALUES('" + myComputer.Motherboard
                + "','" + myComputer.HasWifi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd HH:mm:ss")
                + "','" + myComputer.Price
                + "','" + myComputer.VideoCard
                + "')";

            Console.WriteLine(sql);

            int result = dbConnection.Execute(sql);

            Console.WriteLine(result);
        }
    }
}
