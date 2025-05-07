using UnityEngine;

public class State2 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State2()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!
        if (_state == null)
        {
            _state = new State2();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 2;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State1.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State3.GetState();
    }
}
