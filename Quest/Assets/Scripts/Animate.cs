using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animate : MonoBehaviour
{
    private Animator animator;
    public GameObject Fader;
    public GameObject[] doors;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }


    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        for (int i = 0; i <= 5; i++)
        {
            doors = GameObject.FindGameObjectsWithTag("Door");
        }
    }


    [SerializeField]
    public void Update()
    {
        for (int i = 0; i < doors.Length; i++)
        {
            if (doors[i].GetComponent<DoorOpener>().All == true)
            {
                animator.enabled = true;
            }
        }

        if (DoorStairs.All == true)
        {
            animator.enabled = true;
        }
    }


    public void AnimatorDisable()
    {
        animator.enabled = false;
    }
}