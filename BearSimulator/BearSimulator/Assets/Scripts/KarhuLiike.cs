using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarhuLiike : MonoBehaviour
{

    CharacterController karhukontrolleri;

    Animation karhuanimaatiot;
    
    Vector3 pelaajamaanvetovoima;

    float maanvetovoima = -9.81f;

    //float hyppyvoima = 1.0f;

    bool pelaajaonmaassa;



    void Start()
    {
        karhukontrolleri = GetComponent<CharacterController>();
        karhuanimaatiot = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //float sivuttaisliike = Input.GetAxis("Horizontal");
        float sivuttaisliike = CustomController.Gethorizontal();
        transform.Rotate(0f,sivuttaisliike*2,0f);

        pelaajaonmaassa = karhukontrolleri.isGrounded;
        if(pelaajaonmaassa && pelaajamaanvetovoima.y < 0)
        {
            pelaajamaanvetovoima.y = 0f;
        }


        //float eteenpainliike = Input.GetAxis("Vertical");
        float eteenpainliike = CustomController.Getvertical();
        if (eteenpainliike == 0f)
        {
            karhuanimaatiot.Play("Idle Loop");
        }
        else
        {
            karhuanimaatiot.Play("Run Loop");
        }

        //transform.position = transform.position+(Vector3.forward*0.01f*eteenpainliike);
        karhukontrolleri.Move(transform.forward*0.2f*eteenpainliike);

        pelaajamaanvetovoima.y += maanvetovoima*Time.deltaTime;
        karhukontrolleri.Move(pelaajamaanvetovoima*Time.deltaTime);
    }
}
