using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reapet = "ja";
            {
                do
                {

                    int random; //Zufallszahl
                    int startnummber = 0;
                    int tries = 0; //Anzahl Versuche
                    int usernum = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Eine Zufallszahl wurde generiert.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Geben Sie ihren Versuch ein (1 - 100(keine Kommazahlen)): ");

                    while (usernum != random)
                    {
                        usernum = Convert.ToInt32(Console.ReadLine());
                        if (usernum < 101 && usernum > random)   //Falls Zahl grösser ist
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist Grösser als die Zufallszahl");
                        }
                        else if (usernum > 0 && usernum < random)  //Falls Zahl kleiner ist
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Ihre Zahl ist kleiner als die Zuffallszahl");
                        }
                        else if (usernum < 0 | usernum > 100)  //Falls Zahl grösser als 100 oder kleiner als 0 ist
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ihre Zahl ist zu gross oder zu klein");
                        }
                        else
                        {
                            break;
                        }
                        Console.Write("Versuchen Sie es nochmal: ");
                        tries++;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Sie haben Zufallszahl erraten es war " + random + ", Sie haben Gewonnen");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sie haben " + tries + " Versuche gebraucht.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Möchten Sie nochmal Spielen [ja|nein] ");
                    reapet = Console.ReadLine();
                    Console.WriteLine("\n\n");
                } while (reapet == "ja");

            }
        }
    }
}

