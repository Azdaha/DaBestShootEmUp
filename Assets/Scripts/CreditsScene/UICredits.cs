using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICredits : MonoBehaviourSingleton<UICredits>
{

    [SerializeField]
    private Button backButton;

    new private void Awake()
    {
        backButton.onClick.AddListener(() => SceneManager.LoadScene("TitleScene"));
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
