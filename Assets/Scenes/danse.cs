using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danse : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.getKey("up"))
        {
            rb.velocity = new Vector2(0, 2);
        }
        if (Input.getKey("down"))
        {
            rb.velocity = new Vector2(0, -2);
        }
        if (Input.getKey("right"))
        {
            rb.velocity = new Vector2(2, 0);
        }
        if (Input.getKey("left"))
        {
            rb.velocity = new Vector2(-2, 0);
        }
    }
}
