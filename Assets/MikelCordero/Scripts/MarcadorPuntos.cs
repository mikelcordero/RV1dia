using UnityEngine;
using TMPro;

public class MarcadorPuntos : MonoBehaviour
{
    // Instancia estática para acceder a la clase desde otros scripts
    public static MarcadorPuntos Instancia;

    public TextMeshPro marcadorTexto;
    public Transform muroMarcador;
    private int puntos = 0;

    void Awake()
    {
        // Verificar que no haya más de una instancia de MarcadorPuntos en la escena
        if (Instancia != null && Instancia != this)
        {
            Destroy(gameObject); // Destruir este objeto si ya hay otra instancia
        }
        else
        {
            Instancia = this; // Asignar la instancia estática
        }
    }

    void Start()
    {
        ActualizarMarcador();
    }

    public void SumarPunto()
    {
        puntos++;
        ActualizarMarcador();

        if (puntos >= 20)
        {
            marcadorTexto.text = "¡GANASTE!";
        }
    }

    // Método para restar un punto
    public void RestarPunto()
    {
        puntos--;
        if (puntos < 0) puntos = 0; // Evitar que los puntos sean negativos
        ActualizarMarcador();
    }

    // Método para obtener el puntaje actual (para depuración)
    public int GetPuntos()
    {
        return puntos;
    }

    void Update()
    {
        marcadorTexto.transform.position = muroMarcador.position;
        marcadorTexto.transform.rotation = muroMarcador.rotation;
    }

    // Método privado para actualizar el marcador
    private void ActualizarMarcador()
    {
        marcadorTexto.text = "Puntos: " + puntos;
    }
}
