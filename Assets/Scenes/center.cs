using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.SqrMagnitude(rb.velocity) < 0.1f)
        {
            transform.position = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
        } 
    }
}

