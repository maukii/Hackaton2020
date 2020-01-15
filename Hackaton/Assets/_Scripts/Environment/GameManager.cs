using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    }

    public void GameOver()
    {

    }

    public void StartGame()
    {

    }
}
