using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //EJERCICIOS CON ESTRUCTURA SWITCH-CASE

            Console.WriteLine("\nOpciones de programas\n" + "1.Programa de los meses del primer semestre\n" + "2.Programa de los meses del segundo semestre\n" + "Ingrese la opcion que desea ejecutar: ");

            int opcion=Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    //PROGRAMA PARA SABER EL MES DEL PRIMER SEMESTRE

                    Console.WriteLine("\n---PROGRAMA QUE DETERMINA EL MES ES DEL PRIMER SEMESTRE ---\n");

                    Console.WriteLine("\nIngresa el numero del 1 al 6: ");
                    int mes=Convert.ToInt32(Console.ReadLine());

                    if (mes ==1)
                    {
                        Console.WriteLine("\nEl numero "+mes+" es el mes de Enero ");
                    
                    }
                    else if(mes ==2)
                    {

                        Console.WriteLine("\nEl numero "+mes+" es el mes de Febrero ");
                    }

                    else if(mes ==3)
                    {
                        Console.WriteLine("\nEl numero "+mes+" es el mes de Marzo ");
                    }

                    else if(mes ==4)
                    {
                        Console.WriteLine("\nEl numero "+mes+" es el mes de Abril ");
                    }

                    else if(mes ==5)
                    {
                        Console.WriteLine("\nEl numero "+mes+" es el mes de Mayo ");
                    }

                    else if(mes ==6)
                    {
                        Console.WriteLine("\nEl numero "+mes+" es el mes de Junio ");
                    }

                    else{

                        Console.WriteLine("El numero "+mes+" no corresponde a un mes del primer semestre. Ingrese un número del 1 al 6");
                    }

                    break;
                    

                case 2:

                    //PROGRAMA PARA SABER EL MES DEL SEGUNDO SEMESTRE

                    Console.WriteLine("\n---PROGRAMA QUE DETERMINA EL MES ES DEL SEGUNDO SEMESTRE ---\n");

                    Console.WriteLine("\nIngresa el numero del 7 al 12: ");
                    int mes2=Convert.ToInt32(Console.ReadLine());

                    if (mes2 ==7)
                    {
                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Julio ");
                    
                    }
                    else if(mes2 ==8)
                    {

                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Agosto ");
                    }

                    else if(mes2 ==9)
                    {
                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Septiembre ");
                    }

                    else if(mes2 ==10)
                    {
                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Octubre ");
                    }

                    else if(mes2 ==11)
                    {
                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Noviembre ");
                    }

                    else if(mes2 ==12)
                    {
                        Console.WriteLine("\nEl numero "+mes2+" es el mes de Diciembre ");
                    }

                    else{

                        Console.WriteLine("El numero "+mes2+" no corresponde a un mes del segundo semestre. Ingrese un número del 7 al 12");
                    }

                break;
                default:
                    Console.WriteLine("Numero inválido. Ingresa la opcion 1 o 2.");
                    break;
            }//Fin del switch

            Console.ReadKey();
        }
    }
}