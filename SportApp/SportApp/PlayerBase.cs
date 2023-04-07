namespace SportApp
{
    public abstract class PlayerBase : IPlayer
    {
        public PlayerBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public abstract void AddResult(float result);

        public void AddResult(string result)
        {
            if (float.TryParse(result, out float resultInFloat) && resultInFloat > 0)
            {
                AddResult(resultInFloat);
            }
            else
            {
                throw new Exception("Wartość musi być liczbą");
            }
        }

        public void AddResult(int result)
        {
            float resultInFloat = result;
            AddResult(resultInFloat);
        }

        public abstract Statistic GetStatistics();

        public abstract event ResultAddedDelegate ResultAdded;
        public delegate void ResultAddedDelegate(object sender, EventArgs args);
    }
}