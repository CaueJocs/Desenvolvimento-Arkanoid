using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public enum GameState {Stop, Play, Win, GameOver, Pause};

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    public GameObject Ball;
    [SerializeField]
    public GameObject Player;
    public float score;
    public GameState gameState;
    public GameObject[] gos;

    private void Awake()
    {
        if(instance == null){
            instance = this;
        }
        else{
            if(instance != this){
                Destroy(this);
            }
        }
    }

    void Start()
    {
        //gameState = GameState.Stop;
        StartGame();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Scene scene = SceneManager.GetActiveScene();
        gos = GameObject.FindGameObjectsWithTag("Brick");
        print(gos.Length);
        if(gos.Length == 1){
            if (scene.name == "Cena_2"){
                SceneManager.LoadScene("Cena_3");
            } else if(scene.name == "Cena_4"){
                SceneManager.LoadScene("Cena_5");
            }
        }
        
    }
    public void AddPoints(float valor){
        this.score += valor;


    }
    public void StartGame(){
        gameState = GameState.Play;
        score = 0;
        Ball.GetComponent<BallScript>().StartBall();
    }
}
