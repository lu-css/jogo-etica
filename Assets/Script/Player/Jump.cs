using UnityEngine;

public class Jump : MonoBehaviour
{
    bool isGrounded;
    Rigidbody rb;
    public Vector3 groundCheckPos;
    public float groundCheckSize = 1f, jumpForce;
    public LayerMask layer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Jumping();
    }

    void Jumping()
    {
        var groundCheck = Physics.OverlapSphere(transform.position + groundCheckPos, groundCheckSize, layer);
        isGrounded = groundCheck.Length != 0;

        if (!isGrounded)
        {
            // Animação
            return;
        }


        if (!Input.GetKeyDown(KeyCode.Space)) return;
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + groundCheckPos, groundCheckSize);
    }
}
