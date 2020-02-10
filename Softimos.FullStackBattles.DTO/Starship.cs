namespace Softimos.FullStackBattles.DTO
{
    /// <summary>
    /// Representation of starship entity.
    /// </summary>
    /// <seealso cref="Softimos.FullStackBattles.DTO.IInt32Identity" />
    public class Starship : IInt32Identity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier of the element.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the crew count.
        /// </summary>
        /// <value>
        /// The crew count.
        /// </value>
        public int CrewCount { get; set; }
    }
}
