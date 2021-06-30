using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpForce = 20f;

    private int _jumpCount = 2;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _jumpCount = 2;
        }
    }

    private void Jump()
    {
        if (_jumpCount <= 0) return;

        var movement = Vector2.up * jumpForce;
        rigidBody.velocity = movement;
        _jumpCount--;
    }
}
