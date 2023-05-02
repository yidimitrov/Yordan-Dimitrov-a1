namespace Zoo.Models
{
    public abstract class Animal
    {
        public Animal(byte initialHealtPoints, byte borderlineHealthStatusPoints)
        {
            HealthPoints = initialHealtPoints;
            BorderlineHealthStatusPoints = borderlineHealthStatusPoints;
        }

        public virtual byte HealthPoints
        {
            get { return _HealthPoints; }
            set { _HealthPoints = value; }
        }

        protected byte _HealthPoints;

        public byte BorderlineHealthStatusPoints { get; private set; }

        public bool IsDead { get { return IsDeadCondition(); } }

        public abstract Func<bool> IsDeadCondition { get; }
    }
}
