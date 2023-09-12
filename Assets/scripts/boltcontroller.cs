using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltcontroller : MonoBehaviour
{
   public float shotspeed = 2;

    void Update()
    {
 
        Vector2 shotmove = new Vector2(0,shotspeed)*Time.deltaTime;
        transform.Translate(shotmove);
    if(Mathf.Abs(transform.position.y) > 8){
        Destroy(this.gameObject);
    }
    

}
private void OnTriggerEnter2D(Collider2D collider){
        Destroy(this.gameObject);
    }

}
