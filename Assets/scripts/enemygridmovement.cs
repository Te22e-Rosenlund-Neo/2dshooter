using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class enemygridmovement : MonoBehaviour
{
    [SerializeField] float enemyoffsetX = 1f;
    [SerializeField] float enemyoffsetY = 1f;
    [SerializeField] GameObject enemy;
    [SerializeField] string BorderTag; 
    // Start is called before the first frame update
    void Start()
    {
        Spawnnew();
    


    }

    // Update is called once per frame
    void Update()
    {





    }

    void Spawnnew(){
        for(int i=0; i<3; i++){

            for(int j=0; j<6; j++){
                Instantiate(enemy, new Vector2(transform.position.x + (enemyoffsetX*j), transform.position.y - (enemyoffsetY*i)), Quaternion.identity);
            }
        }
    }

/*private void OnTriggerEnter2D(Collider2D collider)
    {
        if (BorderTag == collider.tag)
        {
            collider.gameObject.GetComponent<enemyscript>().Movenemy();
            Debug.Log("I hit the side");
        }
    }

*/


    }

