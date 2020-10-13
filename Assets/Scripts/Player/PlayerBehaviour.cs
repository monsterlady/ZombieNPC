using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// init the sound as false
    /// </summary>
    private bool _soundMade = false;
    
    /// <summary>
    /// player could make a sound through here
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _soundMade = true;
        }
        else
        {
            _soundMade = false;
        }
    }

    /// <summary>
    /// method that allows other entity knows if the player is making sounds,
    /// Readable only
    /// </summary>
    public bool SoundMade => _soundMade;
}
