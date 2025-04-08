using UnityEngine;

public class GeneradorProyectiles : MonoBehaviour
{
    public GameObject proyectilPrefab;      // Prefab de proyectil normal
    public GameObject proyectilRojoPrefab; // Prefab de proyectil rojo
    public Transform jugador;              // Transform del jugador (Cámara o XR Rig)
    public float distanciaSpawn = 5f;      // Distancia para spawn de los proyectiles
    public float spawnIntervalo = 2f;      // Intervalo entre spawn de proyectiles
    public float velocidadProyectil = 5f;  // Velocidad del proyectil

    void Start()
    {
        InvokeRepeating("SpawnProyectil", 2f, spawnIntervalo); // Llamar a la función para spawnear proyectiles
    }

    void SpawnProyectil()
    {
        // Dirección del jugador
        Vector3 forward = jugador.forward.normalized;
        Vector3 right = jugador.right.normalized;

        // Offset lateral aleatorio (izquierda, centro, derecha)
        float[] offsetOpciones = { -1.5f, 0f, 1.5f };
        float offsetLateral = offsetOpciones[Random.Range(0, offsetOpciones.Length)];

        // POSICIÓN: a 'distanciaSpawn' en dirección a donde mira el jugador + offset lateral
        Vector3 spawnPos = jugador.position + forward * distanciaSpawn + right * offsetLateral;

        // Generar un proyectil con 50% de probabilidad que sea rojo
        GameObject proyectil;
        if (Random.value > 0.5f) // 50% de probabilidad
        {
            proyectil = Instantiate(proyectilRojoPrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            proyectil = Instantiate(proyectilPrefab, spawnPos, Quaternion.identity);
        }

        // Dirección hacia el jugador (para que venga hacia él)
        Vector3 direccion = (jugador.position - spawnPos).normalized;

        // Mover proyectil con física
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        rb.velocity = direccion * velocidadProyectil;
    }
}
