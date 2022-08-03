
using Engine;

Scene startRoom = new Scene();

startRoom.sceneItems.Add("Life Ender", Item.Nail);

Console.WriteLine(startRoom.sceneItems.First().Key);


Game yondu = new Game(startRoom);

Console.ReadLine(); // Pause

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
