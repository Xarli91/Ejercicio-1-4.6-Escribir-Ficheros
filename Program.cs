using System;
using System.IO;

class Program_Ficheros
{
    static void Main(string[] args)
    {
        // Abre el archivo de texto para escribir
        StreamWriter file = new StreamWriter("tecleado.txt");

        string frase;

        do
        {
            // Pide al usuario que escriba una frase
            Console.Write("Escribe texto: ");
            frase = Console.ReadLine();

            // Escribe la frase en el archivo si no es la palabra "off"
            if (frase.ToLower() != "off")
            {
                file.WriteLine(frase);
            }

        } while (frase.ToLower() != "off");

        // Cierra el archivo
        file.Close();

        Console.WriteLine("Programa finalizado. Frases guardadas en tecleado.txt.");
        Console.ReadLine();
    }
}