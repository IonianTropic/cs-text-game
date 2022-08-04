﻿namespace Engine;
/* cardinalString = "You enter a room with a door to the {}.\n"
    * if (doors.length == 1) {
    format(cardinalString, doors[0]);
    } else {
    commaDoors = "";
    doorString = "{commaDoors} and {doors[doors.length-1]}"
    }
    
    if (sceneItems.length > 0) {
    itemString = "The room contains a {}.\n"
    if (sceneItems.length == 1) {
        format(itemString, sceneItems[0]);
    } else {
        commaItems = "";
        format(itemString, commaItems, sceneItems[sceneItems.length-1].name)
        //itemString = "{commaItems} and {sceneItems[sceneItems.length-1].name}"
    }
    }
*/
public class Scene {
    public Scene? north;
    public Scene? east;
    public Scene? south;
    public Scene? west;
    public Dictionary<string, Item> sceneItems;
    public Scene() {
        north = null;
        south = null;
        east = null;
        west = null;
        sceneItems = new Dictionary<string, Item>(10);
    }
    public List<string> cardinalStrings() {
        List<string> cardinalList = new List<string>();
        if (north != null) cardinalList.Add("north");
        if (south != null) cardinalList.Add("south");
        if (east != null) cardinalList.Add("east");
        if (west != null) cardinalList.Add("west");
        return cardinalList;
    }
    public string formatList(ICollection<string> c) {
        if (c.Count == 0) return string.Empty;
        if (c.Count == 1) return c.First();
        string formattedList = string.Format("{0} and {1}", c.ElementAt(c.Count-2), c.Last()); 
        foreach (string item in c.Take(c.Count-2)) {
            formattedList = string.Format("{0}, {1}", item, formattedList);
        }
        return formattedList;
    }
    /* Example Scene Description
        * 
        * You enter a room with a door to the [north, east, south and west].
        * The room contains a [key, dagger and blue potion].
        * A [snake] blocks your path.
        * Doors: N, E, S, W
        * Items: key, dagger, blue potion
        * Enemies: Snake
    */
    /// <summary>
    /// Replace me with LexTools
    /// </summary>
    public string sceneDescription {
        get {
            string thisDescription = "Doors: {0}\nItems: {1}";
            string doorString = "";
            if (north != null) {
                doorString = doorString + "N, ";
            }
            if (east != null) {
                doorString = doorString + "E, ";
            }
            if (south != null) {
                doorString = doorString + "S, ";
            }
            if (west != null) {
                doorString = doorString + "W, ";
            }
            string itemString = "";
            foreach (KeyValuePair<string, Item> item in sceneItems) {
                itemString = itemString + item.Key + ", ";
            }
            String.Format(thisDescription, doorString, itemString);
            return thisDescription;
        }
    }
}
