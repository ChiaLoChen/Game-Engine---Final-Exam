public class Right : Command
{
    private Player _player;

    public Right(Player player)
    {
        _player = player;
    }
    public override void Execute()
    {
        _player.MoveRight();
    }
}
