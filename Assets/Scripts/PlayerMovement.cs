using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool isShift = Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift);

        moveSpeed = isShift ? 1000 : 500;
        // Handle user input
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        Move(targetVelocity);
    }

    void Move(Vector2 targetVelocity)
    {
        // Set rigidbody velocity
        rb.velocity = (targetVelocity * moveSpeed) * Time.deltaTime; // Multiply the target by deltaTime to make movement speed consistent across different framerates
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out GreenWall greenwall))
        {
            GameManager.Instance.PlayQuestions();
        }
    }
}
