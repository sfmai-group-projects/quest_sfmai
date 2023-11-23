using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 35.0f;
    private CharacterController controller;
    private static GameObject instance;
    public GameObject[] items = new GameObject[6];
    public KeyCode key;
    public GameObject inventory;
    public bool InventoryIsActive;

    public void Awake()
    {
        Debug.Log("Вызов Awake");
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

        // Приседание и бег

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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localScale = new Vector3(Mathf.Lerp(7, 7, Time.time), Mathf.Lerp(10, 10, Time.time), Mathf.Lerp(7, 7, Time.time));
            moveSpeed = 50f;
        }
        else
        {
            moveSpeed = 35f;
        }

        // Инвентарь

        if (Input.GetKeyDown(key) && InventoryIsActive == false)
        {
            inventory.SetActive(true);
            InventoryIsActive = true;
        }
        else if (Input.GetKeyDown(key) && InventoryIsActive == true)
        {
            inventory.SetActive(false);
            InventoryIsActive = false;
        }
    }
}

