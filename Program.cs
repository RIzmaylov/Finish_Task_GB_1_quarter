Console.WriteLine("Добрый день! Итоговая работа Измайлова Р.Э. по основному блоку.");
Console.WriteLine();
Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");
Console.WriteLine();
Console.Write("Введите количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] arr = new string [N];
int cntReqElements = 0;

for (int i = 0; i < N; ++i)
{
    arr[i] = Console.ReadLine();
    if (arr[i].Length <= 3)
    {
        cntReqElements++;
    }
}

string[] result = new string [cntReqElements];
int nextElement = 0;

for (int i = 0; i < N; ++i)
{
    if (arr[i].Length <= 3)
    {
        result[nextElement] = arr[i];
        nextElement++;
    }
}

Console.WriteLine("Итоговый массив по условию задачи - [" + string.Join(", ", result) + "]");



