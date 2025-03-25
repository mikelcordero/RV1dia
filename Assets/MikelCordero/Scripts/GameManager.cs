using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI puntosTexto;
    private int puntos = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SumarPunto()
    {
        puntos++;
        puntosTexto.text = "Puntos: " + puntos;

        if (puntos >= 20)
        {
            FinDelJuego();
        }
    }

    void FinDelJuego()
    {
        Debug.Log("¡Has ganado!");
        Time.timeScale = 0; // Pausa el juego
    }
}
