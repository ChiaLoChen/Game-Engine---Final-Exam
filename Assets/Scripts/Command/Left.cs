public class Left : Command
{
    private Player _player;

    public Left(Player player)
    {
        _player = player;
    }
    public override void Execute()
    {
        _player.MoveLeft();
    }
}
