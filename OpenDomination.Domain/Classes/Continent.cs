namespace OpenDomination.Domain.Classes;

public class Continent
{
    public string Name { get; set; }
    
    /// <summary>
    /// Conqueror of the continent. This is only set when a continent has been fully conquered by a player.
    /// </summary>
    public Player? Conqueror { get; set; }
    /// <summary>
    /// When a continent is conquered, a player gets bonus armies
    /// </summary>
    public int BonusArmies { get; set; }
}