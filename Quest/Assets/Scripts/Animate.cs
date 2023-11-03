using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;
    public GameObject door207;
    public GameObject doorstairsright;
    public GameObject Fader;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    [SerializeField]
    public void Update()
    {
        if (door207.GetComponent<DoorOpener>().All == true)
        {
            animator.enabled = true;
        }

        if (doorstairsright.GetComponent<DoorOpener>().All == true)
        {
            animator.enabled = true;
        }
    }

    public void AnimatorDisable()
    {
        animator.enabled = false;
        Destroy(Fader.gameObject);
    }
}