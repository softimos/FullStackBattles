namespace Softimos.FullStackBattles.DTO
{
    /// <summary>
    /// Representation of person entity.
    /// </summary>
    /// <seealso cref="Softimos.FullStackBattles.DTO.IInt32Identity" />
    public class Person : IInt32Identity
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
        /// Gets or sets the mass.
        /// </summary>
        /// <value>
        /// The mass.
        /// </value>
        public decimal Mass { get; set; }
    }
}
