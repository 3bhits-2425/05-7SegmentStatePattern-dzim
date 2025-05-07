using UnityEngine;

public class State8 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State8()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if (_state == null)
        {
            _state = new State8();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 8;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State7.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State9.GetState();
    }
}
