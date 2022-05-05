// string[,] table = new string[2,5];
// // String.Empty
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1,2]= "word";

// //чтобы распечатать массив используется цикл в цикле
// for (int rows=0; rows<2; rows++)
// {
//     for (int columns =0; columns<5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}- ");
//     }
// }

//int[,] matrix = new int[3, 4];

// void PrintArray(int[,] matr)
// {
//     for (int i=0; i < matr.GetLength(0); i++) //(int i=0; i<3; i++)
//     {
//     for (int j = 0; j < matr.GetLength(1); j++)  //(int j =0; j<4; j++)
//      {
//          Console.Write($"{matr[i, j]} ");
//      }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i=0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10); //[1,10) - полуинтервал !
//         }
//     }
// }


// int[,] matrix = new int[3, 4];
// PrintArray(matrix); //вывести нулевой массив 
// FillArray(matrix); // заполнить массив случайными числами
// Console.WriteLine(); //разделить массивы пустой строкой
// PrintArray(matrix); // вывести заполненный массив


// // РЕКУРСИЯ вычисление факториала 
// int Factorial(int n)
// {
//     //1! = 1
//     //0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(7)); //1*2*3*4*5




// пример рекурсии - числа Фиббоначи
// 1 1 2 3 5 8 13 21 ...
// F(n) = f(n-1) + f(n-2)
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}