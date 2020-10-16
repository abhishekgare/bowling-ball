using System;
using System.Collections;

namespace BowlingBall {
    public class Game {
        ArrayList throws;
        ArrayList frames;
        public void Roll (int pins) {
            frames.Add (new OpenFrame (throws, pins));
            frames.Add (new StrikeFrame (throws));
            frames.Add (new SpareFrame (throws, pins));
            frames.Add (new BonusRoll (throws, pins));
        }
        public int GetScore () {
            int total = 0;
            foreach (IFrame frame in frames)
                total += frame.GetScore ();
            return total;
        }
    }
}