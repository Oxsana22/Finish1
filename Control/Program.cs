string[] array1 = {"2", "hello", "world", ":)"};
 string[] array2 = new string[array1.Length];

void Array(string[] array1, string[]array2)
{
    int count =0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{ array[i]   }  ");
    // break;
    }

}
Array(array1, array2);
Console.WriteLine("Сформированный массив строк, длина которых меньше либо  равна трём символам: ");
PrintArray(array2);