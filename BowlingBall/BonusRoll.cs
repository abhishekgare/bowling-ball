using System;
using System.Collections;

namespace BowlingBall {
    public class BonusRoll : IFrame {

        public BonusRoll (ArrayList chances, int pins) {
            chances.Add (pins);
        }

        public int GetScore () {
            return 0;
        }

        public int FrameSize () {
            return 0;
        }
    }
}