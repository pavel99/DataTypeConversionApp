using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double firstNumber = 10.0123;
            //double secondNumber = firstNumber;//implicit Conversion
            //char aChar = 'A';

            //int secondNumber = 65;
            //char aChar = (char)secondNumber;
            //Console.WriteLine(secondNumber);



            //long secondNumber = Convert.ToInt64(firstNumber);//Explicit Conversion
            //int value = 97;
            //char aChar = (char) value;
            //Console.WriteLine(aChar);
            //Console.ReadKey();

            //Implicit Conversion of int
            int aNumber = 32;
            double bnumber = aNumber;

            Console.WriteLine(bnumber);

            //Explicit Conversion of int
            double largenumber = 12.02;
            int intNumber = (int) largenumber;

            Console.WriteLine(intNumber);

            //Implicit Conversion of Char 
            char aChar = 'a';
            int value = aChar;

            Console.WriteLine(aChar);

            //Explicit Conversion of Char 
            int aInt = 65;
            char charvalue = (char) aInt;

            Console.WriteLine(charvalue);
            Console.ReadKey();






        }
    }
}
