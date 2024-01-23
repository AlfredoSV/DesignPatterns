
using DesignPatterns.Creational;
using static DesignPatterns.Creational.Prototype;

class Program
{
    public static void Main(string[] args)
    {

        //SingletonExample();
        //BuildExample();
        ProtorypeExample();
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

    public static void ProtorypeExample()
    {
        Prototype.Person person = new();
        person.Name = "TestName";
        person.LastName = "TestLastName";
        person.AditionalInformation = new AditionalInformation();
        person.AditionalInformation.SetAge(26);


        Prototype.Person personClone = person.DeepCopy();
        personClone.AditionalInformation.SetAge(2);

        if(personClone == person)
            Console.WriteLine("Iguales");
    }

    #endregion


}