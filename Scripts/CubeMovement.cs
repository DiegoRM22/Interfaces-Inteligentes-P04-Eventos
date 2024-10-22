using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // Velocidad de movimiento
    public float rotateSpeed = 100f; // Velocidad de rotación
    private Rigidbody rb;

    void Start()
    {
        // Obtiene el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Captura la entrada del teclado para movimiento
        float moveVertical = Input.GetAxis("Vertical"); // W y S
        Vector3 movement = transform.forward * moveVertical * moveSpeed * Time.fixedDeltaTime;

        // Mueve el Rigidbody usando MovePosition
        rb.MovePosition(rb.position + movement);

        // Captura la entrada del teclado para rotación
        float moveHorizontal = Input.GetAxis("Horizontal"); // A y D
        Vector3 rotation = new Vector3(0f, moveHorizontal, 0f) * rotateSpeed * Time.fixedDeltaTime;

        // Aplica rotación al Rigidbody.
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
