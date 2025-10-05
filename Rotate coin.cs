using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 180f; // Adjust speed in Inspector

    void Update()
    {
        // X-axis rotation (lying down coin spinning)
        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
