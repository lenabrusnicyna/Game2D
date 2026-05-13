using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed;
    public bool MoveRight;
    public bool MoveLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-MoveSpeed, rb.linearVelocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(MoveSpeed, rb.linearVelocity.y);

        }

        if (MoveRight)
        {
            rb.linearVelocity = new Vector2(MoveSpeed, rb.linearVelocity.y);
        }
        if (MoveLeft)
        {
            rb.linearVelocity = new Vector2(-MoveSpeed, rb.linearVelocity.y);
        }
    }
}