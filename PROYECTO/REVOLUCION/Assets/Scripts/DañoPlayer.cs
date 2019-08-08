﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoPlayer : MonoBehaviour
{
    Vida vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("Player").GetComponent<Vida>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            vidajugador.vida -= 10;
        }
    }
}
