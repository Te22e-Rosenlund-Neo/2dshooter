using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class enemygridmovement : MonoBehaviour
{
    [SerializeField] float enemyoffsetX = 1f;
    [SerializeField] float enemyoffsetY = 1f;
    [SerializeField] GameObject enemy;
    [SerializeField] string BorderTag; 

    public float enemynumb;
    // Start is called before the first frame update
    void Awake()
    {
        if(menu.scene == 1){
        Spawnnew1();
    }
    


    }

    // Update is called once per frame
    void Update()
    {           
  

    }

    public void Spawnnew1(){
        for(int i=0; i<3; i++){

            for(int j=0; j<6; j++){
                Instantiate(enemy, new Vector2(transform.position.x + (enemyoffsetX*j), transform.position.y - (enemyoffsetY*i)), Quaternion.identity);
            }
        }
    }




    }

