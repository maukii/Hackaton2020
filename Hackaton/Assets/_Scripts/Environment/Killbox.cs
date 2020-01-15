using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Killbox : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.GetComponent<PlayerInput>() != null)
        {
            Debug.Log("Game over", this);
            GameManager.instance.GameOver();
        }
    }
}
