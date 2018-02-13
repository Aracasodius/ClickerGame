using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private Text t_Score;

    [SerializeField] private float ClickScore = 1;
    public float TimeScore;

    private void Update()
    {
        if (t_Score != null) { t_Score.text = PlayerPrefs.GetFloat("Score").ToString(); }
        PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + TimeScore);
    }

    public void ClickScoreAdd()
    {
        PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + ClickScore);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetFloat("Score", 0);
    }
}
