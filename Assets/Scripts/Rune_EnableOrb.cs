using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using Pathfinding;

public class Rune_EnableOrb : MonoBehaviour
{
    public List<GameObject> WallOrbs;
    public List<GameObject> Anchors;
    public GameObject Target;
    private GameObject Player;
    private GameObject Area;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightOrb")
        {
            foreach (GameObject orb in WallOrbs)
            {
                orb.GetComponent<Light2D>().enabled = true;
            }

            foreach (GameObject anchor in Anchors)
            {
               Area = anchor.transform.GetChild(0).gameObject;
               Area.SetActive(true);
            }

            Player.GetComponent<AIDestinationSetter>().target = Target.transform;
        }
    }
}
