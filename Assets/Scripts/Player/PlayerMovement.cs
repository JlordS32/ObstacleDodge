using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new(horizontalInput, 0f, verticalInput);

        // Prevent speed on diagonal movements.    
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        transform.Translate(movement * (Time.deltaTime * speed));
    }
}
