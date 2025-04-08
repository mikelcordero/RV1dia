using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Vector3 direccion;        // Dirección en la que se mueve el proyectil
    public bool esProyectilRojo = false; // Esta variable está en falso para los proyectiles normales
    public float velocidad = 5f;     // Velocidad de movimiento del proyectil

    void Update()
    {
        // Movemos el proyectil hacia la dirección especificada
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}

