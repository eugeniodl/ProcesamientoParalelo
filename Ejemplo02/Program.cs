using Ejemplo02;
using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();

var repository = new StringRepository(10000, 10);
var processor = new StringProcessor(repository);
var filteredStrings = processor.FilterStrings();

foreach (var item in filteredStrings)
    Console.WriteLine(item);

sw.Stop();
Console.WriteLine($"Tiempo transcurrido: {sw.ElapsedMilliseconds} ms");