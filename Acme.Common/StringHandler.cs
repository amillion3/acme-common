using System;

namespace Acme.Common
{
  // StringHandler will take in a string such as "JohnnyBoy" and
  //  split the string on each capital letter.
  public static class StringHandler
  {
    public static string InsertSpaces(string source)
    {
      string result = string.Empty;

      if (!String.IsNullOrWhiteSpace(source))
      {
        foreach (char letter in source)
        {
          if (char.IsUpper(letter))
          {
            result = result.Trim();
            result += " ";
          }
          result += letter;
        }
      }
      else
      {
        return null;
      }
      result = result.Trim();
      return result;
    }

  }
}
