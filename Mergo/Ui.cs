public class Ui
{
    public float ScoreMultiplier = 40000f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}