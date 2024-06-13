using System.Collections.Concurrent;

namespace Task3;

/*
 * Чарівність полягає в тому, що подарунок сам з'являється у мішку 
   та залежить від того, хто намагається відкрити мішок.
   Причому подарунок для однієї істоти може з'явитись лише 1 раз на день. 
   Використовуйте обмеження типу - інтерфейс із властивістю, 
   що зберігає тип істоти, яка намагається отримати подарунок із мішка.
 */
public class MagicalBag
{
    private ConcurrentDictionary<CreatureType, DateTime> lastGiftGiven;

    public MagicalBag()
    {
        lastGiftGiven = new ConcurrentDictionary<CreatureType, DateTime>();
    }

    public string GetGift(CreatureType creatureType)
    {
        // Перевірка, чи вже отримувала істота подарунок сьогодні
        if (lastGiftGiven.TryGetValue(creatureType, out DateTime lastGiftDate)
            && lastGiftDate.Date == DateTime.UtcNow.Date)
        {
            return $"No gift for {creatureType} today!";
        }
        
        // Зберігаємо дату отримання подарунка
        lastGiftGiven.AddOrUpdate(
            creatureType, DateTime.UtcNow, 
            (key, oldValue)
            => DateTime.UtcNow);
        return GenerateGift(creatureType);
    }

    private string GenerateGift(CreatureType creatureType)
    {
        // Логіка генерації подарунка відповідно до типу істоти
        return $"A special gift for {creatureType}";
    }
}