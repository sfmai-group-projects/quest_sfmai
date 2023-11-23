using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    public KeyCode key;
    public bool ColliderHit;

    public bool OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = true;
        }
        else return ColliderHit = false;
    }

    public void OnMouseOver()
    {
        if (Input.GetKey(key) && ColliderHit == true)
        {
            Destroy(this.gameObject);
        }
    }
}
