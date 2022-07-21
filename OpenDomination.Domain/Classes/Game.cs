namespace OpenDomination.Domain.Classes;

public class Game
{
    /// <summary>
    /// Public name of the game
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// List of players in the current game.
    /// </summary>
    public List<Player> Players { get; set; }
    /// <summary>
    /// Map this game is playing
    /// </summary>
    public Map Map { get; set; }
    /// <summary>
    /// Indicated who is at turn.
    /// </summary>
    public Player PlayersTurn { get; set; }
}