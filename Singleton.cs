using System;

public class Singleton
{
    private static Singleton _instance;

    // Constructor privado para evitar la creación de instancias externas
    private Singleton()
    {
        InstanceData = "I am the instance";
    }

    public string InstanceData { get; private set; }

    // Método público para obtener la instancia única
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}

class Program
{
    static void Main()
    {
        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();

        Console.WriteLine("¿Misma instancia? " + (instance1 == instance2));
    }
}
