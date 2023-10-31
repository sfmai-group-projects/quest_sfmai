using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderDDOL : MonoBehaviour
{
    private GameObject instance;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
