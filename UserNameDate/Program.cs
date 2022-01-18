// See https://aka.ms/new-console-template for more information



class program
{
    static void Main(string[] args)
    { 
    //programm küsib kasutajal sisestada oma eesnime;
    //programm kuvab kasutaja eesnime pikkust;
    //programm kuvab kasutaja eesnime esimest tähte;
    //programm kuvab kasutaja eesnime tagurpidi;
    //main meetodis ei tohi olla rohkem, kui 3 rida koodi;

    

        Console.WriteLine("Sisesta oma eesnimi");
        string userName = Console.ReadLine();
        GetUserNameData(userName);

    }
    public static void GetUserNameData(string userInput)
    {
        Console.WriteLine($"sinu nimi on {userInput.Length} sümbolit pikk");
        Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

        for (int i = userInput.Length -1; i >= 0; i--)
        {
            Console.Write(userInput[i]);
            }
    }

}






