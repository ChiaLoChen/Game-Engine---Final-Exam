public class Down : Command
{
    private Player _player;

    public Down(Player player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveDown();
    }
}
