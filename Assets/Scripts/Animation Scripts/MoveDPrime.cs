using UnityEngine;
using System.Collections;

public class MoveDPrime : StateMachineBehaviour {

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.Play("moveD''");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.Play("moveA''");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.Play("pointW''");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.Play("pointS''");
        }
    }
}
