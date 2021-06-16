using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MoveChar : MonoBehaviour
{
    protected float speed = 0.1f;
    protected Vector2 dest = Vector2.zero;
    protected Vector2 right;
    protected Vector2 up;

    void Start()
    {
        dest = transform.position;
        right = new Vector2(0.5f, 0);
        up = new Vector2(0, 0.5f);
    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            dest = (Vector2)transform.position + right;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            dest = (Vector2)transform.position - right;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            dest = (Vector2)transform.position + up;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            dest = (Vector2)transform.position - up;
        }
        Move();
    }

    public virtual void Move()
    {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
    }

}
