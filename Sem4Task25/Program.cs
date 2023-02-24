// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// *Написать калькулятор с операциями +, -, /, * и возведение в степень

//read the data into integer
int ReadDataInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//read the data into string
string ReadDataStr(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//output the result
void PrintAnswer(string explain, double num)
{
    Console.WriteLine(explain + num);
}

//method to compute the result all-in-one
double CalculatorSimple(int a, int b, string act)
{
    double res = 0;
    switch (act)
    {
        case "+":
            res = a + b;
            break;
        case "-":
            res = a - b;
            break;
        case "*":
            res = a * b;
            break;
        case "/":
            res = (double)a / (double)b;
            break;
        case "pw":
            res = Math.Pow(a, b);
            break;
        default:
            Console.WriteLine($"Unable to recognize the action '{act}'! CalculatorSimple().");
            return -12345.12345;
    }

    return res;
}

int num1 = ReadDataInt("Enter value #1: ");
int num2 = ReadDataInt("Enter value #2: ");
string action = ReadDataStr("Enter operation (+, -, *, /, pw): ");

Console.WriteLine();

PrintAnswer($"{num1} {action} {num2} = ", CalculatorSimple(num1, num2, action)); //performs with unified Calculator()

