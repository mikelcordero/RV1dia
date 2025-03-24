using UnityEngine;

public class GeneradorProyectiles : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform jugador; // Asigna la posición del jugador
    public float distanciaSpawn = 5f;
    public float alturaMin = 1f;
    public float alturaMax = 3f;
    public float spawnIntervalo = 2f;

    void Start()
    {
        InvokeRepeating("SpawnProyectil", 2f, spawnIntervalo);
    }

    void SpawnProyectil()
    {
        // Generamos un offset aleatorio en X para que no siempre salga del centro
        float offsetX = Random.Range(-2f, 2f);  // Puedes ajustar el rango según necesites
        float altura = Random.Range(alturaMin, alturaMax);

        Vector3 spawnPos = jugador.position + jugador.forward * distanciaSpawn;
        spawnPos += new Vector3(offsetX, altura, 0); // Modifica la altura y lateralidad

        GameObject proyectil = Instantiate(proyectilPrefab, spawnPos, Quaternion.identity);
        proyectil.transform.LookAt(jugador); // Hace que apunte al jugador
        proyectil.GetComponent<Rigidbody>().velocity = (jugador.position - spawnPos).normalized * 5f; // Ajusta la velocidad
    }
}
