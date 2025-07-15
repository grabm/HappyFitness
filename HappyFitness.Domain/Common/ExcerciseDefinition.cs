namespace HappyFitness.Domain.Common
{
    public class ExcerciseDefinition : BaseEntity
    {
        /// <summary>
        /// Foreign key to the BodyPart entity
        /// </summary>
        public Guid BodyPartId { get; set; }

        /// <summary>
        /// The full name of the exercise, e.g., "Barbell Bench Press".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the exercise
        /// </summary>
        public string Description { get; set; }
    }
}
