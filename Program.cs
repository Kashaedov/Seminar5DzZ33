int size = 10; 
int [] array = new int [size];


void FillArray (int [] array)

{
    Random random = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = random.Next (100, 999);
    }
}

void PrintArray (int [] array)
{
    Console.WriteLine ("Ввывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write (array[i] + "\t");
    }
   
}

void ChetniyNumbers (int [] array)
{
    Console.WriteLine ();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine ( $"Количества четных чисел в массиве = {count}");
}


FillArray (array);
PrintArray (array);
ChetniyNumbers (array);
