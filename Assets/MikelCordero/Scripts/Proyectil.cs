using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public bool esProyectilRojo = false; // Para saber si es un proyectil rojo
    public float velocidadProyectil = 3f; // Velocidad del proyectil
    private Rigidbody rb; // Rigidbody del proyectil
    private float tiempoVida = 5f; // Tiempo que tarda en destruirse si no colisiona
    private float temporizador = 2f; // Temporizador para destruir el proyectil

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Si tienes un Rigidbody, debes darle una velocidad inicial para que siga su camino
        Vector3 direccion = transform.forward; // Dirección hacia donde apunta el proyectil
        rb.velocity = direccion * velocidadProyectil;
    }

    void Update()
    {
        // Incrementar el temporizador
        temporizador += Time.deltaTime;

        // Si el proyectil ha estado en el juego más de `tiempoVida` segundos, lo destruimos
        if (temporizador >= tiempoVida)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Aquí puedes manejar las colisiones con el sable
        if (other.CompareTag("Sable"))
        {
            // Se destruye el proyectil al entrar en contacto con el sable
            Destroy(gameObject);
        }
    }
}
