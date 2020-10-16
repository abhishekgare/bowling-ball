using System;
using System.Collections;

namespace BowlingBall {
    public class StrikeFrame : IFrame, IBonusBall {
        protected ArrayList throws;
        protected int _firstChance;
        public StrikeFrame (ArrayList chances) {
            throws.Add (10);
        }

        public int GetScore () {
            return 10 + FirstBonusBall () + SecondBonusBall ();
        }

        public int FirstBonusBall () {
            return (int) throws[_firstChance + FrameSize ()];
        }

        public int SecondBonusBall () {
            return (int) throws[_firstChance + FrameSize () + 1];
        }

        public int FrameSize () {
            return 1;
        }
    }
}