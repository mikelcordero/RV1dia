using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public Dropdown dropdownPuntos; // Combobox para elegir puntos
    public Toggle toggleSables; // Toggle para elegir sable único o doble

    public void Start()
    {
        // Cargar las configuraciones previas, si existen
        int puntosGuardados = PlayerPrefs.GetInt("PuntosObjetivo", 10);
        dropdownPuntos.value = (puntosGuardados - 10) / 10; // Ajuste del valor guardado en el dropdown
        toggleSables.isOn = PlayerPrefs.GetInt("SableDoble", 0) == 1; // Cargar la opción de sable doble
    }

    public void CambiarPuntosObjetivo()
    {
        // Guardar la opción seleccionada para puntos
        int puntos = (dropdownPuntos.value + 1) * 10;
        PlayerPrefs.SetInt("PuntosObjetivo", puntos);
        PlayerPrefs.Save();
    }

    public void CambiarTipoSable()
    {
        // Guardar si el jugador elige sable doble o no
        PlayerPrefs.SetInt("SableDoble", toggleSables.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void CargarEscena(string escena)
    {
        SceneManager.LoadScene(escena); // Cambiar a las escenas de Nivel
    }
}