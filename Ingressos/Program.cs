using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valtm = 0;
            int valti = 0;
            int valt = 0;
            
            for(int i = 1; i <= 5;  i++)
            {
                Console.WriteLine("Meia entrada de estudante? Sim/Não ");
                string resp = Console.ReadLine();
                if (resp == "s" && i <= 5)
                {
                    int val = 50;
                    Console.WriteLine("O valor a ser pago é de " + val);
                    valtm++;
                    valt += val;
                } else if (resp == "s" && i <= 20)
                    {
                        int val = 75;
                        Console.WriteLine("O valor a ser pago é de " + val);
                        valtm++;
                        valt += val;
                        
                     } else if (resp == "s" && i <= 30)
                    {
                        int val = 100;
                        Console.WriteLine("O valor a ser pago é de " + val);
                        valtm++;
                        valt += val;
                    }else if (i <= 10)
                    {
                        int val = 100;
                        Console.WriteLine("O valor a ser pago é de " + val);
                        valti++;
                        valt += val;
                    
                } else if (i <= 20)
                {
                    int val = 150;
                    Console.WriteLine("O valor a ser pago é de " + val);
                    valti++;
                    valt += val;
                } else if(i <= 30)
                {
                    int val = 200;
                    Console.WriteLine("O valor a ser pago é de " + val);
                    valti++;
                    valt += val;
                } 

                Console.ReadKey();
            }

            Console.WriteLine("O faturamento total é de " + valt);
            Console.WriteLine("A quantidade de meios-ingressos pagos foi de " + valtm);
            Console.WriteLine("A quantia de ingressos inteiros foi de " + valti);

            Console.ReadKey();
        }
        
    }
}
