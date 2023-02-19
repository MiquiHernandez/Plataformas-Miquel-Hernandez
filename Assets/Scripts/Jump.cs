using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 10;
   
    Rigidbody2D rb;
    GroundDetector ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ground.grounded == true && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, force));
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Reset Jump")
        {
            ground.grounded = true;
        }
    }
}

