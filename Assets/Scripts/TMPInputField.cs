using TMPro;
using UnityEngine;

public class InputFieldController : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    public void AppendText(string text)
    {
        inputField.text += text;
    }

    public void ReadText()
    {
        string text = inputField.text;
        Debug.Log("Input field text: " + text);
    }
}