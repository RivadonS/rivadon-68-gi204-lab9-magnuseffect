using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class TorqueRotate : MonoBehaviour
{
    [Header("Torque Settings")]
    //[SerializeField] private Vector3 torqueAmount = new Vector3(0f, 0f, 50f);
    [SerializeField] private float torquePower = 50f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(0f, 0f, torquePower);
        }
        else
        {
            rb.AddTorque(Vector3.zero);
        }
    }
}