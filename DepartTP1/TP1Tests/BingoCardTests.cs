using TP1;

namespace TP1Tests
{
    public class BingoCardTests
    {
        private void MakeSureThisMethodCompiles()
        {
            NumberGenerator generator = new NumberGenerator();
            BingoCard card = new BingoCard(5, generator);
            card.MarkNumber(3);
            int score = card.ComputeScore();
        }

        // Placez vos tests ici

        [Fact]
        public void Test()
        {

        }
    }
}