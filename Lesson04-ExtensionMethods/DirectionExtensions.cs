namespace Lesson04;

public static class DirectionExtensions {
    public static bool IsHorizontal(this Direction direction) {
        return direction == Direction.Left || direction == Direction.Right;
    }

    public static bool IsVertical(this Direction direction) {
        return !IsHorizontal(direction);
    }

    public static Direction GetOpposite(this Direction direction) {
        return direction switch {
            Direction.Up => Direction.Down,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            Direction.Right => Direction.Left,
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }

    public static Direction RotateClockwise(this Direction direction) {
        return direction switch
        {
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }
}