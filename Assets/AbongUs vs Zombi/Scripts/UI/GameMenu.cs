using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void OpenMenu()
    {
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        Time.timeScale = 1;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame(string MainMenu)
    {
        
          SceneManager.LoadScene(MainMenu);
    }
}
