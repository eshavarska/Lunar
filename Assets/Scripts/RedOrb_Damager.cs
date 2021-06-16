using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedOrb_Damager : MonoBehaviour
{
    private bool Used;

    private void Start()
    {
        Used = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !Used)
        {
            Moth.takeLife();
            Debug.Log("Life taken");
            Used = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Used = false;
        }
    }
}
