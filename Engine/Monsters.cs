namespace Engine;

/*
    Combat:
        PlayerCmds
        Monsters
*/

public class Monster { // Monster.health;
    public string Name { get; }
    public int Health { get; }
    public Monster(string name, int health) {
        Name = name;
        Health = health;
    }
    public int health;
}
