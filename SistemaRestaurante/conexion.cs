using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final_Periodo3
{
    class conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("ALEXBY; DATABASE=RestauranteBD; Integrated security=true");
            cn.Open();

            return cn;
        }
    }
}
