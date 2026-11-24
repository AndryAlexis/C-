namespace Lesson03;

public static class DirectionUtils {
    public static bool IsHorizontal(Direction direction) {
        return direction == Direction.Left || direction == Direction.Right;
    }

    public static bool IsVertical(Direction direction) {
        return !IsHorizontal(direction);
    }

    public static Direction GetOpposite(Direction direction) {
        return direction switch {
            Direction.Up => Direction.Down,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            Direction.Right => Direction.Left,
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }
}