using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    Vector3 startPosition;
    
    public float jumpForce = 15.0f;
    public float walkForce = 30.0f;
    public float maxWalkSpeed = 2.0f;
    
    float time = 0;
    float animationPeriod = 0.1f;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        startPosition = transform.position;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && Mathf.Abs(rb.linearVelocityY) < 0.01f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(Vector2.right * walkForce);
        }

        time += Time.deltaTime;
        if (Mathf.Abs(rb.linearVelocityY) > 0.1f)
        {
            anim.SetBool("IsJumping", true);
        }
        else if (time > animationPeriod)
        {
            anim.SetBool("IsJumping", false);
        }

        if (transform.position.y < -8f)
        {
            rb.linearVelocity = Vector2.zero;
            transform.position = startPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
        Debug.Log("성공");
    }
}