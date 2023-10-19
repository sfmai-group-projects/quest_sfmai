using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 35.0f;
    private CharacterController controller;
    public string sceneName;
    private Scene scene;

    private string Awake()
    {
        DontDestroyOnLoad(gameObject);
        scene = SceneManager.GetActiveScene();
        sceneName = SceneManager.GetActiveScene().name;
        return sceneName;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Awake();
        
        switch (sceneName)
        {
            case "cabinet":
                transform.position = new Vector3(-57, 19, -164);
                break;

            case "floor":
                transform.position = new Vector3(-47, 19, -164);
                break;

            case "stairs-right":
                transform.position = new Vector3(32, 12, -339);
                break;
        }
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
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

