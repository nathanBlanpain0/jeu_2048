using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merge : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    float value;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        value = 2;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Mathf.Abs(rb.velocityX) > 0.01f || Mathf.Abs(rb.velocityY) > 0.01f)
        {
            value = 2 * value;
            Debug.Log("ah");
            Destroy(collision.gameObject);
        }
    }
}
  
