using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CorrectPinLogin : MonoBehaviour
{
    private string filePath;
    private string userFilePath;
	[SerializeField] private TMP_InputField inputField;
	[SerializeField] private Button logout;

    private void Start()
    {
        // Set the file path based on the current platform and persistent data path
        filePath = Path.Combine(Application.persistentDataPath, "admin.txt");
        userFilePath = Path.Combine(Application.persistentDataPath, "user.txt");
    }

	public void Test()
	{
		string text = inputField.text;
		if (text == "3141")
		{
			inputField.text = "";
			WriteAdmin();
			WriteCurrentUser("Waiter");
			logout.interactable = true;
		}
		if (text == "0000")
		{
			inputField.text = "";
			WriteAdmin();
			WriteCurrentUser("Admin");
			logout.interactable = true;
		}
	}

	private void WriteCurrentUser(string username)
	{
		if (File.Exists(userFilePath))
		{
			File.Delete(userFilePath);
		}
		using (StreamWriter writer = new StreamWriter(userFilePath))
		{
			// Write the data to the file
			writer.Write(username);
		}
	}
    private void WriteAdmin()
    {
		bool isAdmin = false;

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
	        {
    	        // Read the data from the file
        	    string data = reader.ReadToEnd();
				isAdmin = data.Contains("admin");
				if (isAdmin)
        	    	return;
        	}
        }
        else
        {
            Debug.Log("File does not exist.");
        }

		if (isAdmin == false)
		{
			// Open the file for writing
        	using (StreamWriter writer = new StreamWriter(filePath))
        	{
         	   // Write the data to the file
         	   writer.Write("admin");
        	}
		}
    }
}
