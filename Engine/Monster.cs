namespace Engine;

#warning Clean up comments
#warning Create documentation

public class Monster {
    private string _name;
    private int _health;
    private int _dmgMin;
    private int _dmgMax;
    public string Name {
        get {
            return _name;
        }
    }
    public int Health {
        get {
            return _health;
        }
    }
    public int[] DmgRange {
        get {
            int[] dmgArray = { _dmgMin, _dmgMax };
            return dmgArray;
        }
    }

    public Monster(string name, int health, int dmgMin, int dmgMax) {
        if (dmgMin > dmgMax) { 
            throw new InvalidDataException("Max damage must be greater than or equal to min damage.");
        }
        _name = name;
        _health = health;
        _dmgMin = dmgMin;
        _dmgMax = dmgMax;
        
    }
}

// Example Monster -- Your Mom's 'Friend' Ron
// ron = new Monster("Your Mom's 'Friend' Ron", 20, 2, 7)