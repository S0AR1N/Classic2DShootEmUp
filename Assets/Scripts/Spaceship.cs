using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] private GameObject Shell;
    [SerializeField] private float speed;
    [SerializeField] private float health;
    private GameObject gun1, gun2;
    int delay = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gun1 = transform.Find("gun1").gameObject;
        gun2 = transform.Find("gun2").gameObject;
    }

    private void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if(Input.GetKey(KeyCode.Space) && delay > 50) { Shoot(); }

        delay++;
    }

    public void Damage() { 
        health--;
        if (health == 0) { Destroy(gameObject); }
    }

    void Shoot()
    {
        delay = 0;
        Instantiate(Shell, gun1.transform.position, Quaternion.identity);
        Instantiate(Shell, gun2.transform.position, Quaternion.identity);
    }
}
