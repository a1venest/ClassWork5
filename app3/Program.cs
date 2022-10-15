// Задача 40: Напишите программу, которая
// принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой
// длины.
// Теорема о неравенстве треугольника: каждая
// сторона треугольника меньше суммы двух других
// сторон.


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите число: {i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Triangle(int[] arr)
{
    int i = 0;
    if(arr[i]<arr[i+1]+arr[i+2]&&arr[i+1]<arr[i]+arr[i+2]&&arr[i+2]<arr[i+1]+arr[i])
    {
        Console.WriteLine($"Треугольник со сторонами: {arr[i]}; {arr[i+1]}; {arr[i+2]} может существовать.");
    }
    else
    {
Console.WriteLine($"Треугольник со сторонами: {arr[i]}; {arr[i+1]}; {arr[i+2]} не может существовать.");
    }
}

int[] array = new int[3];
FillArray(array);
Triangle(array);