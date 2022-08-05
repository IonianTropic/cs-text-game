namespace Engine;

public class Scribe {
    public static string formatList(ICollection<string> c) {
        if (c.Count == 0) return string.Empty;
        if (c.Count == 1) return c.First();
        string formattedList = string.Format("{0} and {1}", c.ElementAt(c.Count-2), c.Last());
        foreach (string item in c.Take(c.Count-2).Reverse()) {
            formattedList = string.Format("{0}, {1}", item, formattedList);
        }
        return formattedList;
    }
}
