namespace HappyFitness.Domain.Common
{
    public class BodyPart : BaseEntity
    {
        /// <summary>
        /// The name of the body part, e.g., "Chest", "Back", "Legs".
        /// </summary>
        public string Name { get; set; }
    }
}
