using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public static class Questions
    {
        public static void Question1()
        {
            // Can you sort this array in ascending value.
            int[] array = new int[] { 3, 4, 1, 5, 9, 2, 6, 0, 7, 8 };

            array = Answer1(array);

            // Display answer.
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        public static int[] Answer1(int[] array)
        {
            // Add code here.

            return array;
        }

        public static void Question2()
        {
            // Can you write some code to differentiate y with respect to x for the following data set.
            double[] y = new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 };
            double[] x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double[] dydx = Answer2(y, x);

            // Display answer.
            Console.WriteLine("[" + string.Join(", ", dydx) + "]");
        }

        public static double[] Answer2(double[] y, double[] x)
        {
            // Add code here.
            return new double[] { double.NaN };
        }

        public static void Question3()
        {
            // Can you write some code to find value in x corresponding to the peak of the second differential in y with respect to x.
            double[] y = new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 };
            double[] x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double peak = Answer3(y, x);

            // Display answer.
            Console.WriteLine(peak);
        }

        public static double Answer3(double[] y, double[] x)
        {
            // Add code here.
            return double.NaN;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Questions.Question1();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
