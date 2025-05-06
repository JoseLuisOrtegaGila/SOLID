using System;

public enum HtmlType
{
    Input,
    Select,
    Textarea,
    Radio
}

// 📌 Clase que representa un elemento HTML (únicamente la estructura)
public class HtmlElement
{
    public string Id { get; }
    public HtmlType Type { get; }

    public HtmlElement(string id, HtmlType type)
    {
        Id = id;
        Type = type;
    }
}

// 📌 Clase que almacena atributos específicos del input
public class InputAttributes
{
    public string Value { get; set; }
    public string Placeholder { get; set; }

    public InputAttributes(string value, string placeholder)
    {
        Value = value;
        Placeholder = placeholder;
    }
}

// 📌 Clase separada para manejar eventos y lógica de interacción
public class InputEvents
{
    private readonly InputAttributes _attributes;

    public InputEvents(InputAttributes attributes)
    {
        _attributes = attributes;
    }

    public void SetFocus() => Console.WriteLine("Input focused");
    public string GetValue() => _attributes.Value;
    public bool IsActive() => true;
    public void RemoveValue() => _attributes.Value = string.Empty;
}

class Program
{
    static void Main()
    {
        var inputAttributes = new InputAttributes("Fernando", "Enter first name");
        var inputEvents = new InputEvents(inputAttributes);

        Console.WriteLine($"Valor inicial: {inputEvents.GetValue()}");
        inputEvents.RemoveValue();
        Console.WriteLine($"Valor después de limpiar: {inputEvents.GetValue()}");
    }
}