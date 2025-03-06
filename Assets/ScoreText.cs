using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject[] blocks;

    // Start é chamado uma vez antes da primeira execução do Update após o MonoBehaviour ser criado
    void Start()
    {
        blocks = GameManager.instance.gos;
        
    }

    // Update é chamado a cada quadro
    void Update()
    {   
        Scene scene = SceneManager.GetActiveScene();
        // Atualiza o texto do placar
        scoreText.text = "Score: " + GameManager.instance.score.ToString("0");

        // Verifica se está na Cena_3
        if (scene.name == "Cena_3")
        {
            // Verifica se não há blocos restantes
            if (blocks.Length == 1) // Usando 'Length' diretamente aqui
            { 
                scoreText.text = "Score: " + GameManager.instance.score.ToString("0") + "\nVocê ganhou !!"; 
            }
            else
            {
                // Exibe o número de blocos restantes
                print(blocks.Length);
                scoreText.text = "Score: " + GameManager.instance.score.ToString("0") + "\nVocê perdeu !!";
            }
        }
    }
}
