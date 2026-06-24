
public class RomanToInt {
    public int RomanToInt(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = map[s[i]];

            if (i < s.Length - 1 && current < map[s[i + 1]])
            {
                total -= current;
            }
            else
            {
                total += current;
            }
        }

        return total;
    }
}

