using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    // codigo para cambiar de escenas
    // se comprimieron 3 scripts de cambio de escena en uno mismo 

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "puerta1")
        {
            SceneManager.LoadScene("level2");
        }

        if (other.gameObject.tag == "puerta3")
        {
            SceneManager.LoadScene("menu");
        }

        if (other.gameObject.tag == "puerta2")
        {
            SceneManager.LoadScene("level3");
        }

        if (other.gameObject.tag == "plataforma_de_muerte")
        {
            SceneManager.LoadScene("level3");
        }

    }
}
