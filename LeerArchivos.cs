using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    internal class LeerArchivos
    {
        //Function you should copy
        public void lecturaDeArchivos()
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\\Users\\artur\\OneDrive\\Escritorio\\CoC.txt"; //write here te file path

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
        }

    }
}
