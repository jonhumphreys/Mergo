public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 1000f;
    public float JumpForce = 2000000f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}