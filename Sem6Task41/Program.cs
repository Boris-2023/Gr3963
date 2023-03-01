// Задача 41: *Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//output the result
void PrintAnswer(string explain, int num)
{
    Console.WriteLine("\n" + explain + num);
}

//prints 1D array into console
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//forms a string of preset length from console
string KeyInputString(int strLen)
{
    string res = string.Empty;
    int cnt = 0;

    while (cnt < strLen)
    {
        res = res + Console.ReadKey().KeyChar;
        cnt++;
    }

    return res;
}

//derives all dec values from a string
int[] ValuesFromString(string inputStr)
{
    int[] figs = new int[inputStr.Length];//will store 1 for digits & 0 for non-digits 

    //within figs[]: mark digits with 1, others 0; & count a number of values included
    int valCnt = 0;
    for (int i = 0; i < figs.Length; i++)
    {
        if (Char.IsDigit(inputStr, i))
        {
            figs[i] = 1;
            if (i == 0 || (i > 0 && figs[i - 1] == 0)) valCnt++;//counts number of new values found
        }
        else figs[i] = 0;
    }

    if (valCnt == 0) return figs;//if no digits found at all - TODO: special return with warning

    //forming the very values by temp string
    int[] res = new int[valCnt];//array for values found
    int cnt = 0;
    bool ifFound = false;//flag - within value
    string temp = string.Empty;

    valCnt = 0;
    while (cnt < figs.Length)
    {
        if (figs[cnt] == 1)//current symbol is a digit
        {
            if (cnt > 0 && inputStr[cnt - 1] == '-') temp = temp + '-';//adjust for negative value
            temp = temp + inputStr[cnt];
            ifFound = true;
        }
        else
        {
            if (ifFound)
            {
                res[valCnt] = int.Parse(temp);
                valCnt++;
                temp = string.Empty;
                ifFound = false;
            }
        }
        cnt++;
    }
    if (ifFound) res[valCnt] = int.Parse(temp);//if the string is ended by digit

    return res;
}

//counts all positive values in the array
int NumPositiveInArr(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) cnt++;
    }
    return cnt;
}


int tapsNum = ReadDataToInt("Enter a number of keystrokes to take: ");
Console.Write("\nEnter your string (will interupt automatically): ");
string inputStr = KeyInputString(tapsNum);//takes a string from console

int[] values = ValuesFromString(inputStr);//derives all values from a string entered
Console.Write("\nThe values in the string are: ");
Print1DArr(values);

PrintAnswer("Number of positive values entered: ", NumPositiveInArr(values));//number of positive values
