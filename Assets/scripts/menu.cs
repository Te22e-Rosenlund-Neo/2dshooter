

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
    public static int scene=0;
    
void Start(){

  
}
void Update(){
    BulletText.text = Convert.ToString(Shipcontroll.playerammodisplay);




}
     public void OnPlayButton(){
        SceneManager.LoadSceneAsync(1);
        scene = 1;
     }

     public void OnQuitButton(){
         Application.Quit();
     }
 
}