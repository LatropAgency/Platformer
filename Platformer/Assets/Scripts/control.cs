using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        if (moveY!=0)
            rb.MovePosition(rb.position + Vector2.up * moveY * speed * Time.deltaTime);
        else
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
    }
}
