using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject player;
    public bool ColliderHit = false;

    public bool OnTriggerEnter(Collider other)
    {
        return ColliderHit = true;
    }

    public void Update()
    {
        
    }
}
