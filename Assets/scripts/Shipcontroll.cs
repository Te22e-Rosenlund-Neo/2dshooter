using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class Shipcontroll : MonoBehaviour
{
[SerializeField] GameObject bolt;
[SerializeField] GameObject explosion;
[SerializeField] string EnemyBoltTag;
 int playerhealth= 6;



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
 private void OnTriggerEnter2D(Collider2D collider)
    {
            if (EnemyBoltTag == collider.tag){
            playerhealth--;
           Destroy(collider.gameObject);
        }   
            if(playerhealth == 0){
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);;
            Debug.Break();
         }
}
}






/*
-list of things to have to make this a game 
-fiender
-liv
-score
-menu


*/