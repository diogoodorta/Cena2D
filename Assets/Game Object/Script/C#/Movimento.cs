using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
   
   public float Speed;
   private Rigidbody2D rb;
   public float JumpForce;


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
       Move();
       Jump();
    }
    
    void Move()
    {
        Vector3 movement = new Vector2(Input.GetAxis("Horizontal"), 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);

        }
    }

}
