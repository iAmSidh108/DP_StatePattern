using UnityEngine;

public class AppleChewedState : AppleBaseState
{

    float destroyCountdown = 5f;
    public override void EnterState(AppleStatesManager apple)
    {
        apple.stateTXT.text = "I have been eaten now. THanks!!";
    }

    public override void OnCollisionEnter(AppleStatesManager apple, Collision collision)
    {
        
    }

    public override void UpdateState(AppleStatesManager apple)
    {
        if (destroyCountdown > 0)
        {
            destroyCountdown-= Time.deltaTime;
        }
        else
        {
            Object.Destroy(apple.gameObject);
        }
    }
}
