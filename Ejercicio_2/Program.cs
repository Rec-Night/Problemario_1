// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// --------------------------------------------------------------------

// Muestra el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_2");

// Muestra el planteamiento del problema.
Console.WriteLine("Diseñe un programa que solicite diez mediciones");
Console.WriteLine("de temperatura, las sume y calcule el promedio.");

Console.WriteLine();

// --------------------------------------------------------------------
// VARIABLES
// --------------------------------------------------------------------

// Variable que almacena la suma de las temperaturas.
double suma = 0;

// Variable que almacena cada temperatura ingresada.
double temperatura;

// Variable que almacena el promedio de las temperaturas.
double promedio;

// --------------------------------------------------------------------
// ENTRADAS DE DATOS
// --------------------------------------------------------------------

// Repite el proceso de entrada 10 veces.
for (int contador = 1; contador <= 10; contador++)
{
    // Solicita al usuario una temperatura.
    Console.Write($"Ingrese la temperatura {contador}: ");

    // Lee y convierte la temperatura ingresada a tipo double.
    temperatura = Convert.ToDouble(Console.ReadLine());

    // Acumula la temperatura en la variable suma.
    suma = suma + temperatura;
}

// --------------------------------------------------------------------
// OPERACIONES
// --------------------------------------------------------------------

// Calcula el promedio dividiendo la suma entre 10.
promedio = suma / 10;

// --------------------------------------------------------------------
// SALIDAS DE DATOS
// --------------------------------------------------------------------

// Muestra el promedio de las temperaturas con dos decimales.
Console.WriteLine();
Console.WriteLine($"La temperatura promedio es: {promedio:F2} °C");

// --------------------------------------------------------------------
// EVALUACIÓN DE LA TEMPERATURA
// --------------------------------------------------------------------

// Verifica si el promedio es menor o igual a 70 °C.
if (promedio <= 70)
{
    // Si cumple la condición, indica que la temperatura es normal.
    Console.WriteLine("TEMPERATURA NORMAL");
}
else
{
    // Si supera los 70 °C, muestra una alerta.
    Console.WriteLine("ALERTA DE TEMPERATURA");
}