int[] array = {10, 12, 31, 4, 18, 51, 16, 71, 18,};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливает работу цикла при первом нахождении искомого значенияя, 
               // в противном случае будет выдавать их все имеющиеся в массиве
    }
    index++;
}