using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody2D ri;
    public int speed;
    public int jumpSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        ri = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ri.velocity = Vector2.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            ri.velocity = Vector2.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ri.AddForce(Vector2.up * jumpSpeed);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            ri.velocity = Vector2.zero;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ri.velocity = Vector2.zero;
        }
    }
}