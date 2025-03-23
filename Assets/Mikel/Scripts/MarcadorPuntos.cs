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
