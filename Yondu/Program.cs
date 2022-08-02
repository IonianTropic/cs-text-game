
using Engine;
using Engine.Collections;

List<int> myList = new List<int>(){1, 2, 3, 4};
myList.Insert(0, 0);

Scene myScene = new Scene();

myScene.sceneItems.Add("Life Ender", Item.Nail);
Console.WriteLine(myScene.sceneItems.First().Key);

Console.ReadLine();

/* -- Storyboard --
 * 
 * 
*/

/* -- Data Types and Structures --

    Inputs:
        north/south/east/west
        talk
        interact
        attack
        inventory
        use itemName
        get itemName
        help

    Items:
        Map
        Key
        Life Ender

    Scene:
        North, East, South, West
        Items
        Enemies
        NPCs
*/


/*
Relative cardinalToRelative(Relative r) {
    return Relative;
}*/
