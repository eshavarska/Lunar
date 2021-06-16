using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChanger : MonoBehaviour
{
    public Camera Camera;
    public float X, Y;

    private Vector3 newPosition;

    private void Start()
    {
        newPosition = new Vector3(X, Y, -10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Camera.transform.position = newPosition;
        }
    }
}
