using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;
    public GameObject door;
    public GameObject Fader;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    [SerializeField]
    public void Update()
    {
        if (door.GetComponent<DoorOpener>().All == true)
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