using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Score : MonoBehaviour
{
  public TextMeshProUGUI Scoretext; 

 void Update() {
    
Scoretext.text = Convert.ToString(enemyscript.score);

}





}
