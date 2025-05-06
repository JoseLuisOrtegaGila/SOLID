class Notificador
{
    public void EnviarEmail(string mensaje)
    {
        Console.WriteLine($"Enviando Email: {mensaje}");
    }
}

class Pedido : Notificador
{
    public void ConfirmarPedido()
    {
        Console.WriteLine("Pedido confirmado.");
        EnviarEmail("Tu pedido ha sido confirmado."); // ❌ Dependencia directa
    }
}

🚨 Problemas de alto acoplamiento:
La clase Pedido está atada a Notificador

No puede cambiar fácilmente el mecanismo de notificación (ejemplo: cambiar email por SMS).

Si Notificador cambia su implementación, Pedido también se verá afectada.

Dificulta la reutilización y pruebas

No se puede reutilizar Pedido sin Notificador.

No se puede probar Pedido sin que se ejecuten métodos de Notificador.


Solución: Bajo acoplamiento con inyección de dependencias
En lugar de usar herencia, usamos composición e interfaces para desacoplar las clases.

interface INotificador
{
    void Enviar(string mensaje);
}

class EmailNotificador : INotificador
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"Enviando Email: {mensaje}");
    }
}

class Pedido
{
    private readonly INotificador _notificador;

    public Pedido(INotificador notificador)
    {
        _notificador = notificador;
    }

    public void ConfirmarPedido()
    {
        Console.WriteLine("Pedido confirmado.");
        _notificador.Enviar("Tu pedido ha sido confirmado.");
    }
}



