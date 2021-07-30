using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _stageText;
    //[SerializeField]
    //private Text _livesText;
    public void UpdateStageDisplay(int stageNo)
    {
        _stageText.text = "Stage: " + stageNo.ToString();

    }

    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    /**
    public void UpdateLivesDisplay(int lives)
    {
        _livesText.text = "Lives: " + lives.ToString();
    }
    */
}
