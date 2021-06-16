using UnityEngine;

public class AttachOrb : MonoBehaviour
{
    private GameObject parent;
    private DistanceJoint2D distanceJoint;
    public GameObject rope;

    void Start()
    {
        parent = this.transform.parent.gameObject;
        distanceJoint = parent.GetComponent<DistanceJoint2D>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightOrb")
        {
            distanceJoint.enabled = true;
            distanceJoint.autoConfigureDistance = false;
            distanceJoint.distance = GetComponent<CircleCollider2D>().radius*gameObject.transform.localScale.x;
            distanceJoint.connectedBody = other.gameObject.GetComponent<Rigidbody2D>();

            Destroy(this.gameObject);

            GameObject currentRope = Instantiate(rope) as GameObject;
            currentRope.transform.parent = parent.transform;
            currentRope.GetComponent<RopeBridge>().StartPoint = parent.transform;
            currentRope.GetComponent<RopeBridge>().EndPoint = other.transform;
            currentRope.GetComponent<RopeBridge>().SegmentCount = (int)distanceJoint.distance * 10;
        }
    }
}
