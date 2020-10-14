using System;
using System.Collections;

namespace BowlingBall {
    public class OpenFrame : Frame {

        public OpenFrame (ArrayList chances, int pins) : base (chances) {
            chances.Add (pins);
        }

        override public int GetScore () {
            return (int) _chances[_firstChance] + (int) _chances[_firstChance + 1];
        }

        override protected int FrameSize () {
            return 2;
        }
    }
}