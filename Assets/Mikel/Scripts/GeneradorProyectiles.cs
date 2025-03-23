using UnityEngine;
using System.Collections;

public class GeneradorProyectiles : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform jugador; // Asigna "XR Origin" aquí
    public float distanciaInstanciacion = 5f;
    public float tiempoEntreProyectiles = 2f;

    void Start()
    {
        StartCoroutine(GenerarProyectiles());
    }

    IEnumerator GenerarProyectiles()
{
    while (true)
    {
        Vector3 posicionProyectil = jugador.position + (jugador.forward * distanciaInstanciacion);

        // Ajustar altura al nivel de los ojos del jugador
        posicionProyectil.y = jugador.position.y;  

        // Agregar un ligero offset aleatorio en X para mejorar jugabilidad
        posicionProyectil += new Vector3(Random.Range(-1f, 1f), 0, 0);

        GameObject proyectil = Instantiate(proyectilPrefab, posicionProyectil, Quaternion.identity);
        proyectil.transform.LookAt(jugador.position + Vector3.up * 1.5f); // Apuntar un poco más alto
        proyectil.AddComponent<Proyectil>(); // Le agregamos el script de movimiento

        yield return new WaitForSeconds(tiempoEntreProyectiles);
    }
}

}
