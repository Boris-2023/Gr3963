// Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

//reads the data into string
string ReadDataStr(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//takes a string 'str' from console & return a string array by preset delimiter 'delim'; elim all spaces
string[] MakeStringArr(string str, char delim)
{
    str = str.Replace(" ", "");
    string[] res = str.Split(delim);
    return res;
}


string namesList = ReadDataStr("Enter the names divided by ',': ");//takes a string of names
string[] names = MakeStringArr(namesList, ',');//makes an array of names
string nameToGo = names[new Random().Next(0,names.Length)];//randomly choose one name

Console.WriteLine("Today is a turn of: {0}", nameToGo);//output the name chosen

