using VolumeReader;

internal class Program
{
  private static bool p_isCorrect;
  private static void Main(string[] args)
  {
    while (!p_isCorrect)
    {
      Console.Write($"Введите URL папки: ");

      string? path = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(path))
      {
        Console.WriteLine($"URL некорректный");
      }
      else if (!Directory.Exists(path))
      {
        Console.WriteLine($"Указанного каталога не существует!");
      }
      else
      {
        Console.WriteLine(Reader.GetDirVolume(path, 0));
        p_isCorrect = true;
      }
    }
  }
}