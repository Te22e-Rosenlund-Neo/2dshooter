using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomberScript : MonoBehaviour
{

    [SerializeField] GameObject Raybeam;
    [SerializeField] GameObject explosion;
    [SerializeField] string BoltTag;
    [SerializeField] string BorderTag;
    int Ehealth = 6;

    public int enemymovementspeed = 5;

    


    private void Start()
    {
        enemyscript.count++;
        InvokeRepeating("shoot", Random.Range(8, 16), 3f);
    }
    void Update()
    {

        Vector2 enemymovement = new Vector2(enemymovementspeed, 0) * Time.deltaTime;

        transform.Translate(enemymovement);



    }

    void shoot()
    {
        Instantiate(Raybeam, transform.position, Quaternion.identity);
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
        enemyscript.count--;
    }
}
