using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarArreglo
{
    internal class Program
    {


        //static  string Arreglos()
        //{
            
            
           

        //}

        
        static void Main(string[] args)
        {

           

            

            int[] arreglo = { 1,2,11,15,24,32,46,51};
            int numeroMayor =arreglo[0];
            int numeroMenor =arreglo[0];
            int numeroPar;

                for (int i = 0; i < arreglo.Length; i++)
                {

                
                
                numeroMenor = arreglo.Min();
                numeroMayor= arreglo.Max();
                
               

                        if ((arreglo[i] % 2 )==0)
                        {
                            numeroPar = arreglo[i];
                   
                            Console.WriteLine("Los numeros pares son "+numeroPar);
                        }

                   
                   
                }
            Array.Reverse(arreglo);

            Console.WriteLine("El numero menor es "+numeroMenor);
            Console.WriteLine("el numero mayor es "+numeroMayor);
            //.WriteLine(numeroPar);
            for(int i = 0; i < arreglo.Length; i++)
            {
                    
                Console.WriteLine(arreglo[i]);
            }

        }
        }


 
    
}
