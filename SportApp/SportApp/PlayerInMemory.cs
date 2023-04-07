namespace SportApp
{
    public class PlayerInMemory : PlayerBase
    {
        private List<float> results = new List<float>();
        public override event ResultAddedDelegate ResultAdded;

        public PlayerInMemory(string name, string surname) : base(name, surname)
        {
        }

        public override void AddResult(float result)
        {
            results.Add(result);

            if (ResultAdded != null)
            {
                ResultAdded(this, new EventArgs());
            }
        }

        public override Statistic GetStatistics()
        {
            var statistic = new Statistic();
            foreach (var result in results)
            {
                statistic.CountStatistics(result);
            }
            return statistic;
        }
    }
}