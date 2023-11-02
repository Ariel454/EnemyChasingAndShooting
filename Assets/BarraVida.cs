using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public GameObject textoGameOverParent;
    public TMPro.TextMeshProUGUI TextoGameOver;
    public float vidaTotal = 1.0f; // Total de vida

    float vidaActual; // Variable para almacenar la vida actual
    private int disparosRestantes = 10; // Número de disparos restantes antes de quedarse sin vida
    public Image barraVida; // Asegúrate de asignar la referencia al objeto Image de la barra de vida en el Inspector

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala")) // Ajusta la etiqueta de las balas
        {
            RecibirDanio();
        }
    }



    void RecibirDanio()
    {
        if (disparosRestantes > 0)
        {
            float reduccionPorDisparo = vidaTotal / 10.0f; // Calcula la cantidad de reducción por disparo
            vidaActual -= reduccionPorDisparo; // Reduce la vida
            disparosRestantes--;

            ActualizarBarraVida(); // Actualiza la barra de vida

            if (vidaActual <= 0)
            {
                MostrarTextoGameOver(); // Mostrar Game Over solo si la vida se ha agotado
            }
        }
    }

    void ActualizarBarraVida()
    {
        // Calcula el valor de la barra de vida después de recibir daño
        float nuevoValorBarra = vidaActual / vidaTotal;

        // Actualiza la barra de vida visualmente
        barraVida.fillAmount = nuevoValorBarra;
    }

    void MostrarTextoGameOver()
    {
        // Activa el objeto de juego que contiene el TextMeshProUGUI
        textoGameOverParent.SetActive(true);

        // Pausa el juego
        Time.timeScale = 0f;
    }
}
