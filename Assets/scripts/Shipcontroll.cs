using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shipcontroll : MonoBehaviour
{
[SerializeField] GameObject bolt;
[SerializeField] GameObject explosion;
[SerializeField] string EnemyBoltTag;

[SerializeField] Image[] livesUI;
 public static int playerhealth= 5;

[SerializeField] public static int playerammodisplay;
[SerializeField] public int playerammo = 80;


    void Update()
    {
        playerammodisplay = playerammo;
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
        if(Input.GetKeyDown(KeyCode.Space) && playerammo>0){
            Instantiate(bolt, this.transform.position, Quaternion.identity);
            playerammo--;
        }
        

        

      


    }
 private void OnTriggerEnter2D(Collider2D collider)
    {
            if (EnemyBoltTag == collider.tag){
            playerhealth--;
           Destroy(collider.gameObject);

           for(int i=0; i<livesUI.Length;i++){
            if(i<playerhealth){
                livesUI[i].enabled = true;
            }
            else{
                livesUI[i].enabled = false;
            }
           }

        }   
            if(playerhealth <= 0){
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            SceneManager.LoadScene(2);
         }
}
}






/*
-list of things to have to make this a game 
-score



*/

/*_ timer function

[seralizefield]
Float TimeBetweenShots = 0.5f;
float TimeSinceLastShot = 0;

void update(){

TimeSinceLastShot += Time.deltaTime;

if(Input.GetAxisRaw("Fire1") > 0 && TimeSinceLastShot == TimeBetweenShots){
    shoot();
    TimeSinceLastShot = 0;
}


}
*/