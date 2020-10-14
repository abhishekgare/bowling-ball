using System;
using System.Collections;

namespace BowlingBall {
    public class BonusRoll : Frame {

        public BonusRoll (ArrayList chances, int pins) : base (chances) {
            chances.Add (pins);
        }

        override public int GetScore () {
            return 0;
        }

        override protected int FrameSize () {
            return 0;
        }
    }
}