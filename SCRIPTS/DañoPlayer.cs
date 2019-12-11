using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DañoPlayer : MonoBehaviour
//codigo para que el enemigo haga daño al jugador y redusca su vida en una cantidad de -10 en el caso del enemigo y -20 por parte del agente al llegar a 0 se rainicie el juego al nivel uno 
    
{
    Vida vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("Player").GetComponent<Vida>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "enemigo")
        {
            vidajugador.vida -= 10;
        }

        if (collision.gameObject.tag == "agente")
        {
            vidajugador.vida -= 20;
        }  

        if (vidajugador.vida == 0)
        {
            SceneManager.LoadScene( "level1");
        }

    }

}
