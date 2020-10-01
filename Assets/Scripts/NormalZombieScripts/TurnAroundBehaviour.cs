using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAroundBehaviour : StateMachineBehaviour
{
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
