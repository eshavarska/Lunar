using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{   
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_" + GameManager.CurrentLevel.ToString());
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public static void LastLevel()
    {
        SceneManager.LoadScene("Level_" + GameManager.CurrentLevel.ToString());
    }

    public static void NextLevel()
    {
        if(GameManager.CurrentLevel < 8)
        {
            GameManager.CurrentLevel++;
            SceneManager.LoadScene("Level_" + GameManager.CurrentLevel.ToString());
        }
        else
        {
            Debug.LogWarning("No more levels!");
        }
    }

    public static void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public static void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
