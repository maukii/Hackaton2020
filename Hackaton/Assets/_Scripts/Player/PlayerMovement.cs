using UnityEngine;

[RequireComponent(typeof(PlayerInput), typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    #region Components

    private PlayerInput input;
    private Rigidbody2D rb;

    #endregion

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


    // TODO:: Add horizontal movement
    private void FixedUpdate()
    {
        if(input.PressingDown)
        {
            AddMovement(Vector2.up * -Physics2D.gravity * Time.deltaTime);
        }

        var horizontalMovement = input.GetPlayerInput() * Time.deltaTime;
        AddMovement(horizontalMovement /* * speed */);
    }

    private void AddMovement(Vector2 force)
    {
        rb.velocity += force;
    }

}
