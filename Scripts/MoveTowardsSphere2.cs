using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsSphere2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;            // Velocidad de movimiento
    public GameObject target;               // El objetivo al cual moverse
    private Rigidbody rb;                   // Referencia al Rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculamos la dirección hacia el objetivo
        Vector3 direction = (target.transform.position - transform.position).normalized;
        // Movemos la esfera hacia el objetivo
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
