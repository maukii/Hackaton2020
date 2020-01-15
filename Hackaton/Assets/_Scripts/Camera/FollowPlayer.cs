using UnityEngine;

[DisallowMultipleComponent]
public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float smoothTime = 0.3f;    
    private Vector3 velocity = Vector3.zero;

    private float offset;

    private void Awake()
    {
        if (playerTransform == null) playerTransform = GameObject.Find("Player").transform;
        if(playerTransform == null)
        {
            Debug.LogError("Couldn't find player");
            Destroy(gameObject);
            return;
        }

        offset = transform.position.x - playerTransform.position.x;
    }

    private void Update()
    {
        var targetPosition = new Vector3(playerTransform.position.x + offset, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
