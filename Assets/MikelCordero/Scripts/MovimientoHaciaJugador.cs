using UnityEngine;

public class MovimientoHaciaJugador : MonoBehaviour
{
    public float velocidad = 2f;
    private Transform objetivo;

    void Start()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");

        if (jugador != null)
        {
            objetivo = jugador.transform;
        }
        else
        {
            Debug.LogError("No se encontró ningún objeto con el tag 'Player'.");
        }
    }

    void Update()
    {
        if (objetivo != null)
        {
            // Calcular la dirección hacia el jugador
            Vector3 direccion = (objetivo.position - transform.position).normalized;

            // Mover el objeto hacia el jugador
            transform.position += direccion * velocidad * Time.deltaTime;
        }
    }
}
