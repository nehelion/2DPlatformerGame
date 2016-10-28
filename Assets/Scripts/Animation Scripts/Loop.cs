using UnityEngine;
using System.Collections;

public class Loop : StateMachineBehaviour {

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.Play("moveD");
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("moveA");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.Play("pointW");
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.Play("pointS");
        }
    }
}
