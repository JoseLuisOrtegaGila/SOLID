public interface ITrabajador
{
    void Trabajar();
}

public interface IComedor
{
    void Comer();
}

public class Empleado : ITrabajador, IComedor
{
    public void Trabajar()
    {
        Console.WriteLine("El empleado está trabajando.");
    }

    public void Comer()
    {
        Console.WriteLine("El empleado está comiendo.");
    }
}

public class Robot : ITrabajador
{
    public void Trabajar()
    {
        Console.WriteLine("El robot está trabajando.");
    }
}
