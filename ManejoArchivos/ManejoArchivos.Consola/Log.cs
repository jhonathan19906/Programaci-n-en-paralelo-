using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ManejoArchivos.Consola
{
    public class Log
    {
        private string Path = "";
        
        public Log(string Path)
        {
            this.Path = Path;
        }
        public void Add( string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + "_" + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();
        }
        private string GetNameFile()
        {
            string nombre = "";
            nombre = "log" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;
        }
        public void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
