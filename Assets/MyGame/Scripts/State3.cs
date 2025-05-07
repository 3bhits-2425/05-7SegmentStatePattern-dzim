using UnityEngine;

public class State3 : I7SegmentDisplayState
{
    // erstelle static - Variable
    private static I7SegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State3()
    {

    }

    public static I7SegmentDisplayState GetState()
    {
        // TODO: dot not return null values!!!
        if(_state == null )
        {
            _state = new State3();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 3;
    }
    public I7SegmentDisplayState CountDown()
    {
        return State2.GetState();
    }
    public I7SegmentDisplayState CountUp() 
    {
        return State4.GetState(); 
    }
}
