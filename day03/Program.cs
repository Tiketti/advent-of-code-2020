using System;

namespace day03
{
  class Program
  {
    static void Main(string[] args)
    {
      const char tree = '#';
      int treeCounter = 0;
      string line;
      (int x, int y) position = (0, 0);

      var reader = new System.IO.StreamReader("input.txt");
      while ((line = reader.ReadLine()) != null)
      {
        if (line[position.x] == tree)
        {
          treeCounter++;
        }

        position.x = position.x + 3;

        if (position.x >= line.Length)
        {
          // slope repeats aka return to left edge
          position.x = position.x - line.Length;
        }

        position.y++;
      }

      Console.WriteLine($"🌲 {treeCounter}");

      reader.Close();
    }
  }
}