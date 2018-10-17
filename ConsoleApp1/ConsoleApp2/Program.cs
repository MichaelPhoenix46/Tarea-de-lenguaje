using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {

        public static int Suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
        public static int Resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
        public static int Multi(int a, int b)
        {
            int multi = a * b;
            return multi;
        }
        public static int Division(int a, int b)
        {
            int divi = a / b;
            return divi;
        }

        public static bool ResultadoM(int a, int b)
        {
            if (Multi(a, b) >= 10 && Multi(a, b) < 100)
                return true;
            else
                return false;
        }
        public static bool ResultadoD(int a, int b)
        {
            if (Division(a, b) >= 2 && Division(a, b) < 4)
                return true;
            else
                return false;
        }
        public static bool ResultadoR(int a, int b)
        {
            if (Resta(a, b) < 0)
                return true;
            else
                return false;
        }
        public static bool ResultadoS(int a, int b)
        {
            if (Suma(a, b) == 10 || Suma(a, b) == 20)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {

            int a, b;
            Console.Write("INGRESE PRIMER VALOR: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("INGRESE SEGUNDO VALOR: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("1º) Suma" + "\n" + "2º) Resta" + "\n" + "3º) Multiplicación" + "\n" + "4º) División" + "\n");
            Console.Write("Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Suma = " + Suma(a, b) + "\n");
                    if (ResultadoS(a, b) == true)
                        Console.Write("Es verdadero");
                    else
                        Console.Write("Es falso");
                    break;
                case '2':
                    Console.Write("Resta = " + Resta(a, b) + "\n");
                    if (ResultadoR(a, b) == true)
                        Console.Write("Es verdadero");
                    else
                        Console.Write("Es falso");
                    break;
                case '3':
                    Console.Write("Multiplicación = " + Multi(a, b) + "\n");
                    if (ResultadoM(a, b) == true)
                        Console.Write("Es verdadero");
                    else
                        Console.Write("Es falso");

                    break;
                case '4':
                    Console.Write("División = " + Division(a, b) + "\n");
                    if (ResultadoD(a, b) == true)
                        Console.Write("Es verdadero");
                    else
                        Console.Write("Es falso");

                    break;
            }
            Console.ReadKey();
        }
    }
}