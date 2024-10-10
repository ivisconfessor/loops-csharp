Console.WriteLine("::: Loops em C#! :::");
Console.WriteLine();

ForLoop();

Console.WriteLine();

WhileLoop();

Console.WriteLine();

DoWhileLoop();

Console.WriteLine();

ForeachLoop();


// For
static void ForLoop()
{
    int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] > 5)
        {
            Console.WriteLine($"For: {numeros[i]} é maior que 5.");
        }
    }
}

// While Loop
static void WhileLoop()
{
    int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };
    int index = 0;

    while (index < numeros.Length)
    {
        if (numeros[index] > 5)
        {
            Console.WriteLine($"While: {numeros[index]} é maior que 5.");
        }
        index++;
    }
}

// Do While
static void DoWhileLoop()
{
    int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };
    int index = 0;

    do
    {
        if (numeros[index] > 5)
        {
            Console.WriteLine($"Do-While: {numeros[index]} é maior que 5.");
        }
        index++;
    } while (index < numeros.Length);
}

// Foreach
static void ForeachLoop()
{
    int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };

    foreach (int numero in numeros)
    {
        if (numero > 5)
        {
            Console.WriteLine($"Foreach: {numero} é maior que 5.");
        }
    }
}
