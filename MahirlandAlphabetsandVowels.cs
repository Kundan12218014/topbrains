using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MahirlAssignment
{
  public static void Main()
  {
    string word1 = Console.ReadLine();
    string word2 = Console.ReadLine();

    if (string.IsNullOrEmpty(word1)) return;
    HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    
    HashSet<char> consonantsInWord2 = new HashSet<char>(
        word2.ToLower().Where(c => char.IsLetter(c) && !vowels.Contains(c))
    );

    StringBuilder step1 = new StringBuilder();
    foreach (char c in word1)
    {
      char lowerC = char.ToLower(c);
      bool isConsonant = char.IsLetter(lowerC) && !vowels.Contains(lowerC);

      if (!(isConsonant && consonantsInWord2.Contains(lowerC)))
      {
        step1.Append(c);
      }
    }
    if (step1.Length == 0) return;

    StringBuilder result = new StringBuilder();
    result.Append(step1[0]);

    for (int i = 1; i < step1.Length; i++)
    {
      
      if (char.ToLower(step1[i]) != char.ToLower(step1[i - 1]))
      {
        result.Append(step1[i]);
      }
    }

    Console.WriteLine(result.ToString());
  }
}
