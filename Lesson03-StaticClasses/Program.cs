using Lesson03;

foreach (Direction direction in Enum.GetValues<Direction>()) {
    Console.Write("Direction: " + direction);
    Console.Write(" Is Horizontal? " + DirectionUtils.IsHorizontal(direction));
    Console.Write(" Is Vertical? " + DirectionUtils.IsVertical(direction));
    Console.WriteLine(" Its Opposite is: " + DirectionUtils.GetOpposite(direction));
}

void SimulateCombat() {
    GameStats.EnemiesKilled += 3;
}

void ShowHud() {
    SimulateCombat();
    Console.WriteLine("Enemies Killed: " + GameStats.EnemiesKilled);
}

ShowHud();

// new DirectionUtils();