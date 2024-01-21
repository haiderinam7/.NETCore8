using System;
using System.Collections;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using MyApp.Data;

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
            DataContextDapper dapper = new DataContextDapper();

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

            bool result = dapper.ExecuteSql(sql);

            Console.WriteLine(result);
        }
    }
}
