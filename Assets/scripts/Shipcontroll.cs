using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class Shipcontroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       float speed = 6; //rutor per sekund

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movementx = new Vector2(speed,0) * moveX * Time.deltaTime;
        Vector2 movementy = new Vector2(0, speed) * moveY * Time.deltaTime;
        
        transform.Translate(movementx); 
        transform.Translate(movementy);

        if(Mathf.Abs(transform.position.x) > 9.9f){
            transform.Translate(-movementx);
        }
        if(Math.Abs(transform.position.y) > 4.9f){
            transform.Translate(-movementy);
        }


        
    }
}
