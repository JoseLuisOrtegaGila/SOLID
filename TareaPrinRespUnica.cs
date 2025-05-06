using System;

public enum HtmlType
{
    Input,
    Select,
    Textarea,
    Radio
}

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

public class InputAttributes : HtmlElement
{
    public string Value { get; set; }
    public string Placeholder { get; set; }

    public InputAttributes(string value, string placeholder, string id)
        : base(id, HtmlType.Input)
    {
        Value = value;
        Placeholder = placeholder;
    }
}

public class InputEvents : InputAttributes
{
    public InputEvents(string value, string placeholder, string id)
        : base(value, placeholder, id)
    {
    }

    public void SetFocus() {}
    public string GetValue() => Value;
    public bool IsActive() => true;
    public void RemoveValue() => Value = string.Empty;
}

class Program
{
    static void Main()
    {
        var nameField = new InputEvents("Fernando", "Enter first name", "txtName");
        Console.WriteLine(nameField);
    }
}
