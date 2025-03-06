using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void jogar(){
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Cena_5"){
            UnityEngine.SceneManagement.SceneManager.LoadScene( "Cena_1");
        }else{
            UnityEngine.SceneManagement.SceneManager.LoadScene( "Cena_2");
        }
        
    }
}