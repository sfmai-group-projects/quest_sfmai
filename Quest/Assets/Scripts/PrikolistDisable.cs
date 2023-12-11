using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrikolistDisable : MonoBehaviour
{
    public GameObject prikolist;
    private static GameObject instance;
    public bool ColliderHit;

    public void Awake()
    {
        DontDestroyOnLoad(prikolist);

        if (instance == null)
        {
            instance = prikolist;
        }
        else Destroy(prikolist);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            prikolist.SetActive(false);
        }
    }
}
