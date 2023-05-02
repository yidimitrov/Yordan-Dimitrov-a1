// See https://aka.ms/new-console-template for more information

byte initialHealtPoints = 100;
int instancesCountByType = 5;

Zoo.Zoo zoo = new(initialHealtPoints, instancesCountByType);

zoo.GetHungry();
zoo.GetHungry();
zoo.GetAliveCount();
zoo.Feed();
