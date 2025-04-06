using UnityEngine;

public class GeneradorProyectiles : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform jugador; // Cámara o XR Rig
    public float distanciaSpawn = 5f;
    public float spawnIntervalo = 2f;
    public float velocidadProyectil = 5f;

    void Start()
    {
        InvokeRepeating("SpawnProyectil", 2f, spawnIntervalo);
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

        // Crear proyectil
        GameObject proyectil = Instantiate(proyectilPrefab, spawnPos, Quaternion.identity);

        // Dirección hacia el jugador (para que venga hacia él)
        Vector3 direccion = (jugador.position - spawnPos).normalized;

        // Mover proyectil con física
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        rb.velocity = direccion * velocidadProyectil;
    }
}
