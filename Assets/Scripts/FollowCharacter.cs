using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public Transform moth;
    public Vector3 offset;
  
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(moth.position.x + offset.x, moth.position.y + offset.y, transform.position.z); // Camera follows the player with specified offset position
    }
}
