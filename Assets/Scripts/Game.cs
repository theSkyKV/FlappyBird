using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private Button _restartButton;

    private void OnEnable()
    {
        _bird.Died += OnBirdDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _gameOverScreen.SetActive(false);
    }

    private void OnDisable()
    {
        _bird.Died -= OnBirdDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
    }

    private void OnBirdDied()
    {
        Time.timeScale = 0;
        _gameOverScreen.SetActive(true);
    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
