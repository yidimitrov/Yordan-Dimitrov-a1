namespace Zoo.Models
{
    [BorderlineHealthStatus(points: 70)]
    public class Elephant : Animal
    {
        public Elephant(byte initialHealtPoints, byte borderlineHealthStatusPoints)
            : base(initialHealtPoints, borderlineHealthStatusPoints)
        { }

        private bool _IsDead = false;

        public override byte HealthPoints
        {
            get { return _HealthPoints; }
            set
            {
                _IsDead = value < _HealthPoints && !CanWalk;
                _HealthPoints = Math.Min(value, _HealthMax);
            }
        }

        public bool CanWalk
        {
            get
            {
                return HealthPoints >= BorderlineHealthStatusPoints;
            }
        }

        public override Func<bool> IsDeadCondition
        {
            get
            {
                return () => _IsDead;
            }
        }
    }
}
