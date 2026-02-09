
Wizard wizardA = new Wizard("Mikadou", 20);
Wizard wizardB = new Wizard("Todou", 24);


Console.WriteLine("Permainan Dimulai...\n");
wizardA.ShowStats();
wizardB.ShowStats();
wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardB.Heal();
wizardA.Attack(wizardB);

Console.WriteLine("Permainan berakhir\n");
wizardA.ShowStats();
wizardB.ShowStats();

public class Wizard
{
    //deklarasi field
    public string Name;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public Wizard(string nama, int damage)
    {
        Name = nama;
        Energi = 100;
        Damage = damage;

    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi} \n");
    }

    public void Attack(Wizard wizardLawanOBJ)
    {
        //mengurangi energi wizarLawanOBJ sebesar damage
        wizardLawanOBJ.Energi -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanOBJ.Name}");
        Console.WriteLine($"sisa energi {wizardLawanOBJ.Name} adalah {wizardLawanOBJ.Energi}");
    }

    public void Heal()
    {   
        Energi += 5;

        //menambah energi
        if (Energi <= 100)
        {
            
            Console.WriteLine($"{Name} melakukan heal! Energi meningkat menjadi {Energi}");
        }
        else
        {
            Energi = 100; 
            Console.WriteLine("Sudah mencapai energi maksimum!");
        }

    }
}


