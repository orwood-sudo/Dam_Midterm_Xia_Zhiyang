using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Key Map")]
    public InputAction moveUp;
    public InputAction moveDown;

    [Header("Player controller")]
    public Rigidbody2D body2D;
    [SerializeField] private float moveSpeed = 1.0f;
    [SerializeField] private float dampSpeed = 0.99f;

    public void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
    }

    public void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
    }

    public void Update()
    {
        if (moveUp.IsPressed() || moveDown.IsPressed())
        {
            if (moveUp.IsPressed())
            {
                body2D.linearVelocityY = moveSpeed;
            }
            if (moveDown.IsPressed())
            {
                body2D.linearVelocityY = -moveSpeed;
            }
        }else if (body2D.linearVelocityY != 0)
        {
            body2D.linearVelocityY *= dampSpeed;
            if (body2D.linearVelocityY < 0.01f && body2D.linearVelocityY > 0.01f)
            {
                body2D.linearVelocityY *= 0;
            }
        }
    }

}
