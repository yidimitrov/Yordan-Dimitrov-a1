namespace Zoo.Models
{
    public abstract class Animal
    {
        public Animal(byte initialHealtPoints, byte borderlineHealthStatusPoints)
        {
            if (initialHealtPoints < borderlineHealthStatusPoints)
            {
                throw new ArgumentException("Tried to create dead animal");
            }

            if (borderlineHealthStatusPoints < 1)
            {
                throw new ArgumentException("Borderline Health Status Points cannot be 0");
            }

            HealthPoints = Math.Min(initialHealtPoints, _HealthMax);

            BorderlineHealthStatusPoints = borderlineHealthStatusPoints;
        }

        protected readonly byte _HealthMax = 100;

        public virtual byte HealthPoints
        {
            get { return _HealthPoints; }
            set { _HealthPoints = Math.Min(value, _HealthMax); }
        }

        protected byte _HealthPoints;

        public byte BorderlineHealthStatusPoints { get; private set; }

        public bool IsDead { get { return IsDeadCondition(); } }

        public abstract Func<bool> IsDeadCondition { get; }
    }
}
