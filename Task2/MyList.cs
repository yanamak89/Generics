namespace Task2;

/*
 * Створіть клас MyList. 
   Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно 
   екземпляру класу List. 
   Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати 
   метод додавання елемента, 
   індексатор для отримання значення елемента за вказаним індексом
   властивість тільки для читання для отримання загальної кількості елементів.
 */
public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4]; // початковий розмір масиву
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }

        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Індекс поза межами допустимого діапазону");
            }

            return items[index];
        }
    }

    public int Count
    {
        get { return count; }
    }
    
    
}