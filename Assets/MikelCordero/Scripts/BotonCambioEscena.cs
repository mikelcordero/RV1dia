using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCambioEscena : MonoBehaviour
{
    public void CargarNivelFacil()
    {
        Debug.Log("Cargando escena: nivelfacil");
        SceneManager.LoadScene("nivelfacil");
    }

    public void CargarNivelComplicado()
    {
        Debug.Log("Cargando escena: NivelComplicado");
        SceneManager.LoadScene("nivelcomplicado");
    }
}
