namespace Example_2_9
{
    public abstract class Test : Child
    {
        public void MeetParent()
        {
            throw new System.NotImplementedException();
        }

        public void MeetChild()
        {
            throw new System.NotImplementedException();
        }

        public abstract bool Lol();
    }
}