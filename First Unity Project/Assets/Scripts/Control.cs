using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    
    private Vector3 direction;
    private Vector3 direction2;
    

    private void Start()
    {

    }




    private void Update()
    {

        direction = new Vector3(1f, 0f, 0f);
        direction2 = new Vector3(-1f, 0f, 0f);


        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Transform>().Rotate(direction);
            //GetComponent<Light>().intensity = 100f;
        }
        else
        {

            GetComponent<Transform>().Rotate(new Vector3(0f, 0f, 0f));
            //GetComponent<Light>().intensity = 1f;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            GetComponent<Transform>().Rotate(direction2);
            //GetComponent<Light>().intensity = 100f;
        }
        else
        {

            GetComponent<Transform>().Rotate(new Vector3(0f, 0f, 0f));
            //GetComponent<Light>().intensity = 1f;
        }

        if (Input.GetMouseButton(0))
        {
            GetComponent<Light>().intensity = 50f;
        }
        else
        {
            GetComponent<Light>().intensity = 1f;
        }


        //GetComponent<Transform>().Rotate(direction);

        //GetComponent<Transform>().Translate(direction);


        //rb.velocity = direction*5;


        //pos = new Vector3(-0.47f, 2.14f, -3.9f);
        //rb.MovePosition(pos);

        
    }

}

