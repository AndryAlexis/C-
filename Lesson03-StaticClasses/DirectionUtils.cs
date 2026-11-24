namespace Lesson03;

public static class DirectionUtils {
    public static bool IsHorizontal(Direction direction) {
        return direction == Direction.Left || direction == Direction.Right;
    }

    public static bool IsVertical(Direction direction) {
        bool isVertical = !IsHorizontal(direction);
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
            case Direction.Right:
                return Direction.Left;
        }

        return direction switch {
            Direction.Up => Direction.Down,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            Direction.Right => Direction.Left,
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }
}