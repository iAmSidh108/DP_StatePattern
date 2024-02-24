using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    float rottenToChewedStateTImer = 3f;
    public override void EnterState(AppleStatesManager apple)
    {
        apple.stateTXT.text = "Hello from RottenState. I was not picked up. So, I got rotten";
    }

    public override void OnCollisionEnter(AppleStatesManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            //Get reference of player and decrease health
            //other.GetComponent<PlayerController>().ReduceHealth();

            
        }
    }

    public override void UpdateState(AppleStatesManager apple)
    {
        if (rottenToChewedStateTImer > 0)
        {
            rottenToChewedStateTImer-=Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.chewedState);
        }
    }
}
