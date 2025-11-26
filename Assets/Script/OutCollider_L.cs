using UnityEngine;

public class OutCollider_L : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball" && collision.gameObject != null)
        {
            GameManager gm = FindFirstObjectByType <GameManager>();
            gm.UpdateP2();           

        }
    }
}
