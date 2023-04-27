/// <summary>
/// This script allows the user to read and append text to an input field.
/// </summary>
using TMPro;
using UnityEngine;

public class InputFieldController : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    /// <summary>
    /// Appends text to the input field.
    /// </summary>
    public void AppendText(string text)
    {
        inputField.text += text;
    }

    /// <summary>
    /// Reads the text from the input field and logs it.
    /// </summary>
    public void ReadText()
    {
        string text = inputField.text;
        Debug.Log("Input field text: " + text);
    }
}