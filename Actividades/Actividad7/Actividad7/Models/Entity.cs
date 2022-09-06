namespace Actividad7.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        /// <summary>
        /// for
        /// </summary>
        protected Entity()
        {

        }

        protected Entity(Guid id)
        {
            Id = id;
        }

    }
}
