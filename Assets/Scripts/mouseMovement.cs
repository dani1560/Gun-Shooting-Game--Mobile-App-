using EasyJoystick;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    float xPosition;
    float yPosition;
    public GameObject target;
    [SerializeField] private Joystick joystick;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        xPosition += 1f * joystick.Horizontal();
        yPosition -= 1f * joystick.Vertical();

        transform.eulerAngles = new Vector3(yPosition, xPosition, 0f);
    }
}
