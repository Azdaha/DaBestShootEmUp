using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    private bool _pause;
    public bool Pause
    {
        get
        {
            return _pause;
        }
        private set
        {
            _pause = value;
        }
    }

    private void Start()
    {
        _pause = true;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Play(bool play)
    {
        UserInterface.Instance.togglePausePanel(play);
        if (play)
        {
            Time.timeScale = 0.0f;
            Pause = false;
        }
        else
        {
            Time.timeScale = 1.0f;
            Pause = true;
        }
    }
}

