
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

[SerializeField] GameObject bolt;
[SerializeField] GameObject explosion;
[SerializeField] string BoltTag;
int Ehealth = 6;

public int enemymovementspeed = 5;

public double shottimer;

    void Update()
    {
      
 Vector2 enemymovement = new Vector2(enemymovementspeed,0) * Time.deltaTime;

        transform.Translate(enemymovement);
        if(Mathf.Abs(transform.position.x) >= 9.5){
            enemymovementspeed *=-1;
        }
        
        shottimer++;
        if (shottimer >= Random.Range(500, 2500))
        {
            shottimer = 0;
            Instantiate(bolt, transform.position, Quaternion.identity);
        }


         
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (BoltTag == collider.tag)
        {
            Ehealth--;
             Destroy(collider.gameObject);
            if (Ehealth == 0)
            {
                Destroy(this.gameObject);
                Instantiate(explosion, transform.position, Quaternion.identity);
               
                //collider.gameObject.GetComponent<boltcontroller>().Boltdestroy();  other version of sams ugly code
            }
        }
    }
}


