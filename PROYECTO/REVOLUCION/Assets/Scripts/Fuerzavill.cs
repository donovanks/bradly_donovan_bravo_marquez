using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzavill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.up * 500.0f + 250f * rb.velocity.normalized, ForceMode2D.Impulse);
        }

        
    }

}
