using System;

namespace calculator
{
    public class Calculator
    {
        public int number { get; set; }

        
        public static Calculator operator ++(Calculator calc)
        {
            calc.number++;
            return calc;
        }

        public static Calculator operator --(Calculator calc)
        {
            calc.number--;
            return calc;
        }

       
        public static bool operator <(Calculator calc1, Calculator calc2)
        {
            return calc1.number < calc2.number;
        }

        public static bool operator >(Calculator calc1, Calculator calc2)
        {
            return calc1.number > calc2.number;
        }

       
        public static Calculator operator +(Calculator calc1, Calculator calc2)
        {
            Calculator result = new Calculator();
            result.number = calc1.number + calc2.number;
            return result;
        }

        public static Calculator operator -(Calculator calc1, Calculator calc2)
        {
            Calculator result = new Calculator();
            result.number = calc1.number - calc2.number;
            return result;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
           
            Calculator[] numbers = new Calculator[10];
           
            Console.Write("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); 
                numbers[i].number = r.Next(1, 100); 
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            Console.WriteLine("New Numbers +1 or -1=");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    ++numbers[i];
                }
                else
                {
                    --numbers[i];
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

           
            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
           
            Console.Write($"Numbers + {numToAdd.number} = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += numToAdd;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

          
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
         
            Console.Write($"Numbers - {numToSub.number}= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= numToSub;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

           
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
          
            Console.WriteLine($"Numbers above or below {numToCompare.number}");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numToCompare)
                {
                    Console.WriteLine($"{numbers[i].number} is higher.");
                }
                else if (numbers[i] < numToCompare)
                {
                    Console.WriteLine($"{numbers[i].number} is lower.");
                }
                else
                {
                    Console.WriteLine($"{numbers[i].number} is equal.");
                }
            }
        }
    }
}