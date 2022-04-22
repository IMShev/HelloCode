// Методы 
// Вид 1 ничего не принимают, ничего не возвращают VOID
void Method1()
{
    Console.WriteLine ("Автор Иванов Иван Иванович");
}
// для вызова метода необходимо указать идентификатор метода и пустые круглые скобки ()
Method1();






// Вид 2 могут принимать какие-то данные (аргументы), но ничего не возвращают VOID
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)  // если принимает несколько аргументов разных типов, то обращение 
                                      //(задание параметров) к конкретному аргументу будет через двоеточие
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
       i++;
    }
}
// Method21("Текст", 4); // вызывает 4 раза сообщение "Текст"
// Method21(msg: "Текст", count: 4); //можно явно указать какому аргументу и какое значение необходимо присвоить через двоеточие
Method21(count: 4, msg: "Новый Текст"); // порядок обращения к именованым аргументам может быть произвольным 






//Вид 3 ничего не принимают, но что-то возвращают (RETURN)
// необходимо обязательно указать тип данных которые метод должен возвращать

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);









//Вид 4  что-то принимают и что-то возвращают RETURN

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // переменной result вначале присваивается пустое значение string.empty или ("")

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "xz ");
Console.WriteLine(res);




string Method41(int count, string text) // тот же метод, но с циклом FOR (все циклы взаимозаменяемые)
{
    string result = String.Empty; 
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res1 = Method41(5, "s");
Console.WriteLine(res1);





//цикл в цикле - когда необходимо пройтись по двум и более параметрам
// вывод на экран таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); // интерполяция строк $
    }
    Console.WriteLine(); // чтобы между результами работы внешнего и внутреннего циклов была пустая строка
}






//====== Работа с текстом
// Задача:  Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - Сказал князь, улыбаяСь, - что "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    } 


    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();





// Задача: сортировка массива методом выбора минимального значения элемента

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1, 10, 23, 17, 9 };

void PrintArray(int[] array) // метод для вывода массива на экран
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)  //метод, который будет упорядочивать массив от мин к макс
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}



void SelectionSortMax(int[] array)  //метод, который будет упорядочивать массив от макс к мин
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporaryMax = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporaryMax;
    }
}





PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);

