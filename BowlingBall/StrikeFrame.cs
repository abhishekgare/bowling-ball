using System;
using System.Collections;

namespace BowlingBall {
    public class StrikeFrame : Frame {

        public StrikeFrame (ArrayList chances) : base (chances) {
            chances.Add (10);
        }

        override public int GetScore () {
            return 10 + FirstBonusBall () + SecondBonusBall ();
        }

        override protected int FrameSize () {
            return 1;
        }
    }
}