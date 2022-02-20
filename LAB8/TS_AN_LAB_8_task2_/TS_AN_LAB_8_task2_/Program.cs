using System;


namespace TS_AN_LAB_8_task2_
{
             
    
        public delegate int  Number();
        public delegate int AverageValue(Number[] arrayX);
        class Program
        {
        
            static void Main(string[] args)
            {
                Number[] Arr1 = new Number[5];
                for (int i = 0; i < Arr1.Length; i++)
                {
                    Arr1[i] = RandNum;
                    Console.Write($" Значения  = " + Arr1[i].Invoke() + ";\n ");
                }
                Console.WriteLine();

             AverageValue value = delegate (Number[] arr2)
                {
                    int  sum = 0;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        sum += arr2[i]();
                    }
                    return ((sum) / (arr2.Length));
                };

                Console.WriteLine("Среднее арифметическое = " + value(Arr1));

                Console.ReadKey();
            }
               public static int RandNum()
               {
                  Random rand = new Random();
                  return rand.Next(1, 30);
               }
    }
    
   
}
