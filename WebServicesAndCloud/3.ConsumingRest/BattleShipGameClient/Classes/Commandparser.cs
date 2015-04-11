namespace BattleShipGameClient.Classes
{
    public static class CommandParser
    {
        public static string[] ParseUserInput(string userInput)
        {
            string[] parts = userInput.Split(' ');
            return parts;
        }

        public static CommandType ParseCommand(string command)
        {
            switch (command)
            {
                case "register":
                    return CommandType.Register;
                case "login":
                    return  CommandType.Login;
                case "create-game":
                    return  CommandType.CreateGame;
                case "join-game":
                    return CommandType.JoinGame;
                case "play":
                    return CommandType.Play;
                default:
                    return CommandType.InvalidCommand;
            }
        }
    }
}
