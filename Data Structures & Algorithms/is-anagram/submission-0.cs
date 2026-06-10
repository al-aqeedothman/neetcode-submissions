public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> anagram = new Dictionary<char, int>();
        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++) {
            anagram[s[i]] = anagram.GetValueOrDefault(s[i]) + 1;
            anagram[t[i]] = anagram.GetValueOrDefault(t[i]) - 1;
        }

        foreach (int count in anagram.Values) {
            if (count != 0) return false;
        }
        return true;
    }
}
