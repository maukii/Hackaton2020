using UnityEngine;

[RequireComponent(typeof(PlayerInput), typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    #region Components

    private PlayerInput input;
    private Rigidbody2D rb;

    #endregion

    [Range(1.0f, 10.0f)]
    [SerializeField] private float horizontalSpeed = 2.0f;

    [Range(1.0f, 10.0f)]
    [SerializeField] private float maxVelocity = 2.0f;   


    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);
    }

    private void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if(input.PressingDown)
        {
            movement += Vector2.up * -Physics2D.gravity;
        }

        movement += Vector2.right * input.Horizontal * horizontalSpeed;
        movement *= Time.deltaTime;
        AddMovement(movement);
    }

    private void AddMovement(Vector2 force)
    {
        rb.velocity += force;
    }
}

