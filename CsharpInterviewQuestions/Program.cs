using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();

            Console.ReadKey();
        }

        static void Question1()
        {
            // Can you sort this array in ascending value.
            int[] array = new int[] { 3, 4, 1, 5, 9, 2, 6, 0, 7, 8 };

            // Add code here.
            
            // Display answer.
            Console.WriteLine(string.Join(", ", array));
        }

        static void Question2()
        {
            // Can you write some code to differentiate y with respect to x for the following data set.
            // Feel free to create your own class if you would like.
            double[] y = new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 };
            double[] x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Add code here.
            double[] dydx = new double[0];

            // Display answer.
            Console.WriteLine(string.Join(", ", dydx));
        }

        static void Question3()
        {
            // Can you write some code to find value in x corresponding to the peak of the second differential in y with respect to x.
            // Feel free to create your own class if you would like.
            double[] y = new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 };
            double[] x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Add code here.
            double peak = double.NaN;

            // Display answer.
            Console.WriteLine(peak);
        }
    }
}
