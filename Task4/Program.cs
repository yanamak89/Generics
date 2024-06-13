using Task2;
using Task4;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();
        // Додавання елементів до списку
        for (int i = 0; myList.Count < 4; i++)
        {
            myList.Add(i);
        }
        
        // Виведення елементів списку за допомогою індексатора
        Console.WriteLine("Елементи у списку:");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
        // Використання розширюючого методу GetArray()
        // для отримання масиву з елементів списку

        int[] array = myList.GetArray();
        Console.WriteLine("\nЕлементи масиву, отримані через розширюючий метод:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

    }
}