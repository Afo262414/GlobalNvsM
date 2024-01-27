using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;         // Velocidad de movimiento del jugador
    public float acceleration = 2f;  // Aceleraci�n del jugador
    public float maxSpeed = 10f;     // Velocidad m�xima del jugador
    public AudioSource walk;

    private Rigidbody playerRigidbody;
    private bool isMoving = false;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Entrada del jugador
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula la direcci�n del movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize(); // Para evitar el movimiento m�s r�pido en diagonal

        // Comprueba si el jugador se est� moviendo
        isMoving = movement.magnitude > 0;



        // Calcula la fuerza de aceleraci�n
        Vector3 accelerationForce = movement * acceleration;

        // Aplica la fuerza de aceleraci�n al Rigidbody
        playerRigidbody.AddForce(accelerationForce);

        // Limita la velocidad m�xima
        if (playerRigidbody.velocity.magnitude > maxSpeed)
        {
            playerRigidbody.velocity = playerRigidbody.velocity.normalized * maxSpeed;
        }
    }
}
