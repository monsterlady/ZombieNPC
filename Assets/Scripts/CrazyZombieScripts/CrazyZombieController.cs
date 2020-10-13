using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;

public class CrazyZombieController : MonoBehaviour
{
    /// <summary>
    /// Set player as target
    /// </summary>
    public GameObject _player;
    /// <summary>
    /// in this distance, crazyzombie will trigger attackstate
    /// </summary>
    public float attackDistance;
    
    private Vector3 _tempPosition;
    private bool _hasTarget = false;
    private ScrollRect.MovementType movementType;

    // Update is called once per frame
    void Update()
    {
        if (_hasTarget)
        {
            /// calculate distance between target and crazyzombie
            float _distance = Vector3.Distance(gameObject.transform.position, _tempPosition);
            if (_distance < attackDistance)
            {
                /// start to attack
                _hasTarget = false;
                gameObject.GetComponent<Animator>().SetBool("isCaptured", true);
            }
            else
            {
                
                
                /// rotate crazy zombie's angle
                Vector3 targetPostition = new Vector3( _tempPosition.x, 
                    gameObject.transform.position.y, 
                    _tempPosition.z ) ;
                gameObject.transform.LookAt( targetPostition ) ;
                /// start to chase
                gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("isCaptured", false);
        }

        /// if player made a sound
        if (_player.GetComponent<PlayerBehaviour>().SoundMade)
        {
            gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            /// set target position
            _tempPosition = _player.transform.position;
            _hasTarget = true;
            /// calculate the distance
            float _distance = Vector3.Distance(gameObject.transform.position, _tempPosition);
            if (_distance < attackDistance)
            {
                /// start to attack
                _hasTarget = false;
                gameObject.GetComponent<Animator>().SetBool("isCaptured", true);
            }
            else
            {
                /// start to chase
                gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            }
        }
        else
        {
            /// not hear sound
            gameObject.GetComponent<Animator>().SetBool("soundMade", false);
        }
    }
    
    /// <summary>
    /// While Player bump CrazyZombie
    /// </summary>
    void OnCollisionEnter(Collision collision)
    {
        /// Check for a match with the specified name on any GameObject that collides with your GameObject
        /// Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "Player")
        {
            /// crazy zombie only turn around when he is in Idle state
            if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(gameObject.layer).IsName("Idle"))
            {
                gameObject.GetComponent<Animator>().SetBool("bumped",true);
            }
        }
    }

    /// <summary>
    /// While Player bump CrazyZombie
    /// </summary>
    private void OnTriggerExit(Collider collision)
    {
        /// Check for a match with the specified name on any GameObject that collides with your GameObject
        /// Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "NormalZombie" )
        {
            if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(gameObject.layer).IsName("Idle"))
            {
                gameObject.GetComponent<Animator>().SetBool("bumped",true);
            }
        }
    }
}