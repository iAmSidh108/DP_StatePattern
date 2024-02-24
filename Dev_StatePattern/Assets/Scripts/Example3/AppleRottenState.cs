using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    public override void EnterState(AppleStatesManager apple)
    {
        stateTXT.text = "Hello from RottenState. I was not picked up. So, I got rotten";
    }

    public override void OnCollisionEnter(AppleStatesManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            //Get reference of player and decrease health
            //other.GetComponent<PlayerController>().ReduceHealth();

            apple.SwitchState(apple.chewedState);
        }
    }

    public override void UpdateState(AppleStatesManager apple)
    {

    }
}
