using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBehaviour : MonoBehaviour
{
    private bool _soundMade = false;
    
    // Update is called once per frame
    void Update()
    {
        //make a sound
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _soundMade = true;
        }
        else
        {
            _soundMade = false;
        }
    }

    public bool SoundMade => _soundMade;
}
