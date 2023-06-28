using System;
using System.Collections.Generic;

namespace Calculator
{
    class PostfixCalculator
    {
        static void Main()
        {        
            string[] tokens = Console.ReadLine().Split(' ');

            Stack<int> stack = new Stack<int>();
            foreach (string element in tokens)
            {
                int number;
                if (int.TryParse(element, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    int operand2 = stack.Pop();
                    int operand1 = stack.Pop();
                    switch (element)
                    {
                        case "+":
                            stack.Push(operand1 + operand2);
                            break;
                        case "-":
                            stack.Push(operand1 - operand2);
                            break;
                        case "*":
                            stack.Push(operand1 * operand2);
                            break;
                        case "/":
                            stack.Push(operand1 / operand2);
                            break;
                    }
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
