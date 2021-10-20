using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mov_PersonPrinc : MonoBehaviour
{
    private Rigidbody Rigidbody;
    public float vel=10;
    private bool confSalt=false;
    public float jumpForce=5.0f;
    //public float gravedad = 10;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
//////////////////////////////////
    void Move(){
        var adel_atras=Input.GetAxis("Vertical");   //z
        var der_izq=Input.GetAxis("Horizontal");   //x
          //var camera=GetMouse() #Intento Mouse
        //print(vert);

        Rigidbody.velocity = new Vector3(
            der_izq*vel,
            Rigidbody.velocity.y,
            adel_atras*vel);
        Salto();
    }
    void Salto(){
        confSalt=Input.GetButtonDown("Jump");
        if(confSalt){
            Rigidbody.AddForce(new Vector3(0,jumpForce,0),ForceMode.Impulse);
        }
    }

    
}
