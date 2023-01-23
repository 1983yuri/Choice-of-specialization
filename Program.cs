string[] CreateStringArray()
{
    string[] newStringArr = new string[3];
    int count = newStringArr.Length;
    int i = 0;

    do
    {
        Console.WriteLine("Input three string in turn: ");
        newStringArr[i] = Console.ReadLine();
        i++; count--;
    }
    while (count > 0);

    return newStringArr;
}

void ShowStringArr(string[] array)
{
    int count = array.Length;
    int i = 0;

    while(count > 0)
    {
        Console.Write($"{array[i]}");
        Console.Write(" ");
        i++; count--;
    }
    
}

string[] strArr = CreateStringArray();
ShowStringArr(strArr);



