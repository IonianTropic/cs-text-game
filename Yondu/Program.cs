
using Engine;
using Engine.Collections;

YLinkedList<int> myList = new YLinkedList<int>(0);
myList.insert(3);
myList.insert(2);
myList.insert(1);

Scene myScene = new Scene();

string myString = new String("Run");

Item lifeEnder = new Item("Life Ender");
myScene.sceneItems.Add(lifeEnder);
Console.WriteLine(lifeEnder.itemName);

CosmicRayDetector rayDetector = new CosmicRayDetector();
rayDetector.detectCosmicRays();

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
