using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockWalkBehaviour : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //return Idle state
        animator.SetBool("isBumped",false);
    }
}
