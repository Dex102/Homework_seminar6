int CountPositive (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] MyArray = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write("Input a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    MyArray[i] = number;
}

ShowArray(MyArray);

Console.Write("Count positive numbers is: " + CountPositive(MyArray));

