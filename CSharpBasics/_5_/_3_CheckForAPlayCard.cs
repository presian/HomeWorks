﻿using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Please enter the card: ");
        string card = Console.ReadLine();
        switch (card)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "D":
            case "K":
            case "A":
                Console.WriteLine("Valid card sign? - YES");
                break;
            default:
                Console.WriteLine("Valid card sign? - NO");
                break;
        }
    }
    }
