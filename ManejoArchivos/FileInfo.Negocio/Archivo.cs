using System;
using System.IO;

namespace FileInfo.Negocio
{
    public class Archivo
    {
        private string path;
        

        public Archivo()
        {
        }

        public Archivo(string path)
        {
            this.path = path;
        }

        public static void Main()
        {
            string path = Path.GetTempFileName();
            var archivo = new Archivo(path);

            // Create a file to write to.
            using (StreamWriter sw = archivo.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            // Open the file to read from.
            using (StreamReader sr = archivo.OpenText())
            {
                var s = @"C:\Users\HP\source\repos\ManejoArchivos\Nelson Mandela.txt "; ;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            try
            {
                string path2 = Path.GetTempFileName();
                var fi2 = new Archivo(path2);

              
              // Asegúrese de que el objetivo no exista
                fi2.Delete();

                // Copie el archivo.
                archivo.CopyTo(path2);
                Console.WriteLine($"{path} was copied to {path2}.");

                // Elimina el archivo recién creado.
                fi2.Delete();
                Console.WriteLine($"{path2} was successfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The process failed: {e.ToString()}");
            }
        }

        private void CopyTo(string path2)
        {
            throw new NotImplementedException();
        }

        private void Delete()
        {
            throw new NotImplementedException();
        }

        public StreamWriter CreateText()
        {
            throw new NotImplementedException();
        }

        public  StreamReader OpenText()
        {
            throw new NotImplementedException();
        }
    }
}
