using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D body2d;
    [SerializeField] private float ballSpeed = 4.0f;
    [SerializeField] private float TimeStart = 0.2f;

    private void Awake()
    {
        Move();
    }

    public void Move()
    {
        float[] xDirection = {ballSpeed,-ballSpeed};
        float[] yDirection = {ballSpeed, -ballSpeed};
        body2d.linearVelocity = new Vector2(xDirection[Random.Range(0,2)], yDirection[Random.Range(0, 2)]);
    }

    public void ResetPosition()
    {
        gameObject.transform.position = Vector2.zero;
        body2d.linearVelocity = Vector2.zero;
        Invoke("Move",TimeStart);
    }

}
