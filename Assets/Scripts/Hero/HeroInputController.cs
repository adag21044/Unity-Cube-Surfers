using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizontalValue;
    public float HorizontalValue
    {
        get
        {
            return horizontalValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleHeroHorizontalInput();
    }

    private void HandleHeroHorizontalInput()
    {
        if(Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
