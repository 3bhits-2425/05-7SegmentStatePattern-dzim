using UnityEngine;

public class State7 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State7()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if (_state == null)
        {
            _state = new State7();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 7;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State6.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State8.GetState();
    }
}
