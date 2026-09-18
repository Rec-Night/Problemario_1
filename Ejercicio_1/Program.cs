// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// --------------------------------------------------------------------

// Muestra el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_1");

// Muestra el planteamiento del problema.
Console.WriteLine("Diseñe un programa que solicite el voltaje y la");
Console.WriteLine("corriente consumida por un motor de corriente directa");
Console.WriteLine("y calcule la potencia eléctrica.");

Console.WriteLine();

// --------------------------------------------------------------------
// ENTRADAS DE DATOS
// --------------------------------------------------------------------

// Solicita al usuario el voltaje del motor.
Console.Write("Ingrese el voltaje del motor: ");
double voltaje = Convert.ToDouble(Console.ReadLine());

// Solicita al usuario la corriente consumida por el motor.
Console.Write("Ingrese la corriente consumida por el motor: ");
double corriente = Convert.ToDouble(Console.ReadLine());

// --------------------------------------------------------------------
// OPERACIONES
// --------------------------------------------------------------------

// Calcula la potencia eléctrica utilizando la fórmula:
// Potencia = Voltaje × Corriente
double potencia = voltaje * corriente;

// --------------------------------------------------------------------
// SALIDAS DE DATOS
// --------------------------------------------------------------------

// Muestra la potencia calculada con dos decimales.
Console.WriteLine();
Console.WriteLine($"La potencia eléctrica del motor es: {potencia:F2} W");

// --------------------------------------------------------------------
// EVALUACIÓN DEL CONSUMO
// --------------------------------------------------------------------

// Verifica si la potencia es menor o igual a 120 W.
if (potencia <= 120)
{
    // Si cumple la condición, muestra que el consumo es normal.
    Console.WriteLine("CONSUMO NORMAL");
}
else
{
    // Si supera los 120 W, muestra una advertencia.
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO");
}