using UnityEngine;

public class RopeCutter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector2(0.01f, 0.01f));
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Rope")
                {
                    hit.collider.transform.parent.gameObject.GetComponent<DistanceJoint2D>().enabled = false;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

}
