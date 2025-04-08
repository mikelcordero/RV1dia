using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarcadorPuntos : MonoBehaviour
{
    public static MarcadorPuntos Instancia;

    public TextMeshPro marcadorTexto;
    public Transform muroMarcador;

    private int puntos = 0;
    public int puntosParaGanar = 20;

    void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject); // Mantener al cambiar de escena
        }
        else
        {
            Destroy(gameObject);
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

        if (puntos >= puntosParaGanar)
        {
            marcadorTexto.text = "¡GANASTE!";
        }
    }

    public void RestarPunto()
    {
        puntos--;
        if (puntos < 0) puntos = 0;
        ActualizarMarcador();
    }

    public void SetPuntos(int nuevosPuntosParaGanar)
    {
        puntosParaGanar = nuevosPuntosParaGanar;
        puntos = 0;
        ActualizarMarcador();
    }

    public void RestaurarPuntos()
    {
        puntos = 0;
        ActualizarMarcador();
    }

    void Update()
    {
        if (marcadorTexto != null && muroMarcador != null)
        {
            marcadorTexto.transform.position = muroMarcador.position;
            marcadorTexto.transform.rotation = muroMarcador.rotation;
        }
    }

    void ActualizarMarcador()
    {
        marcadorTexto.text = "Puntos: " + puntos;
    }
}
