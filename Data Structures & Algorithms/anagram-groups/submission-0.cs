public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> grouped = new Dictionary<string ,List<string>>();
        List<List<string>> final = new List<List<string>>();

        foreach (string str in strs) {
            char[] array = str.ToCharArray();
            Array.Sort(array);
            string sortedArray = new string(array);
            if (grouped.ContainsKey(sortedArray)) {
                grouped[sortedArray].Add(str);
            }
            else {
                grouped.Add(sortedArray, new List<string>());
                grouped[sortedArray].Add(str);
            }
        }


        foreach (var group in grouped) {
            final.Add(group.Value);
        }

        return final;
    }
}