using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustDireactionBehaviour : StateMachineBehaviour
{
    /// <summary>
    /// restore the previous state of crazy zombie after being bumped
    /// </summary>
    /// <param name="bumped">set it false to stop adjust state to enter idle/attack state </param>
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("bumped",false);
    }
}
