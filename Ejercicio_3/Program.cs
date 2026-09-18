// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// --------------------------------------------------------------------

// Muestra el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_3");

// Muestra el planteamiento del problema.
Console.WriteLine("Diseñe un programa que simule la carga de una");
Console.WriteLine("batería de 12.6 V mediante un ciclo while.");

Console.WriteLine();

// --------------------------------------------------------------------
// ENTRADAS DE DATOS
// --------------------------------------------------------------------

// Solicita al usuario el voltaje inicial de la batería.
Console.Write("Ingrese el voltaje inicial de la batería: ");
double voltajeInicial = Convert.ToDouble(Console.ReadLine());

// Solicita al usuario el incremento de voltaje por cada ciclo.
Console.Write("Ingrese el incremento de voltaje por ciclo: ");
double incremento = Convert.ToDouble(Console.ReadLine());

// --------------------------------------------------------------------
// VARIABLES
// --------------------------------------------------------------------

// Inicializa el voltaje actual con el voltaje inicial ingresado.
double voltaje = voltajeInicial;

// Inicializa el contador de ciclos en cero.
int ciclo = 0;

// --------------------------------------------------------------------
// OPERACIONES
// --------------------------------------------------------------------

// Verifica que el incremento sea mayor que cero.
if (incremento <= 0)
{
    // Muestra un mensaje de error si el incremento no es válido.
    Console.WriteLine();
    Console.WriteLine("ERROR: El incremento debe ser mayor que cero.");
}
else
{
    // Repite el proceso mientras el voltaje sea menor que 12.6 V.
    while (voltaje < 12.6)
    {
        // Aumenta el voltaje según el incremento indicado.
        voltaje = voltaje + incremento;

        // Incrementa el número de ciclos realizados.
        ciclo = ciclo + 1;

        // Evita que el voltaje supere los 12.6 V.
        if (voltaje > 12.6)
        {
            voltaje = 12.6;
        }

        // Muestra el voltaje alcanzado en cada ciclo.
        Console.WriteLine();
        Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {voltaje:F2} V");
    }

    // Muestra el mensaje cuando la batería alcanza el voltaje máximo.
    Console.WriteLine();
    Console.WriteLine("La batería ha alcanzado los 12.6 V.");
}