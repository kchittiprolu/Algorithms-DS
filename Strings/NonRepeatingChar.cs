using System.Collections.Generic;

public class NonRepeatingChar
{
        public char FirstNonRepeatingChar(string input)
        {
          var dict = new Dictionary<char,int>();
          for(int i=0;i<input.Length;i++)
          {
            if(dict.ContainsKey(input[i])){
              dict[input[i]]++;
            }
            else
               dict.Add(input[i],1);
          }
          foreach (var item in dict)
          {
              if(dict[item.Key] == 1)
              return item.Key;
          }
          return char.MinValue;
        }

        public char FirstRepeatedChar(string input)
        {
          var set = new HashSet<int>();
          foreach (char c in input)
          {
              if(set.Contains(c))
                 return c;
               set.Add(c);
          }
          return char.MinValue;
        }
}