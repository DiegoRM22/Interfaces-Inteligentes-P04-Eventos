using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBallMovement : MonoBehaviour
{
    public float hitForce = 10f;  // Fuerza del golpe inicial
    public float rotationSpeed = 100f;  // Velocidad de rotación de la bola
    private Rigidbody rb;
    private bool isShot = false;  // Bandera para saber si ya fue disparada
    public float guideLineLength = 10f;  // Longitud de la línea guía

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Girar la bola blanca con las teclas izquierda/derecha
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);

        Debug.DrawRay(transform.position, transform.forward * guideLineLength, Color.red);

        // Golpear la bola con la tecla Espacio si no ha sido disparada
        if (Input.GetKeyDown(KeyCode.Space) && !isShot)
        {
            HitBall();
        }
    }

    void HitBall()
    {
        // Aplicar una fuerza en la dirección hacia adelante de la bola
        Vector3 forceDirection = transform.forward;  // Dirección actual hacia donde está mirando
        rb.AddForce(forceDirection * hitForce, ForceMode.Impulse);

        // Marcar que ya ha sido disparada
        isShot = true;
    }

    // Detectar colisiones con otras bolas y empujarlas
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            // Obtener el Rigidbody de la bola que ha sido golpeada
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            if (ballRigidbody != null)
            {
                // Calcular la dirección del empuje
                Vector3 direction = collision.contacts[0].point - transform.position;
                direction.Normalize();

                // Aplicar una fuerza en la dirección calculada
                float forceMagnitude = 10f;  // Puedes ajustar esta fuerza
                ballRigidbody.AddForce(direction * forceMagnitude, ForceMode.Impulse);
            }
        }
    }
}
