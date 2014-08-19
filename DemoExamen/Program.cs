using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 9, 4, -3, -10 };
            //Console.WriteLine( Resultado(arr));

            //Console.Read();
            Fun1();
        }

        private static int Resultado(int[] arr)
        {
            if (arr.Length <= 1) return -1;
            int promedio = arr.Sum()/arr.Length;
            int index = 0;
            int valorMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - promedio) > valorMax)
                {
                    index = i;
                    valorMax = Math.Abs(arr[i] - promedio);
                }
            }
            return index;
        }



        private static void Fun1()
        {
            //for (int i = 0; i < 100000;i++ )
            //{
            //    Console.WriteLine("{0} {1}", i, Convert.ToString(i, 2));
            //}

            //Console.ReadLine();


            while (true)
            {
                //Console.ReadLine();
                Console.WriteLine("Escribe un valor: ");
                //int strValor = Convert.ToInt32(Console.ReadLine());
                string strBinario = Console.ReadLine();//Convert.ToString(strValor, 2);                

                int resultado = SiFuncion(strBinario);


                Console.WriteLine("valor binario: {0} {1}", strBinario, resultado);
                Console.WriteLine("Continuar?");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }
        }

        private static int SiFuncion(string strBinario)
        {
            if (strBinario.Length<1)
            {
                return -1;
            }
            int contador = 1;            
            string strPivote = strBinario.Substring(0,contador);
            string strRestante = strBinario.Substring(contador, strBinario.Length - contador);
            bool bandera = false;
            while(true)
            {
                if (strRestante.Length < contador)
                {
                    break;
                }
                if (strPivote == strRestante.Substring(0, contador))
                {
                    strPivote = strRestante.Substring(0, contador);
                    strRestante = strRestante.Substring(contador, strRestante.Length - contador);
                    bandera = true;
                    if(strRestante.Length <= contador)
                    {
                        break;
                    }
                }
                else
                {
                    contador++;
                    bandera = false;
                    strPivote = strBinario.Substring(0, contador);
                    strRestante = strBinario.Substring(contador, strBinario.Length - contador);                    
                }
            };            
            return (bandera)?contador:-1;
        }



    }
}
