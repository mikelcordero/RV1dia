using UnityEngine;

public class ProyectilRojo : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad del proyectil
    private Vector3 direccion;

    void Start()
    {
        // Encontrar al jugador
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");

        if (jugador != null)
        {
            // Calcular dirección EXACTA al jugador (posición de su cabeza)
            Vector3 posicionJugador = jugador.transform.position;
            posicionJugador.y += 1.5f; // Ajustamos altura para apuntar al torso/cabeza
            direccion = (posicionJugador - transform.position).normalized;
        }
        else
        {
            Debug.LogError("No se encontró el objeto con la etiqueta 'Player'.");
            direccion = Vector3.forward; // Movimiento por defecto
        }
    }

    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }

    // Método para manejar las colisiones
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player")) // Si colisiona con el jugador
        {
            // Buscar el componente MarcadorPuntos en el jugador
            MarcadorPuntos marcador = col.gameObject.GetComponent<MarcadorPuntos>();
            
            if (marcador != null)
            {
                // Restar un punto al marcador
                marcador.RestarPunto();
                Debug.Log("¡Punto Restado! Puntos: " + marcador.GetPuntos());
            }
            else
            {
                Debug.LogError("No se encontró el componente MarcadorPuntos en el jugador.");
            }

            // Destruir el proyectil rojo
            Destroy(gameObject);
        }
    }
}
