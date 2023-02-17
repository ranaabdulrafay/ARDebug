using UnityEngine;
using TMPro;
using AR.Utility;
using System;
using UnityEngine.UI;

public class ARLogDemo : MonoBehaviour
{
    public enum PresetColors { None, Red, Blue, Green, Orange }
    public PresetColors m_Color;
    public bool LogOverride { get; set; }
    public TMP_InputField m_Input;

    public int m_InputInt;
    public float m_InputFloat;
    public bool m_InputBool;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LogValues()
    {
        object object1 = string.Format("int: {0} ", m_InputInt);
        object object2 = string.Format("float: {0} ", m_InputFloat);
        object object3 = string.Format("bool: {0} ", m_InputBool);
        switch (m_Color)
        {
            case PresetColors.Red:
                ARDebug.Log(string.Format("{0} , {1} and {2} ", object1, object2, object3), Color.red, LogOverride);
                break;
            case PresetColors.Green:
                ARDebug.Log(string.Format("{0} , {1} and {2} ", object1, object2, object3), Color.green, LogOverride);
                break;
            case PresetColors.Blue:
                ARDebug.Log(string.Format(" {0} , {1} and {2} ", object1, object2, object3), Color.blue, LogOverride);
                break;
            case PresetColors.None:
                ARDebug.Log(string.Format(" {0} , {1} and {2} ", object1, object2, object3), LogOverride);
                break;
        }
    }
    public void LogInput()
    {
        switch (m_Color)
        {
            case PresetColors.Red:
                ARDebug.Log(m_Input.text, Color.red, LogOverride);
                break;
            case PresetColors.Green:
                ARDebug.Log(m_Input.text, Color.green, LogOverride);
                break;
            case PresetColors.Blue:
                ARDebug.Log(m_Input.text, Color.blue, LogOverride);
                break;
            case PresetColors.None:
                ARDebug.Log(m_Input.text, LogOverride);
                break;
        }
    }

    public void SelectOption(Int32 _value)
    {
        m_Color = (PresetColors)_value;
    }

}
