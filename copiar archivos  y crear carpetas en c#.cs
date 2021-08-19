using System;

namespace copiararchivo
{
    class Program
    {

        // NOTA: si ejecutamos el programa como administrador podremos copiar a carpetas del sistema :)
        static void Main(string[] args)
        {
            // ruta del archivo a copiar 
            string fileName = "C:\\Users\\chaca\\OneDrive\\Escritorio\\VIRUZ EN C\\ratonloco.exe";
            //ubicacion y nombre de la carpeta a crear 
            string targetPath = @"C:\Users\chaca\Videos\ka";
            //con esto se crea una carpeta 
            System.IO.Directory.CreateDirectory(targetPath);
            //el destino de copia al final agregamos como queremos que se llame 
            string destino = @"C:\Users\chaca\Videos\ka\hola.exe";
            //copiamos el archivo 
            System.IO.File.Copy(fileName, destino, true);
        }
    }
}