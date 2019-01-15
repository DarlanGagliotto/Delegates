using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate.Services;

namespace Delegate
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double BinaryNumericOperationSquare(double n1);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation opSum = CalculationService.Sum;
            BinaryNumericOperation opMax = CalculationService.Max;
            BinaryNumericOperationSquare opSquare = CalculationService.Square;

            double sum = opSum.Invoke(a, b);
            double max = opMax.Invoke(a, b);
            double square = opSquare.Invoke(a);

            Console.WriteLine($"SUM : {sum}");
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Square : {square}");
        }
    }
}
