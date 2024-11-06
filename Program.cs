using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace CCAD16_Assignment1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to read n number of values in an array and display it in reverse order.
            //use a temp variable to hold a position for the element to be switched
            //first element moves to temp, last element moves to first element, temp moves to last element. Continue through each loop
            
            int[] numbers = {12, 3, 55, 52, 23, 9, 133, 83, 45, 62};
            int n = numbers.Length;

            Console.WriteLine("Numbers are: ");

            //print statement for regular order of array
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = numbers[i]; //temp var is current element
                numbers[i] = numbers[n - 1 - i]; //sets current element to opposite end
                numbers[n - 1 - i] = temp; //sets opposite end element to temp variable
            }

            Console.WriteLine("Numbers reversed are:");
            
            //print statement for reversed order of array
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}