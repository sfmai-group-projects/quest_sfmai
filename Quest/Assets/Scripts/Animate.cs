using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;
    public GameObject Fader;
    public GameObject[] doors;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    [SerializeField]
    public void FixedUpdate()
    {
        doors = GameObject.FindGameObjectsWithTag("Door");
        for (int i = 0; ; i++)
        {
            if (doors[i].GetComponent<DoorOpener>().All == true)
            {
                animator.enabled = true;
            }
        }
    }

    public void AnimatorDisable()
    {
        animator.enabled = false;
    }
}