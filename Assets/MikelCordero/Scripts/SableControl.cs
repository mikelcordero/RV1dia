using UnityEngine;

public class SableControl : MonoBehaviour
{
    public GameObject sableUno; // El sable de la mano izquierda
    public GameObject sableDos; // El sable de la mano derecha

    public void CambiarNumeroDeSables(bool usarDosSables)
    {
        sableUno.SetActive(true); // Siempre está activo el primero
        sableDos.SetActive(usarDosSables); // El segundo depende del toggle
    }
}
