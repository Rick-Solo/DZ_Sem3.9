// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Write("Введите начало диапазона: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n) Console.WriteLine("Введен неверный диапазон! Поменяйте числа местами."); // Здесь 0 считается натуральным числом. Но в разных стандартах по-разному. 
// else                                                                                // Чтобы исключить 0, нужно изменить условие на "if (m>n || m == 0)..."
// {
//     Console.WriteLine(NaturalNum(m, n));
// }
// string NaturalNum(int a, int b)
// {
//     if (a <= b) return $"{a} " + NaturalNum(a + 1, b);
//     else return string.Empty;
// }

//-----------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите начало диапазона: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n) Console.WriteLine("Введен неверный диапазон! Поменяйте числа местами."); // Здесь 0 считается натуральным числом. Но в разных стандартах по-разному. 
// else                                                                                // Чтобы исключить 0, нужно изменить условие на "if (m>n || m == 0)..."
// {
//     Console.WriteLine($"Сумма = {SumNaturalNum(m, n)}");
// }
// int SumNaturalNum(int a, int b)
// {
//     if (b == a) return a;
//     else return b + SumNaturalNum(a, b - 1);
// }

//-----------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите начало диапазона: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A(m,n) = {A(a, b)}");

int A(int m, int n)
{
    if (m == 0) return (n + 1);
    else
    {
        if (m > 0 && n == 0) return A(m - 1, 1);
        else
        {
            if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
            else return 0;
        }
    }
}
