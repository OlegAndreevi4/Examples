int[] array = { 3, 43, 54, 664, 66, 22, 778, 9 };

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //break; если несколько значений
    }
    index++;
}