public class Ui
{
    public float ScoreMultiplier = 3f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}