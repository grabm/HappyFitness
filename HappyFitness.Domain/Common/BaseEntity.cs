namespace HappyFitness.Domain.Common
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// The unique identifier for the entity
        /// </summary>
        public Guid Id { get; protected set; } = Guid.NewGuid();

        /// <summary>
        /// The date of row created
        /// </summary>
        public DateTime CreatedDateUtc { get; protected set; }
    }
}
