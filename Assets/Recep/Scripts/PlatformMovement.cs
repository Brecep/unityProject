using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
