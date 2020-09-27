using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("撞到僵尸！");
    }

    // Update is called once per frame
    void Update()
    {
        //make a sound
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //TODO 吸引僵尸
        }
    }
}
