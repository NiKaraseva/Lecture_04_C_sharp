// РЕКУРСИЯ – ПРИМЕР 1. Вычисление факториала 
// Отобрази функцию, которая принимает число и на выходе даёт факториал этого числа

/* int Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1, 0! = 1
    else 
    {
        return n * Factorial(n-1);
    }
}

Console.WriteLine($"Факториал числа 3 = {Factorial(3)}"); // 1*2*3 = 6 */ 



// А что будет, если мы посчитаем факториал числа 40

/* double Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1, 0! = 1
    else 
    {
        return n * Factorial(n-1);
    }
}

for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); 
} */ 

// Тип int просто не вмещает в себя все элементы, можно попробовать решить через double (должен вместить)


// РЕКУРСИЯ – ПРИМЕР 2. Числа Фибонначи (каждое последующее число задаётся через предыдущее) 
// Определение: 
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else 
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
Console.WriteLine(Fibonacci(9)); 

/* for(int i = 1; i < 10; i++) // выводит все вычисления в столбец (перечисляет)
{
    Console.WriteLine(Fibonacci(i)); 
} */ 

// Для подсчёта более крупных чисел (при n = 40, как в вычислениях факториала) – также используем double