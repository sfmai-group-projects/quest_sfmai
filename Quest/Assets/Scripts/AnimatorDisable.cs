using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorDisable : MonoBehaviour
{
    public Animator animator;


    public void AnimatorDis()
    {
        animator.enabled = false;
    }
}
