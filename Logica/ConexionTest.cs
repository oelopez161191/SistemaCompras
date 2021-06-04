using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ConexionTest
    {
        static void Main(string[] args)
        {
            Conexion cn = new Conexion();

            if (cn.Conectar())
            {
                Console.WriteLine("se conecto");
            }
        }

    }

    
}
