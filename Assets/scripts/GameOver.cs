using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;
public class GameOver : MonoBehaviour
{
public TextMeshProUGUI gameendtext;
public static int ammodifference;
    void Start()
    {
 
    }


    void Update()
    {
    if(enemyscript.count <= 0){

         SceneManager.LoadScene(1);
        ammodifference +=10;
    }   

    if(Shipcontroll.playerhealth<=0 || Shipcontroll.playerammodisplay <= 0){
        gameendtext.text =$"Gameover! \n Score: {enemyscript.score} ";
  
    }
}
}
