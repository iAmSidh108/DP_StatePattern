using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppleStatesManager : MonoBehaviour
{

    AppleBaseState currentState;
    public TextMeshProUGUI stateTXT;

    public AppleGrowingState growingState=new AppleGrowingState();
    public AppleWholeState wholeState=new AppleWholeState();
    public AppleRottenState appleRottenState=new AppleRottenState();
    public AppleChewedState chewedState=new AppleChewedState();

    
    void Start()
    {
        currentState = growingState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(AppleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
