public class ExtensionRegistrationAssistant
{
    public static bool ExtensionIsRegistred { get; private set; }

    internal static void AskUserWhatToDo()
    {
        if (ExtensionIsRegistred)
        {
            Console.WriteLine("Do you want to de-register CsExe executer? (Y[es] or N[o])");
            switch (Console.ReadKey().ToString()?.ToLower())
            {
                case "y":
                    DeRegisterExtension();
                    break;
                default:
                case "n":
                    Console.WriteLine("Ok -> nothing was changed");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Do you want to register CsExe executer? (Y[es] or N[o])"); 
            switch (Console.ReadKey().ToString()?.ToLower())
            {
                case "y":
                    RegisterExtension();
                    break;
                default:
                case "n":
                    Console.WriteLine("Ok -> nothing was changed");
                    break;
            }
        }
    }

    public static void RegisterExtension()
    {
        throw new NotImplementedException();
    }

    public static void DeRegisterExtension()
    {
        throw new NotImplementedException();
    }
}