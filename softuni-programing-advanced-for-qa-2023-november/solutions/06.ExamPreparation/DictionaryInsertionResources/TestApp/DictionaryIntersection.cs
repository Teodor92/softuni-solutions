using System.Collections.Generic;

namespace TestApp;

public class DictionaryIntersection
{
    public static Dictionary<string, int> Intersect(
        IDictionary<string, int> dict1, 
        IDictionary<string, int> dict2)
    {
        Dictionary<string, int> intersection = new();

        foreach (KeyValuePair<string, int> kvp in dict1)
        {
            if (dict2.ContainsKey(kvp.Key) && dict2[kvp.Key] == kvp.Value)
            {
                intersection[kvp.Key] = kvp.Value;
            }
        }

        return intersection;
    }
}
