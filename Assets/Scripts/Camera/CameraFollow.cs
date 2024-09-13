using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    private Vector3 offset;
    private Vector3 newPosition;
    [SerializeField] private float lerpValue;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - heroTransform.position;    
    }

    void LateUpdate()
    {
        CameraSmoothFollow();
    }

    private void CameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
