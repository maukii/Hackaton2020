using UnityEngine;

public class MoveForwards : MonoBehaviour
{

    [SerializeField] private float scrollSpeed = 1.0f;
    [SerializeField] private float speedIncrease = 0.001f;


    private void Update()
    {
        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;
        scrollSpeed += speedIncrease * Time.deltaTime;
    }
}
