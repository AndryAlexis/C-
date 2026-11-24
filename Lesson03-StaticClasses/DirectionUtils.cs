public static class DirectionUtils {
    public static bool IsHorizontal(Direction direction) {
        if (direction == Direction.Left || direction == Direction.Right) {
            return true;
        }
        return false;
    }

    public static bool IsVertical(Direction direction) {
        if (direction == Direction.Up || direction == Direction.Down) {
            return true;
        }
        return false;
    }

    public static Direction GetOpposite(Direction direction) {
        switch (direction) {
            case Direction.Up:
                return Direction.Down;
            case Direction.Down:
                return Direction.Up;
            case Direction.Left:
                return Direction.Right;
            default:
                return Direction.Left;
        }
    }
}