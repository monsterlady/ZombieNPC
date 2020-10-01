using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;

public class CrazyZombieController : MonoBehaviour
{
    public GameObject _player;
    public float attackDistance;
    private Vector3 _tempPosition;
    private bool _hasTarget = false;
    private ScrollRect.MovementType movementType;

    // Update is called once per frame
    void Update()
    {
        if (_hasTarget)
        {
            //计算距离
            float _distance = Vector3.Distance(gameObject.transform.position, _tempPosition);
            if (_distance < attackDistance)
            {
                //开始攻击
                _hasTarget = false;
                gameObject.GetComponent<Animator>().SetBool("isCaptured", true);
            }
            else
            {
                //进入追击
                
                //旋转角度
                Vector3 targetPostition = new Vector3( _tempPosition.x, 
                    gameObject.transform.position.y, 
                    _tempPosition.z ) ;
                gameObject.transform.LookAt( targetPostition ) ;
                gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("isCaptured", false);
        }

        //如果玩家发出了声音
        if (_player.GetComponent<PlayerBehaviour>().SoundMade)
        {
            //听见声音
            gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            //设置声音坐标
            _tempPosition = _player.transform.position;
            _hasTarget = true;
            //计算距离
            float _distance = Vector3.Distance(gameObject.transform.position, _tempPosition);
            if (_distance < attackDistance)
            {
                //开始攻击
                _hasTarget = false;
                gameObject.GetComponent<Animator>().SetBool("isCaptured", true);
            }
            else
            {
                //进入追击
                gameObject.GetComponent<Animator>().SetBool("soundMade", true);
            }
        }
        else
        {
            //未听见
            gameObject.GetComponent<Animator>().SetBool("soundMade", false);
        }
    }
    
    /// <summary>
    /// While Player bump CrazyZombie
    /// </summary>
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "Player")
        {
            //crazy zombie only turn around when he is in Idle state
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
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //Only Player and Zombie(Normal and Crazy) could bump.
        if (collision.gameObject.name == "NormalZombie" )
        {
            if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(gameObject.layer).IsName("Idle"))
            {
                gameObject.GetComponent<Animator>().SetBool("bumped",true);
            }
        }
    }
}