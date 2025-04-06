using UnityEngine;

public class ConfiguracionJuego : MonoBehaviour
{
    public static ConfiguracionJuego instancia;

    public int puntosObjetivo = 20;
    public bool dobleSable = true;
    public bool nivelDificil = false;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // Persiste entre escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }
}