using UnityEngine;

public class ProyectilRojo : MonoBehaviour
{
    public Vector3 direccion;        // Dirección en la que se mueve el proyectil
    public bool esProyectilRojo = true; // Esta variable está en verdadero para los proyectiles rojos
    public float velocidad = 5f;     // Velocidad de movimiento del proyectil

    void Update()
    {
        // Movemos el proyectil hacia la dirección especificada
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
