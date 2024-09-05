using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class LevelUp : MonoBehaviour
{
    [SerializeField] private UnityEvent _actionMenu;

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            _actionMenu?.Invoke();
        }
    }

    public void NewLvl()
    {
        if (Time.timeScale == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
            
        }
    }
}
