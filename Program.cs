/* Напишіть програму, яка перевіряє, чи належить введене користувачем
число заданому інтервалу. Використовуйте логічні оператори для перевірки
умови належності числа до інтервалу.*/


/*
Console.WriteLine("Введіть число:");
int num = int.Parse( Console.ReadLine());
int x = 10;
int y = 50;
if ( num >= x && y >= num)
{
    Console.WriteLine("Число в діапозоні");
}
else
{
    Console.WriteLine("Число не в діапозоні");
}

*/


/*Напишіть програму для конвертації температури з градусів Цельсія в
градуси Фаренгейта або навпаки. Використовуйте арифметичні операції для
конвертації.*/
/*
double q = 33.8;
Console.WriteLine("Enter temperature in Celsius");
double num = double.Parse(Console.ReadLine());
double W = num * q;
Console.WriteLine("Enter temperature in Faringhete");
Console.WriteLine( W);
*/
/*
double q = 33.8;
Console.WriteLine("Enter temperature in Faringhete");
double num = double.Parse(Console.ReadLine());
double W = num / q;
Console.WriteLine("Enter temperature in Celsius ");
Console.WriteLine(W);
*/


//Напишіть програму, яка знаходить: суму всіх елементів у заданому масиві.
int[] mas = { 1, 2, 3, 8, 6, 10, 45 };
int sum = 0;

foreach (int NUM in mas)
{
    sum += NUM;
}
Console.WriteLine("Summa all elements in massive:" );
Console.WriteLine(sum);