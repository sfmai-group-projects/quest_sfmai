using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public KeyCode key;
    GameObject[] items = new GameObject[10];

    void InventoryOpen()
    {
        if (Input.GetKey(key))
        {
            gameObject.SetActive(true);
        }
    }
}
