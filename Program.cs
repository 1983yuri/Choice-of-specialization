string[] CreateStringArray(int size)
{
    string[] newStringArr = new string[size];
    int count = newStringArr.Length;
    int i = 0;

    do
    {
        Console.WriteLine($"Input the {i + 1} of {size} string in turn: ");
        newStringArr[i] = Console.ReadLine(); 
        i++; count--;                         
    }
    while (count > 0);

    return newStringArr;
}

string[] TransformStringArray(string[] array)
{
   int count = 0;
   int i, j = 0; 

   for(i = 0; i < array.Length; i++) // Вычисляем размер нового массива
   {
    string str = array[i];
    int length = str.Length;
    if(length <= 3) count++;
   }

   string[] newArr = new string[count];
   
   for(i = 0; i < array.Length; i++) 
   {
    string str = array[i];
    int length = str.Length;
    if(length <= 3)
    {
        newArr[j] = array[i];
        j++;
    }
    
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

Console.WriteLine("Input the count of strings, you want to input: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] strArr = CreateStringArray(size);
Console.WriteLine("The inputed string array is:");
ShowStringArr(strArr);
Console.WriteLine();
Console.WriteLine("The new string array is: ");
string[] newStrArr = TransformStringArray(strArr);
ShowStringArr(newStrArr);



