using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float acceleration;

    void Start()
    {
        rb = Player.PLAYER.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;    
    }
    void Update()
    {
        speed += Time.deltaTime * acceleration;
        rb.velocity = transform.right * speed;
    }
}
