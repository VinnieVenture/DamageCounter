using DamageCounter;

while (true)
{
    SwordDamage swordDamage = new SwordDamage();
    Random random = new Random();
    
    Console.WriteLine("0 - ani magiczny, ani płonący\n1 - magiczny\n2 - płonący\n3magiczny i płonacy\ninne wartości - koniec: ");
    if (Int32.TryParse(Console.ReadKey(false).KeyChar.ToString(), out int number))
    {
        if (number > 3 || number < 0)
            return;

        for (int i = 0; i < 3; i++) {
            swordDamage.Roll += random.Next(1, 7);
        }

        swordDamage.SetMagic(number == 1 || number == 3);
        swordDamage.SetFlaming(number == 2 || number == 3);

        Console.WriteLine($"\nRzut: {swordDamage.Roll}. Zadane obrażenia: {swordDamage.Damage}.\n");
    }
    else
    {
        return;
    }
}