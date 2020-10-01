using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
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
