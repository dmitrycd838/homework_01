// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if ( N < 10)
{
    System.Console.WriteLine(N);
}
else
{
    while (N > 10){
        int currentDigit = N % 10;
        N /= 10;
        if (N >= 0){
            Console.Write(currentDigit + ",");
        }
        else{
            Console.Write(currentDigit);
        }
    }
}

