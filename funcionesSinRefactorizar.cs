using System;
using System.Collections.Generic;

class Program
{
    // Resolver sin la triple condicional dentro del if
    // includes? arrays?
    static bool IsRedFruit(string fruit)
    {
        if (fruit == "manzana" || fruit == "cereza" || fruit == "ciruela")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Simplificar esta función
    // switch? Object literal? validar posibles colores
    static string[] GetFruitsByColor(string color)
    {
        if (color == "red")
        {
            return new string[] { "manzana", "fresa" };
        }
        else if (color == "yellow")
        {
            return new string[] { "piña", "banana" };
        }
        else if (color == "purple")
        {
            return new string[] { "moras", "uvas" };
        }
        else
        {
            throw new Exception("The color must be: red, yellow, purple");
        }
    }

    // Simplificar esta función
    static bool IsFirstStepWorking = true;
    static bool IsSecondStepWorking = true;
    static bool IsThirdStepWorking = true;
    static bool IsFourthStepWorking = true;

    static string WorkingSteps()
    {
        if (IsFirstStepWorking == true)
        {
            if (IsSecondStepWorking == true)
            {
                if (IsThirdStepWorking == true)
                {
                    if (IsFourthStepWorking == true)
                    {
                        return "Working properly!";
                    }
                    else
                    {
                        return "Fourth step broken.";
                    }
                }
                else
                {
                    return "Third step broken.";
                }
            }
            else
            {
                return "Second step broken.";
            }
        }
        else
        {
            return "First step broken.";
        }
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
