using System;
using System.Text;

class PrinTaDeckOf52Cards
{
    static void Main()
    {
        for (int i= 2; i <= 14; i++)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string card = Convert.ToString(i); 
            switch (card)
            {
                case "11":
                    card = "J";
                    break;
                case "12":
                    card = "Q";
                    break;
                case "13":
                    card = "K";
                    break;
                case "14":
                    card = "A";
                    break;
            }
            for (int n  = 0; n < 4; n++)
            {                                
                    
                switch (n)
                {
                    case 0:
                        Console.Write("{0}" + '\x0005' + " ", card);
                        break;
                    case 1:
                        Console.Write("{0}" + '\x0004' + " ", card);
                        break;
                    case 2:
                        Console.Write("{0}" + '\x0003' + " ", card);
                        break;
                    default:
                        Console.Write("{0}" + '\x0006' + " \n", card);
                        break;
                }
            }
        } 
    }
}

