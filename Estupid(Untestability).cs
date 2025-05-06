public interface IEntrada
{
    string Leer();
}

public interface ISalida
{
    void Escribir(string mensaje);
}

public interface IClienteRepository
{
    void Guardar(string nombre);
}

// Implementación real de entrada/salida
public class ConsolaEntrada : IEntrada
{
    public string Leer() => Console.ReadLine();
}

public class ConsolaSalida : ISalida
{
    public void Escribir(string mensaje) => Console.WriteLine(mensaje);
}

public class ClienteService
{
    private readonly IEntrada _entrada;
    private readonly ISalida _salida;
    private readonly IClienteRepository _repo;

    public ClienteService(IEntrada entrada, ISalida salida, IClienteRepository repo)
    {
        _entrada = entrada;
        _salida = salida;
        _repo = repo;
    }

    public void RegistrarCliente()
    {
        _salida.Escribir("Ingrese el nombre del cliente:");
        string nombre = _entrada.Leer();

        _repo.Guardar(nombre);
        _salida.Escribir("Cliente registrado.");
    }
}
