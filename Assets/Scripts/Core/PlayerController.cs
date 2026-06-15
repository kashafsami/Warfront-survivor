using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Keyboard arrow keys aur WASD controls input handle karne ke liye
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // 2D space mein vector direction calculate karna
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        // Player transform position ko real-time input ke mutabiq move karna
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
