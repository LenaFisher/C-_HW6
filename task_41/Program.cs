// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите сколько цифр вы введете: ");
int quantityNumbers = Convert.ToInt32(Console.ReadLine());

int result = getPositive(quantityNumbers);
Console.WriteLine(result);

int getPositive(int qtNumbers)
{
    int[] arr = new int[qtNumbers];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число:  ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}














