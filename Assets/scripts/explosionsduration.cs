using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionsduration : MonoBehaviour
{
int duration;

    void Update()
    {
      duration++;

        if(duration == 60){
            Destroy(this.gameObject);
        }
    }
}
