namespace Example_2_10
{
    public abstract class Dog : IAnimal
    {
        public void SaySomething()
        {
            throw new System.NotImplementedException();
        }

        public abstract void SayWoof();
    }
}