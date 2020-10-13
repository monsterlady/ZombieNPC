using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAroundBehaviour : StateMachineBehaviour
{
    /// <summary>
    /// detect if player is making a sound while zombie is turning around
    /// </summary>
    /// <param name="heard">this parameter changes corresponding to soundmade variable of player</param>
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (!player.GetComponent<PlayerBehaviour>().SoundMade)
        {
            animator.SetBool("heard",false);
        }
        else
        {
            animator.SetBool("heard",true);
        }
    }
}
