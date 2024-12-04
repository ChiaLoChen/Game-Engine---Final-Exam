public class Shoot : Command
{
    private Player _player;

    public Shoot(Player player)
    {
        _player = player;
    }
    public override void Execute()
    {
        _player.Shoot();
    }
}
