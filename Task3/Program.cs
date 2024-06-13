using Task3;

class Program
{
    static void Main(string[] args)
    {
        MagicalBag magicalBag = new MagicalBag();
        Console.WriteLine(magicalBag.GetGift(CreatureType.Dwart));
        Console.WriteLine(magicalBag.GetGift(CreatureType.Elf));
        
        Console.WriteLine(magicalBag.GetGift(CreatureType.Elf));
        Console.WriteLine(magicalBag.GetGift(CreatureType.Magisian));
        Console.WriteLine(magicalBag.GetGift(CreatureType.Witch));
        
    }

}