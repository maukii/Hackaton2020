using UnityEngine;

[RequireComponent(typeof(PlayerInput), typeof(PlayerScale), typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private PlayerInput input;
    private PlayerScale scale;
    private Rigidbody2D rb;
    private ParticleSystem ps;

    [Range(0.0f, 20.0f)] [SerializeField] private float upwardsTrust = 10.0f;
    [Range(0.0f, 20.0f)] [SerializeField] private float horizontalThrust = 7.5f;


    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        scale = GetComponent<PlayerScale>();
        rb = GetComponent<Rigidbody2D>();
        ps = GetComponentInChildren<ParticleSystem>();
    }

    private void FixedUpdate()
    {
        if (input.PressingDown)
        {
            rb.AddForce(Vector2.up * upwardsTrust, ForceMode2D.Force);
            ps.Play(true);
        }

        rb.AddForce((Vector2.right * input.Horizontal * horizontalThrust) / scale.Scale, ForceMode2D.Force);
    }

    //private void Update()
    //{
    //    rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);
    //}

    //private void FixedUpdate()
    //{
    //    Vector2 movement = Vector2.zero;
    //    if(input.PressingDown)
    //    {
    //        movement += Vector2.up * -Physics2D.gravity;
    //    }

    //    speed = horizontalSpeed / scale.Scale;
    //    movement += Vector2.right * input.Horizontal * (horizontalSpeed / scale.Scale);
    //    movement *= Time.deltaTime;
    //    AddMovement(movement);
    //}

    //private void AddMovement(Vector2 force)
    //{
    //    rb.velocity += force;
    //}
}

