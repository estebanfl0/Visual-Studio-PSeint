﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoWhile
{
    class Ejercicio07
    {
        static void MainTemporal(string[] args)
        {
            /*7. Hacer un programa que lea caracteres desde teclado hasta que lea 10 veces la letra 'a'. Por cada
            carácter leído que no sea una 'a' debe mostrar un mensaje indicándolo. Cuando lea las 10 letras 'a'
            el programa terminará.
            */

            int LetraA = 0, contador;
            string Letras;

            do
            {
                Console.WriteLine("Digite una letra del abecedario");
                Letras = Console.ReadLine();
                if (Letras == "A" || Letras == "a")
                {
                    LetraA++;
                } else
                {
                    Console.WriteLine("No es una letra 'A'");
                }
            } while (LetraA <= 10);

        }
    }
}
