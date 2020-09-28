using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Serialization;

public class NormalZombieStatus : MonoBehaviour
{
    public float chaseDistance;
    public float attackDistance;
    public float attackAngular;
    public GameObject _player;

    private float _angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
            //计算僵尸和玩家之间的距离
            if ( _distance > attackDistance && _distance <= chaseDistance)
            {
                //超过攻击范围
                gameObject.GetComponent<Animator>().SetBool("isCaptured",false);
                //开始追击
                gameObject.GetComponent<Animator>().SetBool("isToofar",false);
            }
            else if (_distance < attackDistance)
            {
                //开始攻击
                gameObject.GetComponent<Animator>().SetBool("isCaptured",true);
            }
            else
            {
                //超过攻击范围
                gameObject.GetComponent<Animator>().SetBool("isCaptured",false);
                //停止追击
                gameObject.GetComponent<Animator>().SetBool("isToofar",true);
            }
            //旋转到合适角度
            Vector3 _playerPOS = new Vector3(_player.transform.position.x,0,_player.transform.position.z);
            Vector3 _nwPOS = new Vector3(transform.position.x,0,transform.position.z);
            Vector3 targetDir = _playerPOS - _nwPOS;
            _angle = Vector3.Angle(targetDir, transform.forward);
            
            //print(_angle.ToString());
            if (_angle < attackAngular)
            {
                //TODO 进入追击阶段
                gameObject.GetComponent<Animator>().SetBool("isAngularCorrect",true);
            }
            else
            {
                gameObject.GetComponent<Animator>().SetBool("isAngularCorrect",false);
            }
    }
    

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "CrazyZombie" )
        {
            if (collision.gameObject.name == "CrazyZombie")
            {
                Debug.Log("僵尸相撞！");
            }
            else
            {
                Debug.Log("玩家相撞！");
            }

            //If the GameObject's name matches the one you suggest, output this message in the console
            gameObject.GetComponent<Animator>().SetBool("bumped",true);
        }
    }
}
