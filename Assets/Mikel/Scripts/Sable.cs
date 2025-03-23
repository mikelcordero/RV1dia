using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sable : MonoBehaviour
{
    public MarcadorPuntos marcador; // Asignar el marcador en el inspector
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil")) // Si el sable toca un proyectil
        {
            Destroy(other.gameObject); // Destruye el proyectil
            marcador.SumarPunto(); // Suma un punto
        }
    }
}
