

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public TextMeshProUGUI BulletText;
    
void Start(){
     BulletText = FindObjectOfType<TextMeshProUGUI>();
}
void Update(){
    BulletText.text = Convert.ToString(Shipcontroll.playerammodisplay);
}

     public void OnPlayButton(){
        SceneManager.LoadScene(1);
     }

     public void OnQuitButton(){
         Application.Quit();
     }
 
}