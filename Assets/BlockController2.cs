using UnityEngine;

public class BlockController2 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] blocks;
    public static BlockController2 instance;

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
        this.createBlock();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createBlock(){
        float px = -96f;
        float py = 80f;

        for (int i = 0; i < 5; i++){
            px= -96;
            for(int j = 0; j < 8; j++){
                Vector3 pos = new Vector3(px, py, 0);
                Instantiate(blocks[i], pos, Quaternion.identity);
                px = px + 16;
            }
            py= py-8;
        }
    }
}
