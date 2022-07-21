namespace OpenDomination.Domain.Classes;

public class Country
{
    public string Name { get; set; }
    /// <summary>
    /// Continent this country is in
    /// </summary>
    public Continent Continent { get; set; }
    /// <summary>
    /// Neighbours this country has. Neighbours can be cross-continent
    /// </summary>
    public List<Country> Neighbours { get; set; }
    
    /// <summary>
    /// Owner of this country. In other words: the player who has invaded this country.
    /// </summary>
    public Player Owner { get; set; }
    /// <summary>
    /// The amount of armies a player has active on this country.
    /// </summary>
    public uint Armies { get; set; }
}