using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer2 : MonoBehaviour
{
    //codigo para que el jugador se pueda mover adelante,atras,arriba y abajo a una cierta velocidad presionando las teclas de las flechas
    //se le agrago un condicionante de animator para que con determinadas teclas se efectue una animacion

    public float velocidad = 250f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
            anim.SetBool("caminar_izq", true);
        }
        else
        {
            anim.SetBool("caminar_izq", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
            anim.SetBool("caminar", true);
        }
        else
        {
            anim.SetBool("caminar", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
            anim.SetBool("piso", false);

        }
        else
        {
            anim.SetBool("piso", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
        }
      
    }
}
  