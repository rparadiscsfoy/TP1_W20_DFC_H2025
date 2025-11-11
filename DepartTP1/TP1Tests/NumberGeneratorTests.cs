using TP1;

namespace TP1Tests
{
    public class NumberGeneratorTests
    {
        private const int SMALL_NUMBER_OF_TRIES = 100;
        private const int LARGE_NUMBER_OF_TRIES = 100;

        // PROF : ne vous fiez pas à la nomenclature de ces tests : elle n'est pas à jour
        [Fact]
        public void TestEmptyConstructorCreateSequentialGenerator()
        {
            NumberGenerator gen = new NumberGenerator();

            for (int i = 1; i < SMALL_NUMBER_OF_TRIES; i++)
            {
                Assert.Equal(i, gen.Next());
            }
        }

        [Fact]
        public void TestIntConstructorCreateConstantGenerator_5()
        {
            int expected = 5;
            NumberGenerator gen = new NumberGenerator(expected);

            for (int i = 1; i < SMALL_NUMBER_OF_TRIES; i++)
            {
                Assert.Equal(expected, gen.Next());
            }
        }

        [Fact]
        public void TestIntConstructorCreateConstantGenerator_7()
        {
            int expected = 7;
            NumberGenerator gen = new NumberGenerator(expected);

            for (int i = 1; i < SMALL_NUMBER_OF_TRIES; i++)
            {
                Assert.Equal(expected, gen.Next());
            }
        }

        [Fact]
        public void TestIntConstructorRefuses_0()
        {
            int parameter = 0;

            Assert.Throws<InvalidOperationException>(() => new NumberGenerator(parameter));
        }

        [Fact]
        public void TestIntConstructorRefuses_1000()
        {
            int parameter = 1000;

            Assert.Throws<InvalidOperationException>(() => new NumberGenerator(parameter));
        }

        [Fact]
        public void TestIntConstructorRefusesNegative()
        {
            int parameter = -1;
            Assert.Throws<InvalidOperationException>(() => new NumberGenerator(parameter));

        }

        [Fact]
        public void TestLongConstructorGeneratesPseudorandomSequenceProperlySeeded()
        {
            long parameter = 1337l;
            NumberGenerator gen = new NumberGenerator(parameter);
            Random random = new Random((int)parameter);

            for (int i = 0; i < LARGE_NUMBER_OF_TRIES; i++)
            {
                Assert.Equal(random.Next(1, LARGE_NUMBER_OF_TRIES), gen.Next());
            }
        }

        [Fact]
        public void TestLongConstructorGeneratesPseudorandomSequenceAlwaysInBounds_1337()
        {
            long parameter = 1337L;
            NumberGenerator gen = new NumberGenerator(parameter);

            for (int i = 0; i < LARGE_NUMBER_OF_TRIES; i++)
            {

                int val = gen.Next();
                Assert.True(val > 0);
                Assert.True(val < NumberGenerator.MAX_GENERATED_NUMBER);
            }
        }

        [Fact]
        public void TestLongConstructorGeneratesPseudorandomSequenceAlwaysInBounds_1()
        {
            long parameter = 1l;
            NumberGenerator gen = new NumberGenerator(parameter);

            for (int i = 0; i < LARGE_NUMBER_OF_TRIES; i++)
            {

                int val = gen.Next();
                Assert.True(val > 0);
                Assert.True(val < NumberGenerator.MAX_GENERATED_NUMBER);
            }
        }

        [Fact]
        public void TestLongConstructorGeneratesPseudorandomSequenceAlwaysInBounds_99()
        {
            long parameter = 99L;
            NumberGenerator gen = new NumberGenerator(parameter);

            for (int i = 0; i < LARGE_NUMBER_OF_TRIES; i++)
            {

                int val = gen.Next();
                Assert.True(val > 0);
                Assert.True(val < NumberGenerator.MAX_GENERATED_NUMBER);
            }
        }
    }
}