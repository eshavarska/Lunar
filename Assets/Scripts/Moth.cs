using Pathfinding;
using UnityEngine;

public class Moth : MonoBehaviour
{
    public AIPath aiPath;
    private static int lives = 5;
    public static GameObject hearts;

    private void Start()
    {
        hearts = GameObject.Find("Lives");
    }
    private void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if(hearts.transform.childCount > lives)
        {
            Destroy(hearts.transform.GetChild(hearts.transform.childCount - 1).gameObject);
        }
    }

    public static int Lives
    {
        get { return lives; }
        set { lives = value; }

    }

    public static void takeLife()
    {
        lives--;
        Destroy(hearts.transform.GetChild(hearts.transform.childCount - 1).gameObject);
    }
}
