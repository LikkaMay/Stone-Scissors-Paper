using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\tПривет , это игра камень, ножницы, бумага\t");

                Console.WriteLine();

                Console.WriteLine("\tНажми любую клавишу , чтобы продолжить\t");

                Console.ReadLine();

                Console.WriteLine("\tВыберите камень, ножницы, бумага\t");

                


                string[] vibor = new string[] { "камень", "бумага", "ножницы" };

                Random rand = new Random();

                string mashina = vibor[rand.Next(0, vibor.Length)];

                string igrok = Console.ReadLine();


                if (igrok == mashina)
                {
                    Console.WriteLine("\tничья\t" + igrok + "\t" + mashina);
                }
                if (igrok != mashina)
                {
                    if (igrok == "камень"&& mashina == "бумага")
                    {

                        Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);
                    
                        Console.WriteLine("вы проиграли!");
                    }
                    if (igrok == "камень" && mashina == "ножницы")
                    {
                      Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);

                      Console.WriteLine("вы победили!");
                        
                    }

                    if (igrok == "бумага" && mashina == "камень")
                    {

                        Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);

                        Console.WriteLine("вы победили!");
                    }
                    if (igrok == "бумага" && mashina == "ножницы")
                    {
                        Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);

                        Console.WriteLine("вы проиграли!");

                    }

                    if (igrok == "ножницы" && mashina == "камень")
                    {

                        Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);

                        Console.WriteLine("вы проиграли!");
                    }
                    if (igrok == "ножницы" && mashina == "бумага")
                    {
                        Console.WriteLine("вы выбрали: " + igrok + "\tмашина выбрала: " + mashina);

                        Console.WriteLine("вы победили!");

                    }
                   
                }
                else
                    Console.WriteLine("\tНекорректные данные");


                Console.ReadLine();
            }
            

        }   



            
     }
 }
 

