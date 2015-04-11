namespace BattleShipGameClient
{
    using System;

    using Classes;

    class BattleShipGameClient
    {
        static void Main()
        {
            bool isExit = false;
            
            while (!isExit)
            {
                var userInput = GetUserInput();
                isExit = CheckUserInputForExitCommand(userInput, isExit);

                if (!isExit)
                {
                    var commandResult = ExecuteCommand(userInput);
                    Console.WriteLine(commandResult);
                }
            }
        }

        private static string ExecuteCommand(string userInput)
        {
            string[] commandAsParts = CommandParser.ParseUserInput(userInput);
            var command = CommandParser.ParseCommand(commandAsParts[0]);
            var commandResult = CommandExecuter.ExecuteCommand(command, commandAsParts);
            return commandResult;
        }

        private static bool CheckUserInputForExitCommand(string userInput, bool isExit)
        {
            if (string.IsNullOrEmpty(userInput) 
                || userInput.ToLower() == "end" 
                || userInput.ToLower() == "exit")
            {
                isExit = true;
            }

            return isExit;
        }

        private static string GetUserInput()
        {
            Console.Write("Enter a command: ");
            var userInput = Console.ReadLine();
            return userInput;
        }
    }
}
