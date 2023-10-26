using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CuboPerseguidor : MonoBehaviour
{
    public Transform player; // Referencia al objeto que el cubo debe perseguir
    private NavMeshAgent agente;

    public float vidaActual = 1.0f; // Inicialmente a 1 para representar la vida completa

    public Image barraVida;

    public Transform puntoDisparoCabeza;

    public GameObject bolaPrefab;
    public float velocidadDisparo = 10.0f;
    public float tiempoVidaBola = 3.0f; // Tiempo de vida de las bolas en segundos

    public float intervaloDisparo = 1.0f; // Tiempo en segundos entre disparos
    private float tiempoUltimoDisparo = 0.0f;

    public int puntosDeVida = 100;



    
    private void Awake()
    {
        player = GameObject.Find("PlayerObj").transform;
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agente.SetDestination(player.position);
            if (Time.time - tiempoUltimoDisparo >= intervaloDisparo)
    {
        Disparar();
        tiempoUltimoDisparo = Time.time;
    }
    }

    private void Patroling()
    {
    }

    void Disparar()
    {
        GameObject bola = Instantiate(bolaPrefab, puntoDisparoCabeza.position, puntoDisparoCabeza.rotation);
        Rigidbody rb = bola.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 direction = (player.position - puntoDisparoCabeza.position).normalized;
            rb.velocity = direction * velocidadDisparo;
        }

        // Destruye la bola después del tiempo de vida especificado
        Destroy(bola, tiempoVidaBola);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala")) // Ajusta la etiqueta de las balas
        {
            RecibirDanio();
        }
    }


    void RecibirDanio()
    {
        vidaActual -= 0.1f; // Restar 0.1 a la vida actual

        // Calcular el valor de la barra de vida después de recibir daño
        float nuevoValorBarra = vidaActual / 1.0f; // 1.0f representa la vida completa

        // Actualizar la barra de vida visualmente con interpolación (lerp)
        barraVida.fillAmount = Mathf.Lerp(barraVida.fillAmount, nuevoValorBarra, Time.deltaTime * 5); // Ajusta el valor 5 según la velocidad de la interpolación que desees

        if (vidaActual <= 0)
        {
            // Aquí puedes hacer que el juego se detenga o que el personaje muera.
        }
    }





}
