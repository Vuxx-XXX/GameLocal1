using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    public float speed = 1f;
        private Rigidbody2D rb;
    private Animator anim;
    [SerializeField]
    private Transform startPos, endPos;
    private bool collision;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void ChangeDirection()
    {
        collision = Physics2D.Linecast(startPos.position, endPos.position, 1<<LayerMask.NameToLayer("Ground"));
        if (!collision)
        {
            Vector3 temp = transform.localScale;
            
            if (temp.x >0)
            {
                temp.x = -1f;
            }
            else 
            {
                temp.x = 1f;
            }
            transform.localScale = temp;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        ChangeDirection();
    }
    void Move()
    {
        rb.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
}
