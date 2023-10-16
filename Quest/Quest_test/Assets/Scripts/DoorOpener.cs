using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour
{
    public GameObject player;
    public Vector3 pos;
    public int sceneName;
    public int i = 0;
    public int j = 0;

    public int OnTriggerEnter(Collider other)
    {
        return i = 1;
    }

    public int OnTriggerExit(Collider other)
    {
        return i = 0;
    }

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E) && i > 0)
        {
            DontDestroyOnLoad(player);
            SceneManager.LoadSceneAsync(sceneName);
            player.transform.position = pos;
        }
    }
}
