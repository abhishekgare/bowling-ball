using System;
using System.Collections;

namespace BowlingBall {
    abstract public class Frame {
        protected ArrayList _chances;
        protected int _firstChance;

        public Frame (ArrayList chances) {
            _chances = chances;
            _firstChance = chances.Count;
        }

        abstract public int GetScore ();
        abstract protected int FrameSize ();

        protected int FirstBonusBall () {
            return (int) _chances[_firstChance + FrameSize ()];
        }

        protected int SecondBonusBall () {
            return (int) _chances[_firstChance + FrameSize () + 1];
        }
    }
}