using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePhaseBehaviour : StateMachineBehaviour
{
    /// <summary>
    /// if Crazy zombie hears the sound, he will run toward that place
    /// </summary>
    /// <param name="soundMade">set it as false, make the crazy zombie enter idle state</param>
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.SetBool("soundMade",false);
    }
}
