using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 pos;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = pos;
        }
    }
}
