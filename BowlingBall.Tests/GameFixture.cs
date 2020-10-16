using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests {
    [TestClass]
    public class GameFixture {
        Game game;
        public void Initialize () {
            game = new Game ();
        }

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test () {
            Roll (game, 0, 20);
            Assert.AreEqual (0, game.GetScore ());
        }

        [TestMethod]
        public void Spare () {
            Roll (game, 24, 5);
            Assert.AreEqual (21, game.GetScore ());
        }

        [TestMethod]
        public void Strike () {
            Roll (game, 8, 1);
            Assert.AreEqual (26, game.GetScore ());
        }

        [TestMethod]
        public void Strike_Final_Frame () {
            Roll (game, 0, 0);
            Assert.AreEqual (18, game.GetScore ());
        }

        private void Roll (Game game, int pins, int times) {
            for (int i = 0; i < times; i++) {
                game.Roll (pins);
            }
        }
    }
}