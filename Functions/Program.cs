// See https://aka.ms/new-console-template for more information

class program
{

    static void Main(string[] args)
    {
        Console.WriteLine("sisesta esimest arvu");
        int userNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sisesta teist arvu");
        int userNumbertwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("vali tehe (sisesta '+','-', '*' või  '/'");
        char userOperator = Convert.ToChar(Console.ReadLine());
        switch (userOperator)
        {
            case '+':
                AddTwoNumbers(userNumberOne, userNumbertwo);
                break;
            case '/':
                divideTwoNumbers(userNumberOne, userNumbertwo);
                break;
            case '*':
                multiplyTwoNumbers(userNumberOne, userNumbertwo);
                break;
            case '-':
                subtractTwoNumbers(userNumberOne, userNumbertwo);
                break;
            default:
                Console.WriteLine("kena päeva");
                break;
        }
    }

    public static void AddTwoNumbers(int x, int y)
    {
        int result = x + y;
        Console.WriteLine(result);
    }
    public static void divideTwoNumbers(double x, int y)
    {
        double result = x / y;
        Console.Write(result);
    }
    public static void multiplyTwoNumbers(double x, int y)
    {
        double result = x * y;
        Console.Write(result);

    }
    public static void subtractTwoNumbers(double x, int y)
    {
        double result = x - y;
        Console.Write(result);

    }
}






