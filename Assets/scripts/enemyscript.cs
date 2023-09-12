using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    
     [SerializeField]
GameObject bolt;

    void Update()
    {
        
       Instantiate(bolt, this.transform.position, Quaternion.identity);



    }
}
