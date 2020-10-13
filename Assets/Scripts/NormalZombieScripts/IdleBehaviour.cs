using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
    /// <summary>
    /// detect if the player makes sounds
    /// </summary>
    /// <param name="heard">set bool so that other states will change based on this bool.</param>
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.GetComponent<PlayerBehaviour>().SoundMade)
        {
           animator.SetBool("heard",true);
        }
        else
        {
            animator.SetBool("heard",false);
        }
    }
}
