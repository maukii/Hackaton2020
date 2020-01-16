using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent gameOverEvent;

    public static GameManager instance;
    public int score = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void AddScore()
    {
        score += 1;
    }

    public void StartGame()
    {
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        gameOverEvent?.Invoke();
    }

    public void Exit()
    {
        Application.Quit();
    }

}
