using System;

namespace day02
{
  class Program
  {
    static void Main(string[] args)
    {
      string line;
      int hits = 0;

      var reader = new System.IO.StreamReader("input.txt");
      while ((line = reader.ReadLine()) != null)
      {
        string[] s = line.Split(' ');
        int pos1 = int.Parse(s[0].Split('-')[0]);
        int pos2 = int.Parse(s[0].Split('-')[1]);
        char letter = s[1].TrimEnd(':')[0];
        string input = s[2];

        // the no-zero-based-index; hence, position 1 in file refers to index 0
        pos1--;
        pos2--;

        if (input[pos1] == letter ^ input[pos2] == letter)
        {
          hits++;
        }

      }

      Console.WriteLine($"Hits: {hits}");

      reader.Close();
    }
  }
}
