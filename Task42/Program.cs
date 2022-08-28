// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Пожалуйства введите количество цифр, которое будете вводить");
int N = Convert.ToInt32(Console.ReadLine());
int NPositive = InputPositiveNumber(N);
Console.WriteLine($"количество положительных чисел из введенных равно {NPositive}");
int InputPositiveNumber(int Nnumber)
{
    int Positive = 0;
    int[] array = new int[Nnumber];
    for(int i = 0; i < Nnumber; i++)
    {
        Console.WriteLine("введите очередное число");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if(array[i] > 0)
        {
            Positive++;
        }

    }
    return Positive;
}

