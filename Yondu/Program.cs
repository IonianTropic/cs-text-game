﻿
using Engine;

Scene startRoom = new Scene();

startRoom.addItem(new Item("Life Ender", GameAction.idle));

Game yondu = new Game(startRoom);

yondu.run();

/* -- Storyboard --
 * 
 * 

myScene();
nextScene();
otherScene();

myScene.link(direct, nextScene)
myScene.link(Scene newScene, Cardinal direct)
myScene.linkNorth(nextScene)
myScene.linkWest(otherScene)
myScene.lock(Cardinal c)

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
