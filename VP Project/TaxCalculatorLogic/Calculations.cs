using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace TaxCalculatorLogic
{
    public class Calculations
    {
        Stack<double> oper = new Stack<double>();
        public string calculate(ArrayList operators, ArrayList operands)
        {
            double count = operands.Count;
            double op1;
            while (count != 0)
            {
                try
                {
                    string value = operands[0] as string;
                    op1 = double.Parse(value);
                    oper.Push(op1);
                    operands.Remove(value);
                    count--;
                    if (operators[0] as string == "sin")
                        oper.Push(Math.Sin(oper.Pop()));
                    else if (operators[0] as string == "tan")
                        oper.Push(Math.Tan(oper.Pop()));
                    else if (operators[0] as string == "cos")
                        oper.Push(Math.Cos(oper.Pop()));
                    else if (operators[0] as string == "tan-1")
                        oper.Push(Math.Atan(oper.Pop()));
                    else if (operators[0] as string == "cos-1")
                        oper.Push(Math.Acos(oper.Pop()));
                    else if (operators[0] as string == "sin-1")
                        oper.Push(Math.Asin(oper.Pop()));
                    else if (operators[0] as string == "sqrt")
                        oper.Push(Math.Sqrt(oper.Pop()));
                    else if (operators[0] as string == "nonfiler")
                        oper.Push(oper.Pop() * (0.2));
                    else if (operators[0] as string == "filer")
                        oper.Push((oper.Pop() * (0.1)));
                    else if (operators[0] as string == "pow")
                        oper.Push((Math.Pow(oper.Pop(), 2)));
                    else if (operators[0] as string == "exp")
                        oper.Push((Math.E));
                    else if (operators[0] as string == "log")
                        oper.Push(Math.Log10(oper.Pop()));
                    else if (operators[0] as string == "ln")
                        oper.Push(Math.Log(oper.Pop()));
                    else if (oper.Count == 2)
                    {
                        double oper1;
                        double oper2;
                        switch (operators[0] as string)
                        {
                            case "+":
                                oper2 = oper.Pop();
                                oper1 = oper.Pop();
                                oper1 += oper2;
                                oper.Push(oper1);
                                break;
                            case "-":
                                oper2 = oper.Pop();
                                oper1 = oper.Pop();
                                oper1 -= oper2;
                                oper.Push(oper1);
                                break;
                            case "/":
                                oper2 = oper.Pop();
                                oper1 = oper.Pop();
                                oper1 /= oper2;
                                oper.Push(oper1);
                                break;
                            case "*":
                                oper2 = oper.Pop();
                                oper1 = oper.Pop();
                                oper1 *= oper2;
                                oper.Push(oper1);
                                break;
                        }
                        operators.RemoveAt(0);
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return (oper.Pop().ToString());
        }
    }
}
