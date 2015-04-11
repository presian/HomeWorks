namespace BattleShipGameClient.Classes
{
    class ErrorMessage
    {
        public const string DeifferentPasswords = "Password and confirm password are not equal!";
        public const string InvalidCountOfParameters = "Count of parameteres is not right!";
        public const string InvalidCommand = "Invalid command!";

        public const string RegistrationFailed = "Registration failed! Please try again later with different email!";
        public const string LoginFailed = "Login failed! Please try again later!";
        public const string LoginAuthFailed = "Login failed! Invalid pair -> username/password!";

        public const string Unauthorized = "You are unauthorized!";
        public const string ConnectionProblem = 
            "We can not execute this command at the moment please try again later!";
        public const string CanNotJoinGame = "You can not join in your game!";

        public const string NotYourTurn = "It's not your turn!";
    }
}
