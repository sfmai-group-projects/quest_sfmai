using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderDDOL : MonoBehaviour
{
    private static GameObject instance;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = gameObject;
        }
        else Destroy(gameObject);
    }
}
