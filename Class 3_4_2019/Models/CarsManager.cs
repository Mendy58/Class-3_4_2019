using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Class_3_4_2019.Models
{
    public class CarsManager
    {
        private string _connectionstring;
        public CarsManager(string _Connectionstring)
        {
            _connectionstring = _Connectionstring;
        }

        public IEnumerable<Car> GetAll()
        {
            var conn = new SqlConnection(_connectionstring);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select * from WebCars";
            List<Car> cars = new List<Car>();
        }
    }
}