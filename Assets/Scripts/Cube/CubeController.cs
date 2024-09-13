using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;
    private Vector3 direction = Vector3.back;  
    private bool isStack = false;
    private RaycastHit hit;

    private void Start()
    {
        heroStackController = FindObjectOfType<HeroStackController>(); 
    }

    private void FixedUpdate()
    {
        CubeRaycast();
    }

    private void CubeRaycast()
    {
        Vector3 halfExtents = new Vector3(0.5f, 0.5f, 0.5f); // Customize the size as needed
        if (Physics.BoxCast(transform.position, halfExtents, direction, out hit, Quaternion.identity, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                heroStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "ObstacleCube")
            {
                heroStackController.DecreaseBlockStack(gameObject);
            }
        }
    }


    private void SetDirection()
    {
        direction = Vector3.forward; 
    }
}