using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(h * speed * Time.deltaTime, 0));
    }
}
