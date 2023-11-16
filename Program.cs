using Lab_7_Unit_Testing;

BasicMath math = new BasicMath();
Console.WriteLine("Please input the 1st number");
double num1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Please input the 2nd number");
double num2 = Double.Parse(Console.ReadLine());

double sum = math.Add(num1, num2);
Console.WriteLine("num1 + num2 = " + sum);
double difference = math.Subtract(num1, num2);
Console.WriteLine("num1 - num2 = " + difference);
double quotient = math.Divide(num1, num2);
Console.WriteLine("num1 / num2 = " + quotient);
double product = math.Multiply(num1, num2);
Console.WriteLine("num1 * num2 = " + product);