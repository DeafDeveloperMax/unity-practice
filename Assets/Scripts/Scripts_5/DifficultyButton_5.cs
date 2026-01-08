using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton_5 : MonoBehaviour
{
    public int difficulty;
    private Button button;
    private GameManager_5 gameManager;
    
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager_5>();
        
        button.onClick.AddListener(SetDifficulty);
    }
    
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
