using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // เช็คว่าติดพื้นอยู่ไหม (แบบง่าย)
        if (Physics.Raycast(transform.position, Vector3.down, 1.1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        // กระโดด
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveZ = Input.GetAxis("Horizontal"); // A, D

        Vector3 move = new Vector3(moveZ, 0, 0); // ขยับแค่แกน X

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
   
}
