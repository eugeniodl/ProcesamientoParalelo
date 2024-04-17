using Ejemplo03;

string[] names = { "Roma", "Sherly", "Jesús", "Estrella", "Axel",
"Guadalupe", "Antonio", "José", "Félix", "Reynaldo"};

var repository = new StringRepository(names);
var processor = new StringProcessor(repository);

try
{
	// Filtrado secuencial
	var sequentialResult = processor.FilterStringsStartingWith('E');
	Console.WriteLine("\nResultado del filtrado secuencial:");
	PrintNames(sequentialResult);

	// Filtrado paralelo
	var parallelResult = processor.FilterStringsStartingWith('E').AsParallel();
	Console.WriteLine("\nResultado del filtrado en paralelo:");
	PrintNames(parallelResult);
}
catch (Exception ex)
{
    Console.WriteLine("\nSe produjo una excepción:");
    Console.WriteLine(ex.Message);
}

void PrintNames(IEnumerable<string> filter)
{
    Console.WriteLine("----------------------");
	foreach (var item in filter)
	{
        Console.WriteLine(item);
    }
}