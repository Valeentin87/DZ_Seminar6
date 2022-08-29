// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Пожалуйства введите количество цифр, которое будете вводить");
int N = Convert.ToInt32(Console.ReadLine());
int[] UserNumber = InputNumber(N);
int result = PositiveNumber(UserNumber);
Console.WriteLine($"количество положительных чисел из введенных равно {result}");
int[] InputNumber(int Nnumber)
{
    int[] array = new int[Nnumber];
    for (int i = 0; i < Nnumber; i++)
    {
        Console.WriteLine("введите очередное число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int PositiveNumber(int[] arrayUser)
{
    int positive = 0;
    for (int i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i] > 0)
        {
            positive++;
        }
    }
    return positive;
}

