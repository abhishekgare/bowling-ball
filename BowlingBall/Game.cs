using System;
using System.Collections;

namespace BowlingBall {
    public class Game {
        ArrayList chances;
        ArrayList frames;

        public Game () {
            chances = new ArrayList ();
            frames = new ArrayList ();
        }
        public void OpenFrame (int pins) {
            frames.Add (new OpenFrame (chances, pins));
        }

        public void Spare (int pins) {
            frames.Add (new SpareFrame (chances, pins));
        }

        public void Strike () {
            frames.Add (new StrikeFrame (chances));
        }

        public void BonusRoll (int roll) {
            frames.Add (new BonusRoll (chances, roll));
        }
        public void Roll (int pins) {
            frames.Add (new OpenFrame (chances, pins));
        }

        public int GetScore () {
            int total = 0;
            foreach (Frame frame in frames)
                total += frame.GetScore ();
            return total;
        }
    }
}