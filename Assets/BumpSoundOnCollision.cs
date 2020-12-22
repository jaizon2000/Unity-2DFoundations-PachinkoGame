using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpSoundOnCollision : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    /**
     * Make sure that the type (2D or 3D) matches so it actually works T___T
     */
    void OnCollisionEnter2D(Collision2D collision)
    {
        source.Play();
    }


}