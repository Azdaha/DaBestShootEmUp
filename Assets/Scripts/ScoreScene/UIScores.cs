using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScores : MonoBehaviourSingleton<UIScores>
{

    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Button backButton;

    new private void Awake()
    {
        backButton.onClick.AddListener(() => SceneManager.LoadScene("TitleScene"));
        scoreText.text = gatherScores();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string gatherScores()
    {
        if (PlayerPrefs.HasKey("score0"))
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                if(PlayerPrefs.HasKey("score" + i))
                {
                    result += (i + 1) + ". " + PlayerPrefs.GetInt("score" + i) + "\n";
                }
            }
            return result;
        }else
            return "No scores. Now go play ya git !";


    }
}
