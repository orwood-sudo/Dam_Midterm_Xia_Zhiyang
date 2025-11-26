using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI point_P1;
    public TextMeshProUGUI point_P2;
    public Vector2 points;

    public void UpdateP1()
    {
        points.x += 1;
        point_P1.text = (points.x).ToString();
        Invoke("UpdateBall", 0.1f);
    }

    public void UpdateP2()
    {
        points.y += 1;
        point_P2.text = (points.y).ToString();
        Invoke("UpdateBall", 0.1f);
    }

    public void UpdateBall()
    {
        BallMovement ball = FindFirstObjectByType<BallMovement>();
        ball.ResetPosition();
    }
}
