using UnityEngine;
using UnityEngine.Events;

public class Bird : MonoBehaviour
{
    private int _score;

    public event UnityAction<int> ScoreChanged;
    public event UnityAction Died;

    private void Start()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
    }

    public void Die()
    {
        Died?.Invoke();
    }

    public void AddScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }
}
