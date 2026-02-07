using UnityEngine;

public class Detect3D : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision với: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger với: " + other.gameObject.name);
    }
}
