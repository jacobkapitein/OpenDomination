using OpenDomination.Domain.Enums;

namespace OpenDomination.Domain.Classes;

public class Card
{
    /// <summary>
    /// Type of the card.
    /// </summary>
    public CardType CardType { get; set; }
    /// <summary>
    /// Number of armies this card provides.
    /// </summary>
    public uint NumberOfArmies { get; set; }
}