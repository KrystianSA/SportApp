namespace SportApp.Tests
{
    public class PlayerTests
    {
        [Test]
        public void GetTheHighestResult()
        {
            var player = new PlayerInMemory("Krystian", "S¹siadek");
            player.AddResult(100);
            player.AddResult(10);
            player.AddResult(40);
            var statistic = player.GetStatistics();

            Assert.AreEqual(100, statistic.MaxResult);
        }

        [Test]
        public void GetTheLowestResult()
        {
            var player = new PlayerInMemory("Krystian", "S¹siadek");
            player.AddResult(100);
            player.AddResult(10);
            player.AddResult(40);
            var statistic = player.GetStatistics();

            Assert.AreEqual(10, statistic.MinResult);
        }

        [Test]
        public void GetAvarageFromResults()
        {
            var player = new PlayerInMemory("Krystian", "S¹siadek");
            player.AddResult(100);
            player.AddResult(10);
            player.AddResult(40);
            var statistic = player.GetStatistics();

            Assert.AreEqual(50, statistic.AvarageResult);
        }

        [Test]
        public void GetSumFromResults()
        {
            var player = new PlayerInMemory("Krystian", "S¹siadek");
            player.AddResult(100);
            player.AddResult(5);
            player.AddResult(40);
            var statistic = player.GetStatistics();

            Assert.AreEqual(145, statistic.Sum);
        }
        [Test]
        public void GetDifferenceBetweenMaxAndMinResult()
        {
            var player = new PlayerInMemory("Krystian", "S¹siadek");
            player.AddResult(100);
            player.AddResult(5);
            player.AddResult(40);
            var statistic = player.GetStatistics();

            Assert.AreEqual(95, statistic.Difference);
        }
    }
}