
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class enemyscript : MonoBehaviour
{
    
     [SerializeField]
GameObject bolt;

    [SerializeField]
GameObject explosion;


  int Ehealth;
void Start(){
    Ehealth = UnityEngine.Random.Range(1,11);
}


    void Update()
    {


    }
private void OnTriggerEnter2D(Collider2D collider){
    Ehealth--;
       if(Ehealth==0)
       {
         Destroy(this.gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}


