//Задача №0
//квадрат введенного числа


Console.Write("Введите число: ");
//read from console
string? inputNum = Console.ReadLine(); //класс консоль, метод ReadLine

//check the value is not empty
if(inputNum != null)
{
    //parsing of input value
    int number = int.Parse(inputNum);

    //find the pw
 //   int outNum = number*number;
 //   int outNum = (int)Math.Pow(number, 2);

    //output
 //   Console.WriteLine("Квадрат числа: "+outNum);

    Console.WriteLine("Квадрат числа: "+(int)Math.Pow(number, 2));
}

