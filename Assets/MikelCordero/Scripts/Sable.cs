using UnityEngine;

public class Sable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil") || other.CompareTag("ProyectilRojo"))
        {
            // Destruir el proyectil al colisionar con el sable
            Destroy(other.gameObject); 

            // Comprobar si es un proyectil normal
            Proyectil proyectil = other.GetComponent<Proyectil>();
            if (proyectil != null)
            {
                // Si es proyectil normal, sumar puntos
                MarcadorPuntos.Instancia.SumarPunto();
            }

            // Comprobar si es un proyectil rojo
            ProyectilRojo proyectilRojo = other.GetComponent<ProyectilRojo>();
            if (proyectilRojo != null)
            {
                // Si es proyectil rojo, restar puntos
                MarcadorPuntos.Instancia.RestarPunto();
            }
        }
    }
}
