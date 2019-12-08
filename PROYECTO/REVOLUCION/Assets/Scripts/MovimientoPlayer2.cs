using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer2 : MonoBehaviour
{
    float velocidad = 250f;
    private Animator anim;
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
            anim.SetFloat("valocidad", velocidad);
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
        }
    }
}
