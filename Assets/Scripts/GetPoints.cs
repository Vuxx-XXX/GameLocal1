using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    public Projectile bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        bullet = gameObject.GetComponentInParent<Projectile>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            
            Score.scoreValue++;
        }
    }
}
