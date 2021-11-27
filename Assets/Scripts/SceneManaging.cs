using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level1");
    }

    public static void Return2Menu()
    {
        SceneManager.LoadScene(0);
    }
    
    public static void GameOver()
    {
        SceneManager.LoadScene(5);
    }
}
