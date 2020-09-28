using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBehaviour : MonoBehaviour
{
    private bool _soundMade = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //make a sound
        if (Input.GetKey(KeyCode.Mouse1))
        {
            //TODO 吸引僵尸
            _soundMade = true;
        }
        else
        {
            _soundMade = false;
        }
    }

    public bool SoundMade => _soundMade;
}
