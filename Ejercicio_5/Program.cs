// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// --------------------------------------------------------------------

// Muestra el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_5");

// Muestra el planteamiento del problema.
Console.WriteLine("Diseñe un programa que permita analizar la");
Console.WriteLine("vibración de varios motores.");

Console.WriteLine();

// --------------------------------------------------------------------
// VARIABLES
// --------------------------------------------------------------------

// Variable que controla si el usuario desea continuar.
string continuar = "s";

// Contador del total de motores evaluados.
int totalMotores = 0;

// Contador de motores con funcionamiento normal.
int motoresNormales = 0;

// Contador de motores que requieren mantenimiento.
int motoresMantenimiento = 0;

// --------------------------------------------------------------------
// OPERACIONES
// --------------------------------------------------------------------

// Repite el análisis mientras el usuario responda "s".
while (continuar == "s")
{
    // Variable que almacena el nombre o identificador del motor.
    string nombreMotor;

    // Variable que almacena cada medición de vibración.
    double vibracion;

    // Variable que acumula las cuatro mediciones.
    double suma = 0;

    // Variable que almacena el promedio de vibración.
    double promedio;

    // ---------------------------------------------------------------
    // ENTRADA DEL NOMBRE DEL MOTOR
    // ---------------------------------------------------------------

    // Solicita el nombre o identificador del motor.
    Console.Write("Ingrese el nombre o identificador del motor: ");

    // Lee el nombre del motor.
    nombreMotor = Console.ReadLine();

    // ---------------------------------------------------------------
    // ENTRADA DE LAS CUATRO MEDICIONES
    // ---------------------------------------------------------------

    // Repite el proceso para obtener cuatro mediciones.
    for (int contador = 1; contador <= 4; contador++)
    {
        // Solicita al usuario una medición de vibración.
        Console.Write($"Ingrese la vibración {contador}: ");

        // Lee y convierte la medición a tipo double.
        vibracion = Convert.ToDouble(Console.ReadLine());

        // Acumula la medición para calcular el promedio.
        suma = suma + vibracion;
    }

    // ---------------------------------------------------------------
    // OPERACIONES
    // ---------------------------------------------------------------

    // Calcula el promedio de las cuatro mediciones.
    promedio = suma / 4;

    // ---------------------------------------------------------------
    // SALIDAS DE DATOS
    // ---------------------------------------------------------------

    // Deja un espacio antes de mostrar los resultados.
    Console.WriteLine();

    // Muestra el nombre del motor analizado.
    Console.WriteLine($"Motor: {nombreMotor}");

    // Muestra el promedio de vibración con dos decimales.
    Console.WriteLine($"La vibración promedio es: {promedio:F2} mm/s");

    // Verifica si el promedio está dentro del rango normal.
    if (promedio <= 4.5)
    {
        // Indica que el motor funciona normalmente.
        Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR");

        // Incrementa el contador de motores normales.
        motoresNormales = motoresNormales + 1;
    }
    else
    {
        // Indica que el motor requiere mantenimiento.
        Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO");

        // Incrementa el contador de motores que requieren mantenimiento.
        motoresMantenimiento = motoresMantenimiento + 1;
    }

    // Incrementa el contador total de motores evaluados.
    totalMotores = totalMotores + 1;

    // ---------------------------------------------------------------
    // PREGUNTAR SI SE DESEA CONTINUAR
    // ---------------------------------------------------------------

    // Deja un espacio antes de realizar la pregunta.
    Console.WriteLine();

    // Pregunta al usuario si desea analizar otro motor.
    Console.Write("¿Desea analizar otro motor? (s/n): ");

    // Lee la respuesta y la convierte a minúsculas.
    continuar = Console.ReadLine().ToLower();

    Console.WriteLine();
}

// --------------------------------------------------------------------
// RESULTADOS FINALES
// --------------------------------------------------------------------

// Muestra el encabezado de los resultados finales.
Console.WriteLine("RESULTADOS FINALES");

// Muestra el total de motores evaluados.
Console.WriteLine($"Total de motores evaluados: {totalMotores}");

// Muestra la cantidad de motores normales.
Console.WriteLine($"Cantidad de motores normales: {motoresNormales}");

// Muestra la cantidad de motores que requieren mantenimiento.
Console.WriteLine(
    $"Cantidad de motores que requieren mantenimiento: {motoresMantenimiento}");