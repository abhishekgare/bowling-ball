using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests {
    [TestClass]
    public class GameFixture {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test () {
            var game = new Game ();
            Roll (game, 0, 20);
            Assert.AreEqual (0, game.GetScore ());
        }

        [TestMethod]
        public void Spare () {
            var game = new Game ();
            game.Spare (4);
            game.OpenFrame (10);
            Roll (game, 24, 5);
            Assert.AreEqual (21, game.GetScore ());
        }

        private void Roll (Game game, int pins, int times) {
            for (int i = 0; i < times; i++) {
                game.Roll (pins);
            }
        }
    }
}