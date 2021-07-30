using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;

    private Rigidbody2D rigidbody_2D;

    private UIManager _UIManager;
    private int _stageLevel = 1;

    public float moveSpeed = 2f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Start()
    {
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>(); //get access to canvas
        _UIManager.UpdateStageDisplay(_stageLevel);
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Movement();
        movePlayer();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction_2d = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction_2d * _speed * Time.deltaTime); 
    }

    void movePlayer()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void updateStageLevel()
    {
        _stageLevel++;
        _UIManager.UpdateStageDisplay(_stageLevel);

        if(_stageLevel == 3)
        {
            Application.Quit();
        }
    }
}
