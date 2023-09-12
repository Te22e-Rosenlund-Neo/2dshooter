using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class Shipcontroll : MonoBehaviour
{
    [SerializeField]
GameObject bolt;
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
        if(Math.Abs(transform.position.y) > 4.5f){
            transform.Translate(-movementy);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bolt, this.transform.position, Quaternion.identity);
        }



    }
}


/*
-list of things to have to make this a game 
-fiender
-liv
-score
-menu
-shot barriers (kills the shot instance when outside play area)


*/