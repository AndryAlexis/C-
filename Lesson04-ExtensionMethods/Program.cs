using Lesson04;

foreach (Direction direction in Enum.GetValues<Direction>()) {
    Console.Write("Direction: " + direction);
    Console.Write(" Is Horizontal? " + direction.IsHorizontal());
    Console.Write(" Is Vertical? " + direction.IsVertical());
    Console.WriteLine(" Its Opposite is: " + direction.GetOpposite());
    Console.WriteLine(" Next Clock Wise Rotation: " + direction.RotateClockwise());
}

void SimulateCombat() {
    GameStats.EnemiesKilled += 3;
}

void ShowHud() {
    Console.WriteLine("Enemies Killed: " + GameStats.EnemiesKilled);
}

SimulateCombat();

ShowHud();