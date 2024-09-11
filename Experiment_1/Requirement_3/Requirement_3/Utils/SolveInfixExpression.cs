namespace Requirement_3.Utils
{
    internal class SolveInfixExpression
    {
        class NumberBuffer
        {
            private List<int> buffer = new List<int>();
            private bool isDecimal;
            private bool isNegative;
            private double resultNum;
            private bool transform;

            public NumberBuffer()
            {
                isDecimal = false;
                resultNum = 0;
                transform = false;
                isNegative = false;
            }

            public void appendBuffer(char n)
            {
                transform = true;
                buffer.Add(n - '0');
            }

            public void changeDecimal()
            {
                isDecimal = true;
            }

            public void changeInt()
            {
                isDecimal = false;
            }

            public void changeNegative()
            {
                isNegative = true;
            }

            public void changePositive()
            {
                isNegative = false;
            }

            public void setResultNum()
            {
                if (!isDecimal)
                {
                    foreach (int i in buffer)
                    {
                        resultNum = resultNum * 10 + i;
                    }
                    buffer.Clear();
                }
                else
                {
                    for (int i = 0; i < buffer.Count(); ++i)
                    {
                        resultNum = (resultNum * Math.Pow(10, i + 1) + buffer[i]) / Math.Pow(10, i + 1);
                    }
                    buffer.Clear();
                }
            }

            public double getResultNum()
            {
                double res = resultNum;
                if (isNegative)
                {
                    res = -res;
                    changePositive();
                }
                resultNum = 0;
                transform = false;
                return res;
            }

            public bool checkTransform()
            {
                return transform;
            }
        };

        enum Priority
        {
            Less,
            NotLess
        };

        class SignUtil
        {
            public static Priority comparePriority(char first, char second)
            {
                if ((first == '+' || first == '-') && (second == '*' || second == '/') || second == '(' || first == '(' || (first == '+' || first == '-' || first == '*' || first == '/') && (second == '^'))
                {
                    return Priority.Less;
                }
                else
                {
                    return Priority.NotLess;
                }
            }

            public static void compute(ref Stack<double> numStack, ref Stack<char> signStack)
            {
                double second = numStack.Peek();
                numStack.Pop();
                double first = numStack.Peek();
                numStack.Pop();
                char sign = signStack.Peek();
                signStack.Pop();
                if (sign == '+')
                {
                    numStack.Push(first + second);
                }
                if (sign == '-')
                {
                    numStack.Push(first - second);
                }
                if (sign == '*')
                {
                    numStack.Push(first * second);
                }
                if (sign == '/')
                {
                    numStack.Push(first / second);
                }
                if (sign == '^')
                {
                    numStack.Push(Math.Pow(first, second));
                }
            }
        };

        private string Expression { get; set; } = "";

        public SolveInfixExpression(string? Expression)
        {
            if (Expression == null) this.Expression = "";
            else this.Expression = Expression;
        }

        public string Solve()
        {
            string infixExpression = Expression;
            Stack<double> numStack = new Stack<double>();
            Stack<char> signStack = new Stack<char>();
            NumberBuffer numberBuffer = new NumberBuffer();
            string tempInfixExpression = infixExpression;
            for (int i = 0; i < tempInfixExpression.Length; ++i)
            {
                if (infixExpression[i] == '-')
                {
                    if (i == 0)
                    {
                        infixExpression = '#' + infixExpression.Substring(i + 1);
                    }
                    else if (!char.IsDigit(tempInfixExpression[i - 1]) && tempInfixExpression[i - 1] != ')')
                    {
                        infixExpression = infixExpression.Substring(0, i) + '#' + infixExpression.Substring(i + 1);
                    }
                }
            }
            for (int i = 0; i < infixExpression.Length; ++i)
            {
                if (infixExpression[i] >= '0' && infixExpression[i] <= '9')
                {
                    numberBuffer.appendBuffer(infixExpression[i]);
                    if (i == infixExpression.Length - 1)
                    {
                        numberBuffer.setResultNum();
                        numStack.Push(numberBuffer.getResultNum());
                    }
                }
                else if (infixExpression[i] == '.')
                {
                    numberBuffer.setResultNum();
                    numberBuffer.changeDecimal();
                }
                else if (infixExpression[i] == '#')
                {
                    numberBuffer.changeNegative();
                }
                else
                {
                    if (numberBuffer.checkTransform())
                    {
                        numberBuffer.setResultNum();
                        numberBuffer.changeInt();
                        numStack.Push(numberBuffer.getResultNum());
                    }
                    if (infixExpression[i] == ')')
                    {
                        while (signStack.Peek() != '(')
                        {
                            SignUtil.compute(ref numStack, ref signStack);
                        }
                        signStack.Pop();
                    }
                    else if (signStack.Count() == 0 || SignUtil.comparePriority(signStack.Peek(), infixExpression[i]) == Priority.Less)
                    {
                        signStack.Push(infixExpression[i]);
                    }
                    else
                    {
                        while (signStack.Count() != 0 && SignUtil.comparePriority(infixExpression[i], signStack.Peek()) == Priority.Less)
                        {
                            SignUtil.compute(ref numStack, ref signStack);
                        }
                        signStack.Push(infixExpression[i]);
                    }
                }
            }
            while (signStack.Count() != 0)
            {
                SignUtil.compute(ref numStack, ref signStack);
            }
            return numStack.Peek().ToString();
        }
    }
}
