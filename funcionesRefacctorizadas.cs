using System;
using System.Collections.Generic;

class Program
{
    // Resolver sin la triple condicional dentro del if
    // includes? arrays?
    static bool IsRedFruit(string fruit)
    {
        string redFruits[] = {"manzana","cereza","ciruela"};

        bool existe = Array.Exists(redFruits, fruta => fruta == fruit);

    }

    // Simplificar esta función
    // switch? Object literal? validar posibles colores
    static string[] GetFruitsByColor(string color)
    {
        /*      
            switch (color)
            {
                case "red":
                    return new string[] { "manzana", "fresa" };
                    break;
                case "yellow":
                    return new string[] { "piña", "banana" };
                    break;
                case "purple":
                    return new string[] { "moras", "uvas" };
                    break;
                default:
                    throw new Exception("The color must be: red, yellow, purple");
                    break;
            } 
        */
        var fruitsColors = new Dictionary<string, string[]> 
        {
            {"red", new string[] {"manzana","fresa"}},
            {"yellow", new string[] {"piña","banana"}};
            {"purple", new string[] {"moras","uvas"}}
        };

        if (fruitsColors.TryGetValue(color, out string[] fruits))
        {
            return fruits;
        }

        throw new Exception("The color must be: red, yellow, purple");
    }

        // Simplificar esta función
    static bool IsFirstStepWorking = true;
    static bool IsSecondStepWorking = true;
    static bool IsThirdStepWorking = true;
    static bool IsFourthStepWorking = true;

      static string WorkingSteps()
    {
        if (!IsFirstStepWorking == true) {return "First step broken."};

        if (!IsSecondStepWorking == true) {return "Second step broken."};

        if (!IsThirdStepWorking == true) {return "Third step broken."};

        if (!IsFourthStepWorking == true) {return "Four step broken."};

        return "Working properly!";
    }
    static void Main()
    {
        // isRedFruit
        Console.WriteLine($"{{ isRedFruit: {IsRedFruit("cereza")}, fruit: 'cereza' }}"); // true
        Console.WriteLine($"{{ isRedFruit: {IsRedFruit("piña")}, fruit: 'piña' }}"); // false

        // getFruitsByColor
        Console.WriteLine($"{{ redFruits: {string.Join(", ", GetFruitsByColor("red"))} }}"); // ['manzana', 'fresa']
        Console.WriteLine($"{{ yellowFruits: {string.Join(", ", GetFruitsByColor("yellow"))} }}"); // ['piña', 'banana']
        Console.WriteLine($"{{ purpleFruits: {string.Join(", ", GetFruitsByColor("purple"))} }}"); // ['moras', 'uvas']
        // Console.WriteLine($"{{ pinkFruits: {string.Join(", ", GetFruitsByColor("pink"))} }}"); // Error: the color must be: red, yellow, purple

        // workingSteps
        Console.WriteLine($"{{ workingSteps: {WorkingSteps()} }}");
    }
}