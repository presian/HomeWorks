namespace BattleShipGameClient.Classes
{
    using System;
    using System.Net;

    public static class CommandExecuter
    {
        private static Requester requester;

        static CommandExecuter()
        {
            requester = new Requester();
        }

        public static string ExecuteCommand(CommandType command, string[] commandAsParts)
        {
            if (CheckParametersCount(commandAsParts, command))
            {
                switch (command)
                {
                    case CommandType.Register:
                        return ExecuteRegisterCommand(commandAsParts);
                    case CommandType.Login:
                        return ExecuteLoginCommand(commandAsParts);
                    case CommandType.CreateGame:
                        return ExecuteCreateGameCommand(commandAsParts);
                    case CommandType.JoinGame:
                        return ExecuteJoinGame(commandAsParts);
                    case CommandType.Play:
                        return ExecutePlayCommand(commandAsParts);
                    default:
                        return ErrorMessage.InvalidCommand;
                }
            }
            else
            {
                return ErrorMessage.InvalidCountOfParameters;
            }
            
        }

        private static string ExecutePlayCommand(string[] commandAsParts)
        {
            string gameId = commandAsParts[1];
            int x = int.Parse(commandAsParts[2]);
            int y = int.Parse(commandAsParts[3]);

            var response = requester.MakePlay(gameId, x, y);
            switch (response)
            {
                case HttpStatusCode.BadRequest:
                    return ErrorMessage.NotYourTurn;
                case HttpStatusCode.OK:
                    return CommandResulMessage.YouMakeYourTurn;
                default:
                    return ErrorMessage.ConnectionProblem;
            }
        }

        private static string ExecuteJoinGame(string[] commandAsParts)
        {
            string gameId = commandAsParts[1];
            var response = requester.MakeJoinGame(gameId);

            switch (response)
            {
                case HttpStatusCode.BadRequest:
                    return ErrorMessage.CanNotJoinGame;
                case HttpStatusCode.OK:
                    return CommandResulMessage.JoiningGameCompleate;
                default:
                    return ErrorMessage.ConnectionProblem;
            }
        }

        private static string ExecuteCreateGameCommand(string[] commandAsParts)
        {
            string response = requester.MakeCreateGame();
            return string.Format(CommandResulMessage.CreatingGameCompleate, response); 
        }

        private static string ExecuteLoginCommand(string[] commandAsParts)
        {
            var username = commandAsParts[1];
            var password = commandAsParts[2];

            try
            {
                var response = requester.MakeLogin(username, password);
                if (response == HttpStatusCode.OK)
                {
                    return CommandResulMessage.LoginCompleate;
                }
                if (response == HttpStatusCode.BadRequest)
                {
                    return ErrorMessage.LoginAuthFailed;
                }

                return ErrorMessage.LoginFailed;
            }
            catch (Exception)
            {
                return ErrorMessage.LoginFailed;
            }
        }

        private static string ExecuteRegisterCommand(string[] commandAsParts)
        {
            if (commandAsParts[2] != commandAsParts[3])
            {
                return ErrorMessage.DeifferentPasswords;
            }

            var email = commandAsParts[1];
            var password = commandAsParts[2];
            var confirmPassword = commandAsParts[3];

            try
            {
                var responseStatus = requester.MakeRegistration(email, password, confirmPassword);
                if (responseStatus == HttpStatusCode.OK)
                {
                    return CommandResulMessage.RegistrationCompleate;
                }

                return ErrorMessage.RegistrationFailed;
            }
            catch (Exception)
            {

                return ErrorMessage.RegistrationFailed;
            }
        }

        private static bool CheckParametersCount(string[] commandAsParts, CommandType command)
        {
            switch (command)
            {
                case CommandType.Register:
                    return 4 == commandAsParts.Length;
                case CommandType.Login:
                    return 3 == commandAsParts.Length;
                case CommandType.CreateGame:
                    return 1 == commandAsParts.Length;
                case CommandType.JoinGame:
                    return 2 == commandAsParts.Length;
                case CommandType.Play:
                    return 4 == commandAsParts.Length;
                default:
                    return false;
            }
        }
    }
}
