using UnityEngine;

[DisallowMultipleComponent]
public class PlayerInput : MonoBehaviour
{
    public bool PressingDown;
    public float Horizontal;
    public float Vertical;


    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        PressingDown = Input.GetMouseButton(0);
    }

    public float GetHorizontalRaw()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public float GetVerticalRaw()
    {
        return Input.GetAxisRaw("Vertical");
    }

    public Vector2 GetPlayerInput()
    {
        return new Vector2(Horizontal, Vertical).normalized;
    }
}
