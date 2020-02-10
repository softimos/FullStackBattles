namespace Softimos.FullStackBattles.DTO
{
    /// <summary>
    /// Interface for database entities having Id column as integer.
    /// Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/
    /// </summary>
    public interface IInt32Identity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier of the element.
        /// </value>
        int Id { get; set; }
    }
}
