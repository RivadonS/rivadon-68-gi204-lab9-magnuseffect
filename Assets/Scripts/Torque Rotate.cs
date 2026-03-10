using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class TorqueRotate : MonoBehaviour
{
    [Header("Torque Settings")]
    //[SerializeField] private Vector3 torqueAmount = new Vector3(0f, 0f, 50f);
    [SerializeField] private float torquePower = 50f;

    private Rigidbody rb;
    private bool isPressingD = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            isPressingD = true;
        }
        else
        {
            isPressingD = false;
        }
    }

    void FixedUpdate()
    {
        if (isPressingD)
        {
            rb.AddTorque(0f, 0f, torquePower);
        }
    }
}