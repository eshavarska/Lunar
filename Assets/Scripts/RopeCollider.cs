using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCollider : MonoBehaviour
{
    LineRenderer rope;
    Transform ropeTransform;
    EdgeCollider2D edgeCollider;


    Vector3 points;
    public List<Vector2> points2 = new List<Vector2>();

    private void Start()
    {
        edgeCollider = this.gameObject.AddComponent<EdgeCollider2D>();
        edgeCollider.isTrigger = true;
        rope = this.gameObject.GetComponent<LineRenderer>();
        ropeTransform = this.gameObject.GetComponent<Transform>();

        getNewPositions();

        edgeCollider.points = points2.ToArray();

        points2.Clear();
    }

    private void Update()
    {
        getNewPositions();

        edgeCollider.points = points2.ToArray();

        points2.Clear();
    }

    void getNewPositions()
    {
        for (int i = 0; i < rope.positionCount; i++)
        {
            points = rope.GetPosition(i);
            points2.Add(new Vector2(points.x - ropeTransform.position.x, points.y - ropeTransform.position.y));
        }
    }

}