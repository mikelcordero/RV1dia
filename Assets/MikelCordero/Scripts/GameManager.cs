using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int puntosObjetivo = 10;
    public bool sableDoble = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        } 
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void EstablecerPuntosObjetivo(int valor)
    {
        puntosObjetivo = valor;
    }

    public void EstablecerSableDoble(bool valor)
    {
        sableDoble = valor;
    }
}

