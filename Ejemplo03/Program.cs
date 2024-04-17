using Ejemplo03;

string sourceFolderPath = @"C:\SourceFolder";
string destinationFolderPath = @"C:\DestinationFolder";

var fileRepository = new FileRepository(sourceFolderPath, destinationFolderPath);
var photoProcessor = new PhotoProcessor(fileRepository);

photoProcessor.CopyPhotosInParallel();

Console.WriteLine("Copia de fotos finalizada");
Console.ReadLine(); // Para mantener la consola abierta
