Console.WriteLine($"\n\nЗадача 52.");

int[,] arrayWhole = new int[0, 0];

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < 0; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < 0; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / 0, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)

{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < 0; i++)
  {
      for (int j = 0; j < 0; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}