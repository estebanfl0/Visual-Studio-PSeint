﻿using System;

namespace For
{
    class Ejercicio1
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*1. Calcular el promedio de un alumno que tiene 7 calificaciones 
            en la materia de Diseño Estructurado de Algoritmos*/
            Console.WriteLine("-----------------");
            double promedio,  suma = 0;


            Console.WriteLine("Digite las 7 notas que ha obtenido en clases");
            for (int i=1; i <=7; i++)
            {
                
                Console.WriteLine("Nota " + i);
                _ = int.TryParse(Console.ReadLine(), out int nota);
                suma += nota; //Forma corta
                //suma = suma + nota; forma larga
            }

            promedio = (suma / 7);
            Console.WriteLine(suma);
            Console.WriteLine("Su promedio de es [" + promedio + "]");
            


        }
    }
}
