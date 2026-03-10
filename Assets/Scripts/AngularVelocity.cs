using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    [Header("Angular Velocity")]
    //[SerializeField] Vector3 spinVelocity = new Vector3(0f, 5f, 0f);
    [SerializeField] private float angularPower = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0f, angularPower, 0f); ;
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
