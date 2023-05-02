namespace Zoo.Models
{
    [BorderlineHealthStatus(points: 50)]
    public class Lion : Animal
    {
        public Lion(byte initialHealtPoints, byte borderlineHealthStatusPoints)
            : base(initialHealtPoints, borderlineHealthStatusPoints)
        { }

        public override Func<bool> IsDeadCondition
        {
            get
            {
                return () => HealthPoints < BorderlineHealthStatusPoints;
            }
        }
    }
}
