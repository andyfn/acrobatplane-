using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float spinSpeed = 1000f;

    void Update()
    {
        // Putar baling-baling terus menerus di sumbu Z
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
