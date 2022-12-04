int[] array = { 1, 52, 5, 83, 34, 5, 96, 17, 38 };

int n = array.Length;
int find = 5;

int index = 0;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        //break;                              //Прервать, т.к. несколько одтнаковых значений в массиве
    }
    index++;
}
