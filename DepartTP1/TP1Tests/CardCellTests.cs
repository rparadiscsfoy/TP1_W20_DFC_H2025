using TP1;

namespace TP1Tests
{
    public class CardCellTests
    {
        private void MakeSureThisMethodCompiles()
        {
            CardCell cell = new CardCell(7);

            int value = cell.Value;
            bool isMarked = cell.IsMarked;
            cell.MarkCell(7);
        }

        // Placez vos tests ici

        [Fact]
        public void Test()
        {

        }
    }
}