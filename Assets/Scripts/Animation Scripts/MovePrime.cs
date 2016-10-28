using UnityEngine;
using System.Collections;

public class MovePrime : StateMachineBehaviour
{
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play("moveD'");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("moveA'");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("pointW'");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("pointS'");
        }
    }
}
