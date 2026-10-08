using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float turnSpeed = 50f;


   void Update()
    {
    float horizontalInput = Input.GetAxis("Horizontal");

    transform.Translate(Vector2.up * forwardSpeed * Time.deltaTime);

    transform.Rotate(0f, 0f, -horizontalInput * turnSpeed * Time.deltaTime);
    }
}
