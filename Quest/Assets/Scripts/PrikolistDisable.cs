using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrikolistDisable : MonoBehaviour
{
    public GameObject prikolist;
    private static GameObject instance;
    public bool ColliderHit;
    public Vector3 newpos;
    public bool Move = false;


    public void Awake()
    {
        if (Inventory.PrikolistMove == true)
        {
            Destroy(prikolist);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Move = true;
        }
    }


    public IEnumerator DisablePrikolist()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(prikolist);
        Inventory.PrikolistMove = true;
        Move = false;
    }


    public void Update()
    {
        if (Move == true)
        {
            prikolist.transform.position = Vector3.Lerp(prikolist.transform.position, newpos, Time.deltaTime * 3f);
            StartCoroutine(DisablePrikolist());
        }
    }
}
