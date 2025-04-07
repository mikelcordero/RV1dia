using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarcadorPuntos : MonoBehaviour
{
    public TextMeshPro marcadorTexto;
    public Transform muroMarcador;
    private int puntos = 0;

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

    void ActualizarMarcador()
    {
        marcadorTexto.text = "Puntos: " + puntos;
    }
}
