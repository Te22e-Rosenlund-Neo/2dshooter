using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int counter;
    void Start()
    {
   text = FindObjectOfType<TextMeshProUGUI>();
    }


    void Update()
    {
         counter++;
 if(counter == 1080){
     SceneManager.LoadScene(0);
}




 if(enemyscript.count <= 0){
            text.text="You win!";

        }

if(Shipcontroll.playerhealth <= 0){
    text.text="Game over!";
}
    }
}
