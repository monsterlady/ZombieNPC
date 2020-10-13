
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockWalkBehaviour : StateMachineBehaviour
{
    /// <summary>
    /// restore the state in case it stucks in knock back state.
    /// </summary>
    /// <param name="bumped">set it as false to enter idle/chase/attack/adjust state</param>
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("bumped", false);
    }
}
