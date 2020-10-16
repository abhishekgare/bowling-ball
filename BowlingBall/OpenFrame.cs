using System;
using System.Collections;

namespace BowlingBall {
    public class OpenFrame : IFrame, IBonusBall {

        protected ArrayList _chances;
        protected int _firstChance;
        public OpenFrame (ArrayList chances, int pins) {
            chances.Add (pins);
        }

        public int GetScore () {
            return (int) _chances[_firstChance] + (int) _chances[_firstChance + 1];
        }

        public int FirstBonusBall () {
            return (int) _chances[_firstChance + FrameSize ()];
        }

        public int SecondBonusBall () {
            return (int) _chances[_firstChance + FrameSize () + 1];
        }

        public int FrameSize () {
            return 2;
        }
    }
}