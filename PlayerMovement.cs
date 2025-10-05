using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 50f;
    public float horizontalSpeed = 5f;
    public float rightLimit = 7.5f;
    public float leftLimit = -7.5f;

    void Update()
    {
        // Forward movement
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);

        // Left movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime, Space.World);
            }
        }

        // Right movement
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime, Space.World);
            }
        }
    }
}
