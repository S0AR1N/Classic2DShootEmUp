using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    Rigidbody2D rb;
    int dir = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(0, 8 * dir);
    }

    public void ChangeDirection()
    {
        dir *= -1;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "PlayerBounds")
        {
            Destroyed();
        }
    }

    void Destroyed()
    {
        Destroy(gameObject);
    }
}
