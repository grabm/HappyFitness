namespace HappyFitness.Domain.Common
{
    public class ExerciseDefinition : BaseEntity
    {
        /// <summary>
        /// Foreign key to the BodyPart entity
        /// </summary>
        public Guid BodyPartId { get; set; }

        /// <summary>
        /// Navigation property to the related BodyPart.
        /// </summary>
        public BodyPart BodyPart { get; set; }

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
