using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float vidaActual = 1.0f; // Inicialmente a 1 para representar la vida completa
    public Image barraVida; // Asegúrate de asignar la referencia al objeto Image de la barra de vida en el Inspector

    void Start()
    {
        // Tu código de inicio, si es necesario
    }

    void Update()
    {
        // Tu código de actualización, si es necesario
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
