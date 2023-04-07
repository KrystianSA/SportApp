namespace SportApp
{
    public interface IPlayer
    {
        string Name { get; }
        string Surname { get; }
        void AddResult(float result);
        void AddResult(string result);
        void AddResult(int result);
        Statistic GetStatistics();
    }
}