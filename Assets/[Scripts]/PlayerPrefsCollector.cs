using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PlayerPrefsCollector : MonoBehaviour
{
    public enum DataType { String, Float, Integer };
    public DataType dataType;
    private Text display;

    public string VariableName;

    private void Start()
    {
        display = GetComponent<Text>();
    }

    void Update()
    {
        if (dataType == DataType.String)
        {
            display.text = PlayerPrefs.GetString(VariableName);
        }

        if (dataType == DataType.Integer)
        {
            display.text = PlayerPrefs.GetInt(VariableName).ToString();
        }

        if (dataType == DataType.Float)
        {
            display.text = PlayerPrefs.GetFloat(VariableName).ToString();
        }
    }
}
