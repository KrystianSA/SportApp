namespace SportApp
{
    public class PlayerInFile : PlayerBase
    {
        private const string _fileName = "statistic.txt";
        public override event ResultAddedDelegate ResultAdded;
        public PlayerInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddResult(float result)
        {
            using (var writer = File.AppendText(_fileName))
            {
                writer.WriteLine(result);
            }

            if (ResultAdded != null)
            {
                ResultAdded(this, new EventArgs());
            }
        }

        public override Statistic GetStatistics()
        {
            var statistic = new Statistic();
            var results = ReadResultsFromFile();
            foreach (var result in results)
            {
                statistic.CountStatistics(result);
            }
            return statistic;
        }

        public List<float> ReadResultsFromFile()
        {
            var result = new List<float>();
            if (File.Exists(_fileName))
            {
                using (var reader = File.OpenText(_fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        result.Add(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }
    }
}