namespace Example_2_10
{
    public class Booldog : Dog, ICute
    {
        public override void SayWoof()
        {
            throw new System.NotImplementedException();
        }

        public int Age { get; set; }
    }
}