using System.Diagnostics;

var numeros = Enumerable.Range(0, 10000);
var sw = new Stopwatch();
sw.Start();

var numerosPares = from num in numeros.AsParallel().AsOrdered()
                       where num % 2 == 0
                       select num;

sw.Stop();
Console.WriteLine("{0} números pares de {1} total, tiempo {2}",
    numerosPares.Count(), numeros.Count(), sw.ElapsedMilliseconds );