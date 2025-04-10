using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private SevenSegmentDisplay myDigit;


    private UIManager myUIManager;
    private const int MinDigit = 0;
    private const int MaxDigit = 9;
    public ISevenSegmentDisplayState myDisplayState;
    
    private void Start()
    {
        
        if(myDigit == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the inspector!", this);
            return;
        }

        myUIManager = GetComponent<UIManager>();
        
        if (myUIManager == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the script!", this);
            return;
        }

        myUIManager.SetDisplay(myDigit);
        myDigit.ResetSegmentDisplay();
    }

    private void Update()
    {
        if (!myDigit.isActive) return;

        int currentDigit = myDisplayState.GetDigit();
        myDigit.ExtendSegmentsFor(currentDigit);

        for (int i = MinDigit; i <= MaxDigit; i++)
        {
            if (IsDigitPressed(i))
            {
                HandleDigitInput(i);
                break;
            }
        }

        HandleDigitInput(currentDigit);
    }

    private void HandleDigitInput(int digit)
    {
        myDigit.isNumberSet = true;

        myDigit.ExtendSegmentsFor(digit);
        myUIManager.DeactivateInstruction();
        myUIManager.ActivateResetBtn(true);
    }

    private bool IsPlusPressed()
    {
        return Input.GetKeyDown(KeyCode.Equals) ||
               Input.GetKeyDown(KeyCode.KeypadPlus);
    }
 
    private bool IsMinusPressed()
    {
        return Input.GetKeyDown(KeyCode.Minus) ||
               Input.GetKeyDown(KeyCode.KeypadMinus);
    }

    private bool IsDigitPressed(int i)
    {
        return Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha0 + i)) ||
                        Input.GetKeyDown((KeyCode)((int)KeyCode.Keypad0 + i));
    }
}
