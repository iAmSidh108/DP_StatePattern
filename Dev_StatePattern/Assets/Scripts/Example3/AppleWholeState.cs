using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    float rottenCountDown = 5f;

    public override void EnterState(AppleStatesManager apple)
    {
        stateTXT.text = "Hello from whole state. I have fully grown up and will soon fall off the tree because i am heavy and gravity will pull me down ";
        
        apple.GetComponent<Rigidbody>().useGravity = true;
    }

    

    public override void UpdateState(AppleStatesManager apple)
    {
        if (rottenCountDown >= 0)
        {
            rottenCountDown-=Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.appleRottenState);
        }
    }

    public override void OnCollisionEnter(AppleStatesManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            //Get reference of player and increase health
            //other.GetComponent<PlayerController>().AddHealth();
        }
    }
}
