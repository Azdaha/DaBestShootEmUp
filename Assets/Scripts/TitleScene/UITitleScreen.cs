using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UITitleScreen : MonoBehaviourSingleton<UITitleScreen>
{

    [SerializeField]
    private Button playButton;
    [SerializeField]
    private Button scoreButton;
    [SerializeField]
    private Button creditsButton;
    [SerializeField]
    private Button quitButton;

    new private void Awake()
    {
        playButton.onClick.AddListener(() => SceneManager.LoadScene("PlayScene"));
        scoreButton.onClick.AddListener(() => SceneManager.LoadScene("ScoreScene"));
        creditsButton.onClick.AddListener(() => SceneManager.LoadScene("CreditsScene"));
        quitButton.onClick.AddListener(() => Application.Quit());
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
