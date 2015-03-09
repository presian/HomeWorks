namespace StudentSystem.Client.SystemClasses
{
    static class CommandParser
    {       
        public static CommandType Parse(string command)
        {
            switch (command)
            {
                case "1":
                    return CommandType.ListStudentsInfo;
                case "2":
                    return CommandType.ListCoursesInfo;
                case "3":
                    return CommandType.AddCourse;
                case "4":
                    return CommandType.AddStudent;
                case "5":
                    return CommandType.AddResource;
                case "6":
                    return CommandType.Exit;
                default:
                    return CommandType.InvalidCommand;
            }
        }
    }
}
