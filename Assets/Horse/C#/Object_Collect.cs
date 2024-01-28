using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Collect: MonoBehaviour
{
    public float rangoMaximo = 5f; // Establece el rango máximo para agarrar el objeto.

    private bool siendoAgarrado = false;
    private Transform puntoAgarre;
    private Rigidbody rigidbodyObjeto;

    void Start()
    {
        puntoAgarre = new GameObject("PuntoAgarre").transform;
        puntoAgarre.parent = transform;
        puntoAgarre.localPosition = Vector3.zero;

        rigidbodyObjeto = GetComponent<Rigidbody>();
        if (rigidbodyObjeto == null)
        {
            Debug.LogError("El objeto debe tener un Rigidbody para ser agarrado y soltado.");
        }
    }

    void Update()
    {
        if (siendoAgarrado)
        {
            SoltarObjeto();
        }
        else
        {
            AgarrarObjeto();
        }
    }

    void AgarrarObjeto()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject && hit.distance <= rangoMaximo)
                {
                    siendoAgarrado = true;
                    rigidbodyObjeto.isKinematic = true;
                    transform.position = puntoAgarre.position;
                    transform.parent = puntoAgarre;
                }
            }
        }
    }

    void SoltarObjeto()
    {
        if (Input.GetMouseButtonUp(0))
        {
            siendoAgarrado = false;
            rigidbodyObjeto.isKinematic = false;
            transform.parent = null;
        }
    }
}
