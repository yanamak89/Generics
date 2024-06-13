using Task2;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        // Adding elements to the list until the count reaches the initial capacity
        for (int i = 0; myList.Count < 4; i++)
        {
            myList.Add(i);
        }

        Console.WriteLine("Elements in the list:");
        myList.Add(1);
        
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
        Console.WriteLine($"Total number of elements: {myList.Count}");
    
    }
}