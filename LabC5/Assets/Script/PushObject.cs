using UnityEngine;

public class PushObject : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * 500);
        }
    }
}
