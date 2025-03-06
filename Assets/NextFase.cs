using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextFase : MonoBehaviour
{
    public GameObject[] blocks_fase;

    void Start(){
        // Acessa os blocos da fase através do GameManager
        blocks_fase = GameManager.instance.gos;
    }

    // Função para carregar a próxima cena
    public void next(){
        // Imprime a quantidade de blocos restantes
        print(blocks_fase.Length);
        
        // Obtém a cena ativa atual
        Scene currentScene = SceneManager.GetActiveScene();

        // Verifica se a quantidade de blocos restantes é 1
        if(blocks_fase.Length == 1)
        {   
            // Se a cena atual for "Cena_4", vai para "Cena_1"
            if(currentScene.name == "Cena_4"){
                SceneManager.LoadScene("Cena_1");
            }
            else{ 
                // Caso contrário, vai para "Cena_4"
                SceneManager.LoadScene("Cena_4");
            }
        }
        else
        {
            // Se ainda houver blocos, carrega "Cena_1"
            SceneManager.LoadScene("Cena_1");
        }
    }
}
