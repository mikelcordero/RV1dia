 using UnityEngine;

public class Sable : MonoBehaviour
{
    public MarcadorPuntos marcadorPuntos; // Asigna el marcador en Unity

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil")) // Si toca un proyectil
        {
            Debug.Log("Proyectil golpeado por el sable"); // Depuración
            Destroy(other.gameObject); // Destruye el proyectil
            marcadorPuntos.SumarPunto(); // Suma puntos
        }
    }
}
