using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D), typeof(PlayerInput))]
public class PlayerTilt : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput input;

    [SerializeField] private float targetTilt = 25f;
    [SerializeField] private float tiltSpeed = 5.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        var horizontalRaw = input.GetHorizontalRaw();
        var targetAngle = 0.0f;
        if (horizontalRaw > 0f)
            targetAngle = -targetTilt;
        else if (horizontalRaw < 0f)
            targetAngle = targetTilt;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Vector3.forward * targetAngle), tiltSpeed * Time.deltaTime);
    }
}
