//2 strings- ransomNote , magazine
// return true if ransomNote can be constucted by using letters from magazine or return false
// ea can only be used once in ransomNote


class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

       
        foreach (char c in magazine)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

      
        foreach (char c in ransomNote)
        {
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
                return false;

            charCount[c]--;
        }

        return true;
    }

   public static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.CanConstruct("a", "b"));      
        Console.WriteLine(solution.CanConstruct("aa", "ab"));    
        Console.WriteLine(solution.CanConstruct("aa", "aab"));   
    }
}
    
