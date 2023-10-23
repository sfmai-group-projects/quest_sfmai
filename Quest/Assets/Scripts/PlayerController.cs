using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 35.0f;
    private CharacterController controller;
    private static GameObject instance;

    public void Awake()
    {
        Debug.Log("ֲûחמג Awake");
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

    public void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        
        moveDirection.y -= 500 * Time.deltaTime;
        
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            moveSpeed = 20f;
            transform.localScale = new Vector3(Mathf.Lerp(9, 9, Time.time), Mathf.Lerp(11, 5, Time.time), Mathf.Lerp(9, 9, Time.time));
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            moveSpeed = 35f;
            transform.localScale = new Vector3(Mathf.Lerp(9, 9, Time.time), Mathf.Lerp(5, 11, Time.time), Mathf.Lerp(9, 9, Time.time));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 50f;
        }
        else moveSpeed = 35f;
    }
}

