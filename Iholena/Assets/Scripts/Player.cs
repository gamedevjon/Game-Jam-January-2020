using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private float _jumpHeight = 3.0f;
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        //CalculateMovementRB();
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float jump = 0.0f;
        Vector2 moveDirection;

        //if (Input.GetButton("Jump"))
        //{
        //    jump = _jumpHeight;
        //}

        moveDirection = new Vector2(Input.GetAxis("Horizontal"), jump);
        moveDirection *= _speed;

        transform.Translate(moveDirection * Time.deltaTime);


        //transform.Translate(Vector2.right * horizontalInput * _speed * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8.3f, 8.3f), Mathf.Clamp(transform.position.y, -2.0f, 3.0f));
        //Debug.Log("Y Position: " + transform.position.y);
        //moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //moveDirection *= speed;

        //if (Input.GetButton("Jump"))
        //{
        //    moveDirection.y = jumpSpeed;
        //}
    }

    void CalculateMovementRB()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");


        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        if (Input.GetButton("Jump"))
        {
            movement.y = _jumpHeight;
        }

        //rb.AddForce(movement * _speed);
        rb.velocity = movement * _speed;
        rb.AddForce(Vector2.up * _jumpHeight, ForceMode2D.Impulse);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8.3f, 8.3f), Mathf.Clamp(transform.position.y, -2.0f, 3.0f));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Iholena")
            Debug.Log(other.gameObject.name + " : " + gameObject.name + " : " + Time.time);

    }
}
