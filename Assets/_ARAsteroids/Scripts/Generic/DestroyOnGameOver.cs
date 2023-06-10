using UnityEngine;

public class DestroyOnGameOver : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    private void OnEnable()
    {
        _gameState.OnGameOver.AddListener(DestroyGO);
    }

    private void OnDisable()
    {
        _gameState.OnGameOver.RemoveListener(DestroyGO);
    }

    void DestroyGO()
    {
        Destroy(gameObject);
    }
    
}
