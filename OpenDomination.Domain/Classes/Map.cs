namespace OpenDomination.Domain.Classes;

/// <summary>
/// A map has a list of Continents. Those continents can contain countries. Players can create their own maps
/// </summary>
public class Map
{
    public string Name { get; set; }
    /// <summary>
    /// Active continents on this map.
    /// </summary>
    public List<Continent> Continents { get; set; }
}