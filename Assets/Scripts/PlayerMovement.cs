using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public InputAction playerControls;
    public float speed = 1.0f;
    public Rigidbody rb;
    Vector3 moveDirection = Vector3.zero;
     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(0, 0, moveDirection.z * speed);
    }
}
