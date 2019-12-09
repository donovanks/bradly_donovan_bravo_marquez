using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer2 : MonoBehaviour
{
    float velocidad = 250f;
    private Animator anim;
    CharacterController characterController;
    bool piso;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
            anim.SetFloat("velocidad", 0.1f);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
           
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
            anim.SetBool("piso", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
            
        }
        
    }
}
