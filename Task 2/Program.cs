// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine($"Задайте количество строк (м)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (n)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] nums = new int [m, n];
if(m!=n) {
    Console.WriteLine($"Матрица не квадратная");
} else {
    FillArr(nums);
    PrintArr(nums);
    int [,] newarr = new int [m,n];
    for(int i = 0; i<nums.GetLength(0); i++) {
        for(int j = 0; j<nums.GetLength(1); j++) {
            newarr [j,i] = nums [i,j];
        }
    }
    for(int i = 0; i<nums.GetLength(0); i++) {
        for(int j = 0; j<nums.GetLength(1); j++) {
            nums [i,j] = newarr [i,j];
        }
    }
    PrintArr(nums);
}

void FillArr (int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            num [i, j] = new Random().Next(1,10);

        }
    }
}

void PrintArr(int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            Console.Write($"{num [i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}