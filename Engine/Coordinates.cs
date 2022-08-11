namespace Engine;

#warning Create documentation

public static class Coordinates {
    private static Type type = typeof(Cardinal);     
    public static Cardinal reverse(this Cardinal direction) {
        switch (direction) {
            case Cardinal.North:
                return Cardinal.South;
            case Cardinal.South:
                return Cardinal.North;
            case Cardinal.East:
                return Cardinal.West;
            case Cardinal.West:
                return Cardinal.East;
            default:
                throw new InvalidDataException();
        }
    }
    public static Cardinal toCardinal(this string s) {
        switch (s.Trim().ToLower()) {
            case "north":
                return Cardinal.North;
            case "south":
                return Cardinal.South;
            case "east":
                return Cardinal.East;
            case "west":
                return Cardinal.West;
            default:
                throw new InvalidDataException();
        }
    }
}

public enum Cardinal {
    North,
    South,
    East,
    West,
}

public enum Relative {
    Left,
    Right,
    Forward,
    Backward,
}
