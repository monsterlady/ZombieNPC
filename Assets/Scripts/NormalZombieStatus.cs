using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NormalZombieStatus : MonoBehaviour
{
    public float attackDistance;
    
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_player.Equals(null))
        {
            float _distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
            //计算僵尸和玩家之间的距离
            if (_distance <= attackDistance)
            {
                //开始追击
                gameObject.GetComponent<Animator>().SetBool("isToofar",false);
            }
            else
            {
                //停止追击
                gameObject.GetComponent<Animator>().SetBool("isToofar",true);
            }
        }
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("玩家撞到僵尸！");
            gameObject.GetComponent<Animator>().SetBool("bumped",true);
            _player = collision.gameObject;
        }
    }
}
