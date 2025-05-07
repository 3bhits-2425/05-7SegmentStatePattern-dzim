using UnityEngine;

public class State1 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State1()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!
        if (_state == null)
        {
            _state = new State1();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 1;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State0.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State2.GetState();
    }
}
