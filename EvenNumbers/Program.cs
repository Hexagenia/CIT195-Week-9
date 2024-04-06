using System;

namespace EvenNumbers
{
    public class EvenNumber
    {
        public int Value { get; private set; }

        public EvenNumber(int value)
        {
            if (value % 2 != 0)
            {
                throw new ArgumentException("Value must be an even number.");
            }
            Value = value;
        }

        // Unary overloaded operators
        public static EvenNumber operator ++(EvenNumber number)
        {
            number.Value += 2; 
            return number;
        }

        public static EvenNumber operator --(EvenNumber number)
        {
            number.Value -= 2; 
            return number;
        }

        public static EvenNumber operator !(EvenNumber number)
        {
            number.Value = 0; // Reset to 0
            return number;
        }

        
        public static bool operator ==(EvenNumber number1, EvenNumber number2)
        {
            return number1.Value == number2.Value;
        }

        public static bool operator !=(EvenNumber number1, EvenNumber number2)
        {
            return !(number1 == number2);
        }

        public static bool operator >(EvenNumber number1, EvenNumber number2)
        {
            return number1.Value > number2.Value;
        }

        public static bool operator <(EvenNumber number1, EvenNumber number2)
        {
            return number1.Value < number2.Value;
        }

      
        public static EvenNumber operator +(EvenNumber number1, EvenNumber number2)
        {
            return new EvenNumber(number1.Value + number2.Value);
        }

        public static EvenNumber operator -(EvenNumber number1, EvenNumber number2)
        {
            return new EvenNumber(number1.Value - number2.Value);
        }

        public static EvenNumber operator *(EvenNumber number1, EvenNumber number2)
        {
            return new EvenNumber(number1.Value * number2.Value);
        }

        public static EvenNumber operator /(EvenNumber number1, EvenNumber number2)
        {
            if (number2.Value == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return new EvenNumber(number1.Value / number2.Value);
        }

        public static EvenNumber operator %(EvenNumber number1, EvenNumber number2)
        {
            return new EvenNumber(number1.Value % number2.Value);
        }

        public override string ToString()
        {
            return $"Even Number: {Value}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EvenNumber number1 = new EvenNumber(4);
            EvenNumber number2 = new EvenNumber(6);

            Console.WriteLine("Original Even Numbers:");
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine();

            // Unary operators
            Console.WriteLine("After using unary operators:");
            Console.WriteLine(++number1);
            Console.WriteLine(--number2);
            Console.WriteLine(!number1); 
            Console.WriteLine();

            // Comparison operators
            Console.WriteLine("Comparison Results:");
            Console.WriteLine($"Are number1 and number2 equal? {number1 == number2}");
            Console.WriteLine($"Are number1 and number2 not equal? {number1 != number2}");
            Console.WriteLine($"Is number1 greater than number2? {number1 > number2}");
            Console.WriteLine($"Is number1 less than number2? {number1 < number2}");
            Console.WriteLine();

            // Binary operators
            Console.WriteLine("Binary Operation Results:");
            Console.WriteLine($"Addition: {number1 + number2}");
            Console.WriteLine($"Subtraction: {number1 - number2}");
            Console.WriteLine($"Multiplication: {number1 * number2}");
            Console.WriteLine($"Division: {number1 / number2}");
            Console.WriteLine($"Modulus: {number1 % number2}");
        }
    }
}