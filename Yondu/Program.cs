
using Engine;

Scene startRoom = new Scene();

startRoom.addItem(new Item("Life Ender", GameAction.idle));

Game yondu = new Game(startRoom);

yondu.run();

/* -- Storyboard --
 * 
 * 

myScene(args);
nextScene(args);
otherScene(args);

myScene.linkNorth(nextScene)
myScene.linkWest(otherScene)

roomGen(startScene, null, nextScene, null, null)
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
