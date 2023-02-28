// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//output the result
void PrintAnswer(string explain, bool num)
{
    Console.WriteLine(explain + num);
}

bool TestABC(int a, int b, int c)
{
    return(a<= b+c);
}

//if triangle with such sides exists
bool IfTriangle(int a, int b, int c)
{
    if(TestABC(a, b, c) && TestABC(b, a, c) && TestABC(c, a, b)) return true;
    else return false;
}

int sideA = ReadDataToInt("Length of side 1: ");
int sideB = ReadDataToInt("Length of side 2: ");
int sideC = ReadDataToInt("Length of side 3: ");

PrintAnswer("A triangle with such sides can exist: ", IfTriangle(sideA, sideB, sideC));

