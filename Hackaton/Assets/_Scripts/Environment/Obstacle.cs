using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Transform playerTransform;


    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(playerTransform.position.x >= transform.position.x)
        {
            GameManager.instance.AddScore();
            LevelGenerator.instance.SpawnObstacle();
            Destroy(this);
            // enabled = false;
        }
    }

}
