//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//==========================================

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//Computes 'a' into power 'b' 
long RecPow(int a, int b)//classic recursion
{
    if (b <= 1)
    {
        return a;
    }
    else
    {
        return a * (RecPow(a, b - 1));
    }
}

long MyPow(int a, int b)//optimized for even powers - faster; if universal - different for even & odd figures
{
    if(b==2)
    {
        return 4;
    }
    return MyPow(a, b/2)*MyPow(a, b/2);
}

int a = ReadDataToInt("Enter the base : ");
int b = ReadDataToInt("Enter the power: ");

Console.WriteLine();

Console.WriteLine(RecPow(a, b));
Console.WriteLine(MyPow(a, b));


