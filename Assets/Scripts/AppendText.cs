using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class AppendText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private string text;

    /// <summary>
    /// Appends the text to the input field.
    /// </summary>
    public void append()
    {
        inputField.text += text;
    }

    /// <summary>
    /// Removes the last character from the input field if it's not empty.
    /// </summary>
    public void remove()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }
}
