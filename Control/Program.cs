
 string[] array1 = {"2", "hello", "world"};
 string[] array2 = new string[array1.Length];

    int count =0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }


 