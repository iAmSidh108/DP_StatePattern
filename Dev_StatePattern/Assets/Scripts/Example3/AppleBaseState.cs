using TMPro;
using UnityEngine;

public abstract class AppleBaseState 
{
    public TextMeshProUGUI stateTXT;

    public abstract void EnterState(AppleStatesManager apple);
     
    public abstract void UpdateState(AppleStatesManager apple);
    
    public abstract void OnCollisionEnter(AppleStatesManager apple, Collision collision);
}
