using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyZombieController : MonoBehaviour
{
    public GameObject _player;
    public float chaseDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
        if (_distance <= chaseDistance)
        {
            if (_player.GetComponent<PlayerBehaviour>().SoundMade)
            {
                gameObject.GetComponent<Animator>().SetBool("soundMade",true);
            }
            else
            {
                gameObject.GetComponent<Animator>().SetBool("soundMade",false);
            }
        }
        else
        {
            //听不见
            gameObject.GetComponent<Animator>().SetBool("soundMade",false);
        }
    }
}
