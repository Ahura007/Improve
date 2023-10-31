namespace RoleEngineApp;

internal class Program
{
    private static void Main()
    {
        Self.StartRoleEngine();

        var result = new RegisterRule().Evaluate().Result;
    }
}