// See https://aka.ms/new-console-template for more information
//programm küsib kasutajal sisestada oma eesnime;
//programm küsib kasutajal sisestada numbrit 1-3;
//kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi;
//kui kasutaja valib 2, kuvatakse eesnime 1. tähte;
//kui kasutaja valib 3, kuvatakse eesnime pikkust;

class program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Sisesta oma eesnimi");
        string userName = Console.ReadLine();
        Console.WriteLine("isesta number 1-3");
        char userInput = Convert.ToChar(Console.ReadLine());
        switch (userInput)

       
        {
            case '1':
                reverseName(userName);
                break;
            case '2':
                firstNameLetter(userName);
                break;
            case '3':
                nameLenght(userName);
                break;
  
        }
    }

    public static void reverseName(string userName)
    {
        for (int i = userName.Length - 1; i >= 0; i--)
        {
            Console.Write(userName[i]);
        }
    }
    public static void firstNameLetter(string userName)
    {
        Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
    }
    public static void nameLenght(string userName)
    {
        Console.WriteLine($"sinu nimi on {userName.Length} sümbolit pikk");


    }
}

