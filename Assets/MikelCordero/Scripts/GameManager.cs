using UnityEngine;
using UnityEngine.SceneManagement; // Si estás cambiando de escenas

public class GameManager : MonoBehaviour
{
    public void CargarNivel(string nivelSeleccionado)
    {
        // Aquí puedes definir qué hacer según el nivel seleccionado
        if (nivelSeleccionado == "Nivel 1")
        {
            // Cargar el nivel 1 (si estás usando escenas)
            SceneManager.LoadScene("Nivel1"); // Nombre de la escena
        }
        else if (nivelSeleccionado == "Nivel 2")
        {
            SceneManager.LoadScene("Nivel2"); // Nombre de la escena
        }
        else if (nivelSeleccionado == "Nivel 3")
        {
            SceneManager.LoadScene("Nivel3"); // Nombre de la escena
        }

        // Si no estás usando escenas, puedes cambiar la lógica para cargar el nivel de otra forma.
    }
}


