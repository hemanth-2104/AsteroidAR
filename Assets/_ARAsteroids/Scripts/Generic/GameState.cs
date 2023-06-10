using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/CreateGameDataAsset")]
public class GameState : ScriptableObject
{
    public int Score;
    public UnityEvent<int> OnIncreaseScore;
    public UnityEvent OnGameOver;
    public float GameSpeed = 1;
    [SerializeField] private bool _gameOver;

    public bool GameOver
    {
        get => _gameOver;
        set
        {
            _gameOver = value;

            if (_gameOver)
                OnGameOver?.Invoke();
        }
    }
    public void IncreaseScore(int amount)
    {
        Score += amount;

        OnIncreaseScore?.Invoke(Score);
    }

    public void LoadScene(string AsteroidsGame)
    {
        SceneManager.LoadScene(AsteroidsGame);
    }

}
