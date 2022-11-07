// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int [,] nums = new int [4, 2];
FillArr(nums);
PrintArr(nums);
int minRowSum = FirstRow(nums);
int indexMinRow = 1;

for(int i = 1; i<nums.GetLength(0); i++) {
    int rowSum = 0;
    for(int j = 0; j<nums.GetLength(1); j++) {
       rowSum += nums[i,j];
    }
    if(minRowSum>rowSum) {
        minRowSum=rowSum;
        indexMinRow += i;
    } 
}
       
Console.WriteLine($"Строка с наименьшей суммой элементов № "+  indexMinRow);   
Console.WriteLine($"Сумма элементов "+minRowSum);

int FirstRow(int [,] num) {
    int result = 0; 
    for(int i = 0; i==0; i++) {
        for(int j = 0; j<num.GetLength(1); j++) {
            result += num [i,j];
        }
    }
    return result;
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