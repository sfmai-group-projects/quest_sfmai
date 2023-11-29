using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public AudioSource walking;
    private float pitch1 = 0.85f; 
    private float pitch2 = 1.15f;
    private AudioSource audioSrc => GetComponent<AudioSource>();

    void Update()
    {
        audioSrc.pitch = Random.Range(pitch1, pitch2);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (walking.isPlaying)
            {
                return;
            }
            walking.Play();
        }
        else
        {
            walking.Stop();
        }
    }
}   