using UnityEngine;

public class State4 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State4()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!!
        if(_state == null )
        {
            _state = new State4();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 4;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State3.GetState();
    }
    public I7SegmentDisplayState CountUp()
    {
        return State5.GetState();
    }
}
