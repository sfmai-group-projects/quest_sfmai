using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class DoorStairs : MonoBehaviour
{
    public KeyCode key;
    public int sceneIndex;
    public AudioSource open;
    public TMP_Text text;
    public bool ColliderHit = false;
    public static bool All = false;


    public void Awake()
    {
        if (Inventory.KeyStairsTaken == false)
        {
            Destroy(this);
        }

        if (Inventory.KeyStairsTaken == true)
        {
            Destroy(gameObject.GetComponent<DoorLocker>());
        }
    }


    public bool OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = true;
        }
        else return ColliderHit = false;
    }


    public bool OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = true;
        }
        else return ColliderHit = false;
    }


    public bool OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = false;
        }
        else return ColliderHit = false;
    }


    public bool OnMouseOver()
    {
        if (Input.GetKeyDown(key) && ColliderHit == true)
        {
            return All = true;
        }
        else return All = false;
    }


    public void LoadNextScene()
    {
        StartCoroutine(LoadScene());
    }


    public IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.77f);
        SceneManager.LoadScene(sceneIndex);
    }


    public void Update()
    {
        if (All == true && Inventory.KeyStairsTaken == true)
        {
            open.Play();
            LoadNextScene();
        }
    }
}
