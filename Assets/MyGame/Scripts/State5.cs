using UnityEngine;

public class State5 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State5()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if (_state == null)
        {
            _state = new State5();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 5;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State4.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State6.GetState();
    }
}
