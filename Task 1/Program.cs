//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int [,] nums = new int [2, 3];
FillArr(nums);
PrintArr(nums);
int [] row = new int [nums.GetLength(1)];
for(int i = 0; i<nums.GetLength(0); i++) {
    for(int j = 0; j<nums.GetLength(1); j++) {
        row [j] = nums [i,j];
    }
    BubbleSort(row);
    for(int j = 0; j<nums.GetLength(1); j++) {
        nums [i,j] = row [j];
    }
}

PrintArr(nums);

void BubbleSort (int [] inArray) {
    for(int i = 0; i<inArray.Length; i++) {
        for(int j = 0; j<inArray.Length-i-1; j++) {
            if (inArray[j]<inArray[j+1]) {
                int temp = inArray[j];
                inArray[j] = inArray[j+1];
                inArray[j+1] = temp;

            }
        }    
    }        

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


    
        
            
                

      
