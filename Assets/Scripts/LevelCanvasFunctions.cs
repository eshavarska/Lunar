using UnityEngine;

public class LevelCanvasFunctions : MonoBehaviour
{
    public GameObject level_menu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (level_menu.activeSelf)
                level_menu.SetActive(false);
            else
                level_menu.SetActive(true);
        }
    }
}
