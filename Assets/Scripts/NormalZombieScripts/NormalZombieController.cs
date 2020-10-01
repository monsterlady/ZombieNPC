using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Serialization;

public class NormalZombieController : MonoBehaviour
{
    public float chaseDistance;
    public float attackDistance;
    public GameObject _player;
    private float _angle;
    
    // Update is called once per frame
    void Update()
    {
            float _distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
            //the distance between player and normalZombie
            if ( _distance > attackDistance && _distance <= chaseDistance)
            {
                //beyond the attack range
                gameObject.GetComponent<Animator>().SetBool("isCaptured",false);
                //start to chase target(Player)
                gameObject.GetComponent<Animator>().SetBool("isToofar",false);
            }
            else if (_distance < attackDistance)
            {
                //stop chase target to attack target
                gameObject.GetComponent<Animator>().SetBool("isCaptured",true);
            }
            else
            {
                //beyond the attack range
                gameObject.GetComponent<Animator>().SetBool("isCaptured",false);
                //stop chasing as the distance is too far away
                gameObject.GetComponent<Animator>().SetBool("isToofar",true);
            }
            
            //rotate to a proper angular

            if (!gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(gameObject.layer).IsName("Idle"))
            {
                //旋转角度
                Vector3 targetPostition = new Vector3( _player.transform.position.x, 
                    gameObject.transform.position.y, 
                    _player.transform.position.z ) ;
                gameObject.transform.LookAt( targetPostition ) ;
            }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "CrazyZombie" )
        {
            gameObject.GetComponent<Animator>().SetBool("bumped",true);
            if (collision.gameObject.name == "CrazyZombie")
            {
                Debug.Log("Zombie Collision!");
            }
            else
            {
                Debug.Log("Player Collision!");
            }
        }
    }
    
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "CrazyZombie" )
        {
            gameObject.GetComponent<Animator>().SetBool("bumped",true);
            if (collision.gameObject.name == "CrazyZombie")
            {
                Debug.Log("123 Zombie Collision!");
            }
            else
            {
                Debug.Log("123 Player Collision!");
            }
        }
    }
}
