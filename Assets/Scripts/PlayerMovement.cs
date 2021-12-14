using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D charac;
    
    private Vector2 moveVelocity;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        charac = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        moveVelocity = moveInput * speed;
       
    }
    private void FixedUpdate()
    {
        charac.MovePosition(charac.position + moveVelocity * Time.fixedDeltaTime);
    }
}
