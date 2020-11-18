using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterface : MonoBehaviourSingleton<UserInterface>
{
    [Header("UI Elements")]
    [SerializeField]
    private GameObject m_gameOver;
    [SerializeField]
    private Button m_startOverButton;
    [SerializeField]
    private Button m_menuButton;
    [SerializeField]
    private Text m_scoreText;
    [SerializeField]
    private Slider m_HPSlider;
    [SerializeField]
    private GameObject m_panelPause;
    [SerializeField]
    private Text m_attackSpeedNumberText;

    [Header("Game Object reference")]
    [SerializeField]
    private Player m_playerObject;


    private int m_numberASBonus;
    private int m_score;
    new private void Awake()
    {
        m_numberASBonus = 0;
        m_playerObject.onHPChangeEvent += updateHP;
        m_playerObject.onScoreChangeEvent += updateScore;
        m_playerObject.onASChangeEvent += updateASBonus;
        m_startOverButton.onClick.AddListener(() => GameManager.Instance.ResetLevel());
        m_menuButton.onClick.AddListener(() => SceneManager.LoadScene("TitleScene"));
    }

    // Start is called before the first frame update
    void Start()
    {
        m_HPSlider.maxValue = m_playerObject.m_maxHP;
        m_HPSlider.value = m_playerObject.m_maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Permet de mettre à jour le score sur l'interface utilisateur
    /// </summary>
    /// <param name="pScore">Le nouveau score</param>
    private void updateScore(int pScore)
    {
        m_scoreText.text = "Score : " + pScore;
        m_score = pScore;
    }

    /// <summary>
    /// Permet de mettre à jour la vie sur l'interface utilisateur et gérer la mort
    /// </summary>
    /// <param name="pHP">Le nouveau nombre de point de vie</param>
    private void updateHP(int pHP)
    {
        m_HPSlider.value = pHP;
        if(pHP < 1)
        {
            m_gameOver.SetActive(true);
            m_startOverButton.gameObject.SetActive(true);
            m_menuButton.gameObject.SetActive(true);
            writeScore();
        }
    }

    /// <summary>
    /// Permet de mettre à jour le nombre de bonus ramassés sur l'interface utilisateur
    /// </summary>
    private void updateASBonus()
    {
        m_numberASBonus++;
        m_attackSpeedNumberText.text = "x" + m_numberASBonus;
    }

    /// <summary>
    /// Permet d'afficher ou non l'écran de pause
    /// </summary>
    /// <param name="pause">Mise ou pause ou non</param>
    public void togglePausePanel(bool pause)
    {
        m_panelPause.SetActive(pause);
    }

    /// <summary>
    /// Écriture des scores
    /// </summary>
    private void writeScore()
    {
        //S'il n'y a aucun score on en rajoute un premier
        if (!PlayerPrefs.HasKey("score0"))
        {
            PlayerPrefs.SetInt("score0", m_score);
            PlayerPrefs.Save();
        }
        else
        {
            //Sinon on récupère la liste des scores, on intègre le nouveau score 
            //puis on trie de facçon décroissante et on enlève le 11ème score si nécéssaire
            List<int> scores = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                if (PlayerPrefs.HasKey("score" + i))
                    scores.Add(PlayerPrefs.GetInt("score" + i));
            }

            scores.Add(m_score);
            scores = scores.OrderByDescending(i => i).ToList();
            if (scores.Count > 10)
                scores.RemoveAt(10);

            for(int i = 0; i < scores.Count; i++)
                PlayerPrefs.SetInt("score" + i, scores.ElementAt(i));

            PlayerPrefs.Save();
        }
    }

    /// <summary>
    /// La défaite du boss qui termine le jeu en simulant une mort
    /// </summary>
    public static void bossDefeat()
    {
        Instance.updateHP(0);
    }
}
