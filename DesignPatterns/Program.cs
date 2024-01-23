
using DesignPatterns.Creational;

class Program
{
    public static void Main(string[] args)
    {

        //SingletonExample();
        BuildExample();
        Console.ReadLine ();
    }

    #region Creational

    public static void SingletonExample()
    {
        Singleton singletonOne = Singleton.Instance;
        Singleton singletonTwo = Singleton.Instance;

        if(singletonOne == singletonTwo)
            Console.WriteLine("singletonOne is equal to singletonTwo");

    }

    public static void BuildExample()
    {
        UserAdminBuilder builder = new UserAdminBuilder();
        builder.Welcome("Alfredo");
        builder.SetPermissions();
        //builder.Reset();
        UserAdmin userAdmin = builder.Build();
        Console.WriteLine(userAdmin.WelcomeMessage);
        Console.WriteLine(userAdmin.Permissions);

        UserOperationBuilder builderOperation = new();
        builderOperation.Welcome("Jorge");
        builderOperation.SetPermissions();
        //builder.Reset();
        UserOperation userOperation = builderOperation.Build();
        Console.WriteLine(userOperation.WelcomeMessage);
        Console.WriteLine(userOperation.Permissions);
    }

    #endregion


}