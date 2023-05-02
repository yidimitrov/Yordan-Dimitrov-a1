using System.Reflection;
using Zoo.Models;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(byte initialHealtPoints, int instancesCountByType)
        {
            Type[] models = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsAssignableTo(typeof(Animal))).ToArray();

            BorderlineHealthStatusAttribute? getDeadStateAttribute(Type @class) => @class.GetCustomAttribute(typeof(BorderlineHealthStatusAttribute)) as BorderlineHealthStatusAttribute;

            Animals = new List<Animal>();
            foreach (Type model in models)
            {
                for (int i = 0; i < instancesCountByType; i++)
                {
                    var animal = Activator.CreateInstance(model, initialHealtPoints, getDeadStateAttribute(model)?.Points) as Animal;
                    Animals.Add(animal);
                }
            }
        }

        public List<Animal> Animals { get; set; }

        public void GetHungry()
        {
            foreach (var animal in Animals)
            {
                animal.HealthPoints -= Convert.ToByte(new Random().Next(0, 20));
            }
        }

        public void Feed()
        {
            foreach (var animal in Animals)
            {
                animal.HealthPoints += Convert.ToByte(new Random().Next(5, 25));
            }
        }

        public int GetAliveCount()
        {
            return Animals.Where(a => !a.IsDead).Count();
        }
    }
}
