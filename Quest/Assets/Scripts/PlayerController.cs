using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 35.0f;
    private CharacterController controller;
    private static GameObject instance;
    public GameObject flashlight;
    public bool lightisactive;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = gameObject;
        }
        else Destroy(gameObject);        
    }

    public void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public bool FlashlightActivator()
    {
        if (Input.GetKeyDown(KeyCode.F) && lightisactive == false)
        {
            return lightisactive = true;
        }

        if (Input.GetKeyDown(KeyCode.F) && lightisactive == true)
        {
            return lightisactive = false;
        }
        return lightisactive;
    }

    public void Update()
    {
        FlashlightActivator();

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        
        moveDirection.y -= 500 * Time.deltaTime;
        
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        // Приседание

        if (Input.GetKey(KeyCode.LeftControl))
        {
            moveSpeed = 17f;
            transform.localScale = new Vector3(Mathf.Lerp(7, 7, Time.time), Mathf.Lerp(10, 5, Time.time), Mathf.Lerp(7, 7, Time.time));
        }
        else
        {
            moveSpeed = 35f;
            transform.localScale = new Vector3(Mathf.Lerp(7, 7, Time.time), Mathf.Lerp(10, 10, Time.time), Mathf.Lerp(7, 7, Time.time));
        }

        // Бег

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localScale = new Vector3(Mathf.Lerp(7, 7, Time.time), Mathf.Lerp(10, 10, Time.time), Mathf.Lerp(7, 7, Time.time));
            moveSpeed = 50f;
        }
        else
        {
            moveSpeed = 35f;
        }

        // Фонарик

        if (lightisactive == true)
        {
            flashlight.SetActive(true);
        }
        else
        {
            flashlight.SetActive(false);
        }
    }
}

