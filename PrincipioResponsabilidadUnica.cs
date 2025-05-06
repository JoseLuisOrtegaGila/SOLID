//Herencia - Alto acoplamiento

class Vehiculo
{
    public void Acelerar() => Console.WriteLine("El vehiculo está acelerando");
    public void Frenar() => Console.WriteLine("El vehículo está frenando");
}

class Coche : Vehiculo
{
    public void EncenderRadio() => Console.WriteLine("Radio Encendida");
}

class Motocicle : Vehiculo
{
    public void HacerCaballito() => Console.WriteLine("Haciendo un caballito");
}
 Problemas con este diseño:
Las clases hijas dependen de la clase base: Si Vehiculo cambia, Coche y Motocicleta también pueden verse afectadas.

Dificultad para reutilizar Acelerar y Frenar en otros objetos que no sean Vehiculo.

Si queremos agregar un vehículo con un comportamiento distinto, tendríamos que modificar la clase base, lo que rompe el Principio Abierto/Cerrado (OCP).


interface IMovimiento
{
    void Acelerar();
    void Frenar();
}

class MovimientoNormal : IMovimiento
{
    public void Acelerar() => Console.WriteLine("Acelerando normalmente");
    public void Frenar() => Console.WriteLine("Frenando suavemente");
}
class Coche
{
    private readonly IMovimiento _movimiento;

    public Coche(IMovimiento movimiento)
    {
        _movimiento = movimiento;
    }

    public void Conducir()
    {
        Console.WriteLine("Conduciendo el coche");
        _movimiento.Acelerar();
    }

    public void EncenderRadio() => Console.WriteLine("Radio encendida");
}
class Motocicleta
{
    private readonly IMovimiento _movimiento;

    public Motocicleta(IMovimiento movimiento)
    {
        _movimiento = movimiento;
    }

    public void Conducir()
    {
        Console.WriteLine("Manejando la motocicleta");
        _movimiento.Acelerar();
    }

    public void HacerCaballito() => Console.WriteLine("Haciendo un caballito");
}

 Beneficios de la solución con composición:
✔ Bajo acoplamiento: Coche y Motocicleta no dependen de una jerarquía de clases.
✔ Mayor flexibilidad: Podemos cambiar la implementación de IMovimiento sin modificar Coche ni Motocicleta.
✔ Cumple con el Principio de Inversión de Dependencias (DIP): Coche y Motocicleta dependen de una interfaz (IMovimiento), no de una implementación específica.