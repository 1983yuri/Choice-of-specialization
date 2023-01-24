string[] CreateStringArray()
{
    string[] newStringArr = new string[3];
    int count = newStringArr.Length;
    int i = 0;

    do
    {
        Console.WriteLine($"Input the {i + 1} of three string in turn: ");
        newStringArr[i] = Console.ReadLine(); // Можно сразу проверять как на null так и не записывать в массив значения превышающие 3 знака Нужно реализовать! Хотя, просят новый массив!
        i++; count--;                         // Надо подумать, как организовать проверку на количество символов. В одной из лекций было такое, где текст заменяли
        
    }
    while (count > 0);

    return newStringArr;
}

string[] TransformStringArray(string[] array)
{
    
    string[] newarray = new string[size];

    for( int i = 0, j = 0; i < newarray.Length; i++)
    {
        string str = newarray[i];
        int length = str.Length; 
        if(length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
        else i++; 
    }
    return array;
    
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
string[] newStrArr = TransformStringArray(strArr);
ShowStringArr(newStrArr);



