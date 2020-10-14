using System;
using System.Collections;

namespace BowlingBall {
    public class SpareFrame : Frame {

        public SpareFrame (ArrayList chances, int pins) : base (chances) {
            chances.Add (pins);
        }

        override public int GetScore () {
            return 10 + FirstBonusBall ();;
        }

        override protected int FrameSize () {
            return 2;
        }
    }
}