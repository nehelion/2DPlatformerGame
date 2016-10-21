using UnityEngine;
using System.Collections;

public class Stopper : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || 
              Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            animator.Play("Stop");
        }
    }
}
