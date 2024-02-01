// Создать массив и заполнить его целыми числами от 1 до N. Вывести элементы массива на экран.
// Пример: N = 4 => 1 2 3 4; T = 6 => 1 2 3 4 5 6 

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    // System.Console.Write(arr[i]);
    // System.Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
    
}
