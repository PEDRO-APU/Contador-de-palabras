using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese parrafo: ");
            string parrafo = Console.ReadLine();
           

            Dictionary<string, int> lista = new Dictionary<string, int>();
            string[] solopalabras = parrafo.Split();          
         
          
            List<String> repetidos = new List<string>();         
            foreach(String palabras in solopalabras)
            {
                if (!repetidos.Contains(palabras)){
                    repetidos.Add(palabras);
                }
            }
            foreach (String palabras in repetidos)
            {
                Console.WriteLine(palabras);
            }
            int contador = 0;
            foreach (String palabras in repetidos)
            {
                foreach (String palabras2 in solopalabras)
                {
                    if (palabras2 == palabras)
                    {
                        contador++;
                    }
                }
                
                lista.Add(palabras, contador);
                contador = 0;
            }
            foreach (KeyValuePair<string, int> par in lista)
            {
                Console.WriteLine("Clave = {0}, Valor = {1}", par.Key, par.Value);
            }
            Console.WriteLine("size: "+lista.Count);
            Console.ReadKey();
        }
    }
}

