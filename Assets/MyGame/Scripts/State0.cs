using UnityEngine;

public class State0 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State0()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!
        if (_state == null)
        {
            _state = new State0();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 0;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State9.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State1.GetState();
    }
}
