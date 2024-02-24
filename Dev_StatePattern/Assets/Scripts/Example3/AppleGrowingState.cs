using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    float growAppleScalar = 0.1f;
    public override void EnterState(AppleStatesManager apple)
    {
        apple.stateTXT.text = "Hello from growing State. I will keep growing until someone plucks me up or i get roten.";
        
    }

    public override void OnCollisionEnter(AppleStatesManager apple, Collision collision)
    {

    }

    public override void UpdateState(AppleStatesManager apple)
    {

        if (apple.transform.localScale.x < 3)
        {
            apple.transform.localScale += new Vector3(growAppleScalar, growAppleScalar, growAppleScalar) * Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.wholeState);
        }
        

    }
}
