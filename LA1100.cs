using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenspiel
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
                    random = new Random().Next(1, 100);
                    Console.WriteLine("Eine Zufallszahl wurde generiert.");
                    Console.Write("Geben Sie ihren Versuch ein (1 - 100): ");

                    while (usernum != random)
                    {
                        usernum = Convert.ToInt32(Console.ReadLine());
                        if (usernum < 101 && usernum > random)   //Falls Zahl grösser ist
                        {
                            Console.WriteLine("Ihre Zahl ist Grösser als die Zufallszahl");
                        }
                        else if (usernum > 0 && usernum < random)  //Falls Zahl kleiner ist
                        {
                            Console.WriteLine("Ihre Zahl ist kleiner als die Zuffallszahl");
                        }
                        else if (usernum < 0 | usernum > 100)  //Falls Zahl grösser als 100 oder kleiner als 0 ist
                        {
                            Console.WriteLine("Ihre Zahl ist zu gross oder zu klein");
                        }
                        else
                        {
                            break;
                        }
                        Console.Write("Versuchen Sie es nochmal: ");
                        tries++;
                    }
                    Console.WriteLine("Sie haben Zufallszahl erraten es war " + random + ", Sie haben Gewonnen");
                    Console.WriteLine("Sie haben " + tries + " Versuche gebraucht.");
                    Console.Write("Möchten Sie nochmal Spielen [ja|nein] ");
                    reapet = Console.ReadLine();
                    Console.WriteLine("\n\n");
                } while (reapet == "ja");

            }
        }
    }
}
