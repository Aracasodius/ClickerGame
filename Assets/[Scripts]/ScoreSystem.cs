using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private Text t_Score;

    [SerializeField] private float ClickScore = 1;

    float t;
    float t_max = 1f;
    public float TimeScore;

    private void Update()
    {
        if (t_Score != null) { t_Score.text = PlayerPrefs.GetFloat("Score").ToString(); }
        


        t += Time.deltaTime;

        if (t >= t_max)
        {
            t = 0.0f;
            PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + TimeScore);
            PlayerPrefs.SetFloat("AllScore", PlayerPrefs.GetFloat("AllScore") + TimeScore);
        }
    }

    public void ClickScoreAdd()
    {
        PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + ClickScore);
        PlayerPrefs.SetFloat("AllScore", PlayerPrefs.GetFloat("AllScore") + ClickScore);
        PlayerPrefs.SetInt("TotalClicks", PlayerPrefs.GetInt("TotalClicks") + 1);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetFloat("Score", 0);
    }

    public void ResetAll()
    {
        PlayerPrefs.SetFloat("Score", 0);
        PlayerPrefs.SetFloat("AllScore", 0);
        PlayerPrefs.SetInt("TotalClicks", 0);
    }
}
