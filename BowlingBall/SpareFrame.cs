using System;
using System.Collections;

namespace BowlingBall {
    public class SpareFrame : IFrame, IBonusBall {
        protected ArrayList _chances;
        protected int _firstChance;
        public SpareFrame (ArrayList chances, int pins) {
            chances.Add (pins);
        }

        public int GetScore () {
            return 10 + FirstBonusBall ();;
        }

        public int FirstBonusBall () {
            return (int) _chances[_firstChance + FrameSize ()];
        }

        public int SecondBonusBall () {
            throw new NotImplementedException ();
        }

        public int FrameSize () {
            return 2;
        }
    }
}