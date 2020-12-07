using System;
using System.Linq;

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
        int lowerBound = int.Parse(s[0].Split('-')[0]);
        int upperBound = int.Parse(s[0].Split('-')[1]);
        char letter = s[1].TrimEnd(':')[0];
        string input = s[2];

        int frequency = input.Count(c => c == letter);

        if (frequency >= lowerBound && frequency <= upperBound)
        {
          hits++;
        }
      }

      Console.WriteLine($"Hits: {hits}");

      reader.Close();
    }
  }
}
