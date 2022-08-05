namespace Engine;

public static class Coordinates {
    public static Cardinal cardinalReverse(Cardinal direction) {
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
