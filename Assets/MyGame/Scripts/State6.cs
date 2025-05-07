using UnityEngine;

public class State6 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State6()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if (_state == null)
        {
            _state = new State6();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 6;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State5.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State7.GetState();
    }
}
