using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public Dropdown puntuacionDropdown;
    public Toggle dosSablesToggle;
    public SableControl sableControl;

    void Start()
    {
        // Opciones del menú
        puntuacionDropdown.ClearOptions();
        puntuacionDropdown.AddOptions(new List<string> { "10 puntos", "20 puntos", "30 puntos" });

        // Restaurar puntos al iniciar
        if (MarcadorPuntos.Instancia != null)
            MarcadorPuntos.Instancia.RestaurarPuntos();

        // Configura los sables al inicio
        CambiarNumeroDeSables();
    }

    public void CambiarPuntuacion()
    {
        int puntosSeleccionados = 0;

        switch (puntuacionDropdown.value)
        {
            case 0: puntosSeleccionados = 10; break;
            case 1: puntosSeleccionados = 20; break;
            case 2: puntosSeleccionados = 30; break;
        }

        if (MarcadorPuntos.Instancia != null)
            MarcadorPuntos.Instancia.SetPuntos(puntosSeleccionados);
    }

    public void CambiarNumeroDeSables()
    {
        sableControl.CambiarNumeroDeSables(dosSablesToggle.isOn);
    }

    // Llamar esto desde botón para cargar el nivel después de configurar el menú
    public void EmpezarNivel(string nombreEscena)
    {
        CambiarPuntuacion();
        CambiarNumeroDeSables();
        SceneManager.LoadScene(nombreEscena);
    }
}
