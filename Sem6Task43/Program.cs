// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых


//constants for more convenience
const int X = 0;
const int Y = 1;

//takes double value from console; replaces ',' with '.' if found
double ReadDataToDbl(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (double.Parse(inStr));
}

//output the result
void PrintAnswerDbl(string explain, double num, int roundDigits)
{
    Console.WriteLine(explain + Math.Round(num, roundDigits));
}

double[] TwoLinesCrossCoord(double b1, double k1, double b2, double k2)
{
    double[] coord = new double[2];

    coord[0] = (b2 - b1) / (k1 - k2);//x
    coord[1] = (k1 * b2 - k2 * b1) / (k1 - k2);//y

    return coord;
}

double TwoPtsDist(double x1, double y1, double x2, double y2)
{
    return (Math.Pow((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2), .5));
}

double TriangleSquareBySides(double side1, double side2, double side3)
{
    double pHalf;

    pHalf = (side1 + side2 + side3)/2;
    return Math.Pow(pHalf*(pHalf-side1)*(pHalf-side2)*(pHalf-side3), .5);

}

//Inputs of lines parametres
double b1 = ReadDataToDbl("Enter b1: ");
double k1 = ReadDataToDbl("Enter k1: ");
double b2 = ReadDataToDbl("Enter b2: ");
double k2 = ReadDataToDbl("Enter k2: ");
double b3 = ReadDataToDbl("Enter b3: ");
double k3 = ReadDataToDbl("Enter k3: ");

//finds crossing points
double[] crd12 = TwoLinesCrossCoord(b1, k1, b2, k2);
double[] crd13 = TwoLinesCrossCoord(b1, k1, b3, k3);
double[] crd23 = TwoLinesCrossCoord(b2, k2, b3, k3);

//find3 sides of triangle
double side1 = TwoPtsDist(crd12[X], crd12[Y], crd13[X], crd13[Y]);
double side2 = TwoPtsDist(crd12[X], crd12[Y], crd23[X], crd23[Y]);
double side3 = TwoPtsDist(crd13[X], crd13[Y], crd23[X], crd23[Y]);

//finds the square of triangle
PrintAnswerDbl("The square of triangle is: ", TriangleSquareBySides(side1,side2,side3), 3);

