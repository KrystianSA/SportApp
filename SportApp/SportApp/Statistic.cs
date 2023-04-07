namespace SportApp
{
    public class Statistic
    {
        public int Count { get; set; }
        public float MaxResult { get; set; }
        public float MinResult { get; set; }
        public float AvarageResult { get; set; }
        public float Sum { get; set; }
        public float Difference { get; set; }

        public Statistic()
        {
            Count = 0;
            MaxResult = float.MinValue;
            MinResult = float.MaxValue;
            AvarageResult = 0;
            Sum = 0;
            Difference = 0;
        }
        public void CountStatistics(float result)
        {
            Count++;
            MaxResult = Math.Max(result, MaxResult);
            MinResult = Math.Min(result, MinResult);
            Sum += result;
            AvarageResult = Sum / Count;
            Difference = MaxResult - MinResult;
        }
    }
}