using System;

/// <summary>
/// Класс для демонстрации работы с массивами и строками.
/// </summary>
class ArrayExample
{
    /// <summary>
    /// Главный метод программы. Формирует строку из символов и вызывает метод вывода сообщений.
    /// </summary>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];

        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Выводит персонализированное сообщение с счетчиком в консоль.
    /// </summary>
    /// <param name="name">Имя, собранное из массива символов.
    /// </param>
    /// <param name="msg">Числовое значение (счетчик).
    /// </param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}