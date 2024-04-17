using System.Diagnostics;

var numeros = Enumerable.Range(1, 10000);
var sw = new Stopwatch();
sw.Start();

var numerosPares = from num in numeros.AsParallel()
                   where num % 2 == 0
                   select num;

foreach (var num in numerosPares)
    Console.WriteLine(num);

sw.Stop();
Console.WriteLine("{0} números pares de {1} números. Tiempo {2}",
    numerosPares.Count(), numeros.Count(), sw.ElapsedMilliseconds);