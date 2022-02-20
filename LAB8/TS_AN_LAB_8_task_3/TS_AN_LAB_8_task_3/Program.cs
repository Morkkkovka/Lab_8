using System;


namespace TS_AN_LAB_8_task_3
{
    
    
        public delegate int FirstDelegate(int a, int b);

        class Program
        {
            static void Main()
            {
                
                Console.WriteLine("Выберите действие: +,-,*,/");
                string a = Console.ReadLine();
                
                Console.WriteLine("Введите первое число");
                int x = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Введите второе число");
                int y = Convert.ToInt32(Console.ReadLine());
                
            
            
            switch (a)
                {
                case "+":
                    FirstDelegate add = (c, b) => c + b;
                    int num1 = add(x, y);
                    Console.WriteLine("Ответ:{0}", num1);
                    break;
                case "-":
                    FirstDelegate sub = (c, b) => c - b;
                    int num2 = sub (x, y);
                    Console.WriteLine("Ответ:{0}", num2);
                    break;
                case "*":
                    FirstDelegate mul = (c, b) => c * b;
                    int num3 = mul (x, y);
                    Console.WriteLine("Ответ:{0}", num3);
                    break;
                case "/":
                    FirstDelegate div = (c, b) => b == 0 ? 0 : c / b;
                    int num4 = div(x, y);
                    Console.WriteLine("Ответ:{0}", num4);
                    break;
                default:
                        Console.WriteLine("Выберите правильное действие!");
                        break;
                }

                Console.ReadKey();

            }
        }
    
}
