using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public static LevelGenerator instance;
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private Transform obstacleSpawnTransform;
    [SerializeField] private Transform obstacleParent;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(this);
            return;
        }

        if (obstacleParent == null) 
            obstacleParent = GameObject.Find("Obstacles").transform;
    }

    public void SpawnObstacle()
    {
        var obstacle = Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)], obstacleParent);
        obstacle.transform.SetPositionAndRotation(new Vector2(obstacleSpawnTransform.position.x + obstacle.transform.localScale.x, 0), Quaternion.identity); 
    }
}
