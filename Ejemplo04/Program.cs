using Ejemplo04;

string sourceFolderPath = @"C:\SourceFolder";
string destinationFolderPath = @"C:\DestiantionFolder";

IRepository<string> fileRepository =
    new FileRepository(sourceFolderPath, destinationFolderPath);
var photoProcessor = new PhotoProcessor(fileRepository);

photoProcessor.CopyPhotosInParallel();

Console.WriteLine("Copia de fotos finalizada.");
Console.ReadLine();