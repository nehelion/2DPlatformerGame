using UnityEngine;
using System.Collections;

public class JumpAnim : StateMachineBehaviour
{
    public bool hitJ;

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (hitJ)
        {
            animator.Play("Take 001");
        }
    }
}
