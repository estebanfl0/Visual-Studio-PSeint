using System;
using System.Collections.Generic;
using System.Text;

namespace While
{
    class Ejercicio04
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 4. El Depto. de Seguridad Publica y Transito del D.F. desea saber, de los n autos que entran a la ciudad
            de México, cuantos entran con calcomanía de cada color. Conociendo el último dígito de la placa de
            cada automóvil se puede determinar el color de la calcomanía utilizando la sig. relación:

            DÍGITO COLOR
            1 o 2  amarilla
            3 o 4  rosada
            5 o 6  roja
            7 o 8  verde
            9 o 0  azul */
            
            double placa, automoviles, contador = 1;

            Console.WriteLine("Digite el número de automoviles");
            automoviles = double.Parse(Console.ReadLine());
            while (automoviles < 0 )
            {
                Console.WriteLine("Error, no se aceptan números negativos");
            }
            while( contador <= automoviles )
            {
                Console.WriteLine("Digite el último número de la placa del automovil " + contador);
                placa = double.Parse(Console.ReadLine());
                while (placa < 0 || placa > 9)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Error, numero de placa incorrecta, debe ser de un digito");
                    Console.WriteLine("Digite el último número de la placa del automovil " + contador);
                    placa = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    
                }
                if (placa == 1 || placa == 2)
                {
                    Console.WriteLine("Placa Amarilla");
                }
                else if (placa == 3 || placa == 4)
                {
                    Console.WriteLine("Placa Rosada");
                }
                else if (placa == 5 || placa == 6)
                {
                    Console.WriteLine("Placa Roja");
                }
                else if (placa == 7 || placa == 8)
                {
                    Console.WriteLine("Placa Verde");
                }
                else
                {
                    Console.WriteLine("Placa Azul");
                }
                contador++;
            }
            


        }
    }
}

