// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// --------------------------------------------------------------------

// Muestra el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_4");

// Muestra el planteamiento del problema.
Console.WriteLine("Durante una prueba se realizan ocho mediciones");
Console.WriteLine("de corriente de un actuador eléctrico.");

Console.WriteLine();

// --------------------------------------------------------------------
// VARIABLES
// --------------------------------------------------------------------

// Variable que almacena cada medición de corriente.
double corriente;

// Variable que acumula la suma de todas las corrientes.
double suma = 0;

// Variable que almacena el promedio de corriente.
double promedio;

// Contador de mediciones que se encuentran dentro del rango normal.
int medicionesNormales = 0;

// Contador de mediciones que presentan sobrecorriente.
int sobrecorrientes = 0;

// --------------------------------------------------------------------
// ENTRADAS DE DATOS Y OPERACIONES
// --------------------------------------------------------------------

// Repite el proceso para realizar ocho mediciones.
for (int contador = 1; contador <= 8; contador++)
{
    // Solicita al usuario la corriente de cada medición.
    Console.Write($"Ingrese la corriente {contador}: ");

    // Lee y convierte la corriente ingresada a tipo double.
    corriente = Convert.ToDouble(Console.ReadLine());

    // Acumula la corriente para calcular posteriormente el promedio.
    suma = suma + corriente;

    // Verifica si la corriente se encuentra dentro del rango normal.
    if (corriente <= 5)
    {
        // Indica que la medición está dentro del límite permitido.
        Console.WriteLine("MEDICIÓN NORMAL");

        // Incrementa el contador de mediciones normales.
        medicionesNormales = medicionesNormales + 1;
    }
    else
    {
        // Indica que se detectó una corriente superior a 5 A.
        Console.WriteLine("SOBRECORRIENTE DETECTADA");

        // Incrementa el contador de sobrecorrientes.
        sobrecorrientes = sobrecorrientes + 1;
    }

    Console.WriteLine();
}

// --------------------------------------------------------------------
// OPERACIONES
// --------------------------------------------------------------------

// Calcula la corriente promedio de las ocho mediciones.
promedio = suma / 8;

// --------------------------------------------------------------------
// SALIDAS DE DATOS
// --------------------------------------------------------------------

// Muestra los resultados finales de la prueba.
Console.WriteLine("RESULTADOS FINALES");

// Muestra la corriente promedio con dos decimales.
Console.WriteLine($"Corriente promedio: {promedio:F2} A");

// Muestra la cantidad de mediciones normales.
Console.WriteLine($"Cantidad de mediciones normales: {medicionesNormales}");

// Muestra la cantidad de sobrecorrientes detectadas.
Console.WriteLine($"Cantidad de sobrecorrientes: {sobrecorrientes}");

Console.WriteLine();

// --------------------------------------------------------------------
// EVALUACIÓN FINAL
// --------------------------------------------------------------------

// Verifica si no se presentó ninguna sobrecorriente.
if (sobrecorrientes == 0)
{
    // Si no hubo sobrecorrientes, el actuador es aprobado.
    Console.WriteLine("ACTUADOR APROBADO");
}
else
{
    // Si hubo una o más sobrecorrientes, se requiere una revisión.
    Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN");
}