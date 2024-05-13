using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static String[] classificacao = new String[10];
        public static int posicao = 0;
        static void Main(string[] args)
        {

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine($"Thread Name: {mainThread.Name}");

            Thread corrida1 = new Thread(() => Corrida("Léo"));
            Thread corrida2 = new Thread(() => Corrida("Erick"));
            Thread corrida3 = new Thread(() => Corrida("Vini"));
            Thread corrida4 = new Thread(() => Corrida("Leitinho"));
            Thread corrida5 = new Thread(() => Corrida("Lipe"));
            Thread corrida6 = new Thread(() => Corrida("Arthur"));
            Thread corrida7 = new Thread(() => Corrida("João"));
            Thread corrida8 = new Thread(() => Corrida("Lucas"));
            Thread corrida9 = new Thread(() => Corrida("Carlos"));
            Thread corrida10 = new Thread(() => Corrida("Barnabe"));

            corrida1.Start();
            corrida2.Start();
            corrida3.Start();
            corrida4.Start();
            corrida5.Start();
            corrida6.Start();
            corrida7.Start();
            corrida8.Start();
            corrida9.Start();
            corrida10.Start();

        }
        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + " : " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fim!");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fim!");
        }
        public static void Corrida(String name)
        {

            Random rand = new Random();


            for (int i = 0; i != 100; i++)
            {
                Console.WriteLine(name + " : " + i);
                Thread.Sleep(rand.Next(1, 100));
                if (i == 99)
                {
                    classificacao[posicao] = name;
                    posicao++;
                }
            }
            Console.WriteLine("Fim da corrida " + name);
            for (int i = 0; i != 10; i++)
            {
                Console.WriteLine((i + 1) + "ª Colocação " + classificacao[i]);
            }
        }

    }

}
