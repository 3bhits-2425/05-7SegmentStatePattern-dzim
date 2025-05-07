using UnityEngine;

public class State9 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State9()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if (_state == null)
        {
            _state = new State9();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 9;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State8.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State0.GetState();
    }
}
