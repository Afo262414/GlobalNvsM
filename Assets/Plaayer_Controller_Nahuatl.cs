using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;         // Velocidad de movimiento del jugador
    public float acceleration = 2f;  // Aceleraci�n del jugador
    public float maxSpeed = 10f;     // Velocidad m�xima del jugador
    public AudioSource walk;
    public Animator animator;

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
        animator.SetFloat("Horizontal", Mathf.Abs(horizontalInput));
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula la direcci�n del movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        movement.Normalize(); // Para evitar el movimiento m�s r�pido en diagonal

        // Comprueba si el jugador se est� moviendo
        isMoving = movement.magnitude > 0;

        // Reproduce o pausa el sonido seg�n el estado de movimiento
        ////if (isMoving)
        ////{
        ////    if (!walk.isPlaying)
        ////    {
        ////        walk.Play();
        ////    }
        ////}
        ////else
        ////{
        ////    walk.Pause();
        ////}

        // Calcula la fuerza de aceleraci�n
        Vector3 accelerationForce = movement * acceleration;

        // Aplica la fuerza de aceleraci�n al Rigidbody
        playerRigidbody.AddForce(accelerationForce);

        // Limita la velocidad m�xima
        if (playerRigidbody.velocity.magnitude > maxSpeed)
        {
            playerRigidbody.velocity = playerRigidbody.velocity.normalized * maxSpeed;
        }

        // Gira el sprite en la direcci�n del movimiento
        if (isMoving)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 0f);

            // Voltea el sprite horizontalmente si te est�s moviendo hacia la derecha
            if (horizontalInput > 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            // Voltea el sprite horizontalmente si te est�s moviendo hacia la izquierda
            else if (horizontalInput < 0)
            {
                transform.localScale = new Vector3(-1, 1f, 1f);
            }
        }
    }
}
