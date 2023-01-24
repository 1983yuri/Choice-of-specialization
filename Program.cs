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
   int count = 0;
   int i, j = 0; 

   for(i = 0; i < array.Length; i++)
   {
    string str = array[i];
    int length = str.Length;
    if(length <= 3) count++;
   }

   string[] newArr = new string[count];
   
   for(i, j = 0; i < array.Length; i++)
   {
    string str = array[i];
    int length = str.Length;
    if(length <= 3)
    {
        newArr[j] = array[i];
        j++;
    }
    else i++;
   }
    return newArr;
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
Console.WriteLine();
string[] newStrArr = TransformStringArray(strArr);
ShowStringArr(newStrArr);



