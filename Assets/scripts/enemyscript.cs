
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyscript : MonoBehaviour
{
    public static int score;
    public static int count = 0;

    [SerializeField] GameObject bolt;
    [SerializeField] GameObject explosion;
    [SerializeField] string BoltTag;
    [SerializeField] string BorderTag;
    int Ehealth = 2;
    public  AudioClip sfx1;
    public int enemymovementspeed = 5;

   


    private void Start()
    {
       
        count++;
        InvokeRepeating("shoot", Random.Range(4, 10), 3f);
    }
    void Update()
    {

        Vector2 enemymovement = new Vector2(enemymovementspeed, 0) * Time.deltaTime;

        transform.Translate(enemymovement);



    }

    void shoot()
    {
        Instantiate(bolt, transform.position, Quaternion.Euler(0, 0, 180));
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (BoltTag == collider.tag)
        {
            Ehealth--;
            score+=50;
            Destroy(collider.gameObject);
            if (Ehealth == 0)
            {
                SfxDeath();
                Destroy(this.gameObject);
                Instantiate(explosion, transform.position, Quaternion.identity);
                Die();
               
                
                
                
                //collider.gameObject.GetComponent<boltcontroller>().Boltdestroy();  other version of sams ugly code
            }
        }
        if (BorderTag == collider.tag)
        {
            MoveEnemy();
        }
    }

    public void MoveEnemy()
    {
        enemymovementspeed *= -1;
        Vector2 enemymovement = new Vector2(0, -1);
        transform.Translate(enemymovement);
    }

    private void Die()
    {
        count--;
    }

public void SfxDeath(){
      AudioSource.PlayClipAtPoint(sfx1, new Vector2(0, 0));
}




}


