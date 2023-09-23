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
bool gameoverpossible = false;

int counter;
public static bool TempDisablegameover = false;

    void Awake()
    {
        
    }


    void Update()
    {
        if(TempDisablegameover==true){
            counter++;
        }
    if(counter >= 120){
        gameoverpossible = true;
    }
    if(enemyscript.count <= 0){
         SceneManager.LoadScene(1);
        ammodifference +=10;
    }   

    if(Shipcontroll.playerhealth<=0 || Shipcontroll.playerammodisplay <= 0){
        if(gameoverpossible == true){
    
        gameendtext.text =$"Gameover! \n\n Score: {enemyscript.score} ";
        
    }
}
}
}
