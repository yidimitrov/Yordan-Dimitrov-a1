namespace Zoo.Models
{
    [BorderlineHealthStatus(points: 40)]
    public class Monkey : Animal
    {
        public Monkey(byte initialHealtPoints, byte borderlineHealthStatusPoints)
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
