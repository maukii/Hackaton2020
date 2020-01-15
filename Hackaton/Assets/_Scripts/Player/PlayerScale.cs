using UnityEngine;

[DisallowMultipleComponent] 
[RequireComponent(typeof(PlayerInput))]
public class PlayerScale : MonoBehaviour
{
    private PlayerInput input;

    [SerializeField] private Transform scalingTransform;
    [SerializeField] private float maxScale = 1.0f;
    [SerializeField] private float minScale = 0.25f;
    [SerializeField] private float scaleSpeed = 1f;
    public float Scale => scalingTransform.localScale.x;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        ScalePlayer((input.PressingDown ? (100+scaleSpeed)/100 : (100-scaleSpeed)/100));
    }

    private void ScalePlayer(float scale)
    {
        Vector3 newScale = scalingTransform.localScale * scale;

        newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
        newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
        newScale.z = Mathf.Clamp(newScale.z, minScale, maxScale);

        scalingTransform.localScale = newScale;
    }
}

