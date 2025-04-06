using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public Dropdown dropdownPuntos;
    public Toggle toggleSables;

    public void IniciarNivelFacil()
    {
        GuardarConfiguracion();
        ConfiguracionJuego.instancia.nivelDificil = false;
        SceneManager.LoadScene("NivelFacil");
    }

    public void IniciarNivelDificil()
    {
        GuardarConfiguracion();
        ConfiguracionJuego.instancia.nivelDificil = true;
        SceneManager.LoadScene("NivelDificil");
    }

    void GuardarConfiguracion()
    {
        int puntos = int.Parse(dropdownPuntos.options[dropdownPuntos.value].text);
        ConfiguracionJuego.instancia.puntosObjetivo = puntos;
        ConfiguracionJuego.instancia.dobleSable = toggleSables.isOn;
    }
}
