using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicOperations;

namespace Calculator
{
    class Program
    {
        static readonly Dictionary<char, Func<double, double, double>> _operators = new Dictionary<char, Func<double, double, double>>
        {
            { '+', Operation.Add },
            { '-', Operation.Subtract },
            { '*', Operation.Multiply },
            { '^', Operation.Power }
        };


        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Enter an equation in the form <number ['+'|'-'|'*'|'^'] number> or q to exit:");
                var input = Console.ReadLine();
                if( input == "q")
                {
                    break;
                }
                try
                {
                    var operands = input.Split('+', '-', '*', '^');
                    var @operator = input.Substring(input.IndexOfAny(_operators.Keys.ToArray()), 1);
                    var operation = _operators[@operator[0]];

                    var left = double.Parse(operands[0]);

                    var right = double.Parse(operands[1]);
                    Console.WriteLine("Result = {0}", operation(left, right));
                }
                catch
                {
                    Console.WriteLine("error evaluating arguments");
                }
            }
        }
    }
}
