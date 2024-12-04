public class Up : Command
{
    private Player _player;

    public Up(Player player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveUp();
    }
}
