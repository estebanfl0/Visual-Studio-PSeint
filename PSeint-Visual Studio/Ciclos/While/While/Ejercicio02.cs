using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio02
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 2. En una empresa se requiere calcular el salario semanal de cada uno de los n obreros que laboran en
            ella. El salario se obtiene de la sig. forma:
                Si el obrero trabaja 40 horas o menos se le paga $20 por hora
                Si trabaja más de 40 horas se le paga $20 por cada una de las primeras 40 horas y $25 por cada hora
                extra. */
            double valorhora = 20, totalPagar, contador = 1;

            Console.WriteLine("Digite el número de obreros");
            _ = int.TryParse(Console.ReadLine(), out int obreros);

            while (contador <= obreros)
            {
                Console.WriteLine("Digite el número de horas que trabajó");
                _ = int.TryParse(Console.ReadLine(), out int horastrabajo);

                if (horastrabajo > 40)
                {
                    totalPagar = horastrabajo * valorhora;
                }
                else
                {
                    totalPagar = ((horastrabajo - 40) * 25) + (valorhora * 20);
                }
                while (horastrabajo < 0)
                {
                    Console.WriteLine("El empleado no trabajó");
                }
                Console.WriteLine("El total a pagar al empleado es de " + totalPagar + "$");
                contador++;
            }


        }
    }
}
