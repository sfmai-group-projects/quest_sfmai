using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    private Animator animator;
    public KeyCode key;
    public bool i = false;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Prikol()
    {
        if (i == true)
        {
            animator.enabled = true;
        }
    }
}
