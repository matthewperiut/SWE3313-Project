// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;
// using TMPro;

// public class LoginManager : MonoBehaviour
// {
//     public TMP_InputField pinInputField;
//     public Button submitButton;
//     public string floorStatusSceneName = "FloorStatus";
//     // Add any other scene names for different roles here.

//     void Start()
//     {
//         submitButton.onClick.AddListener(OnSubmit);
//     }

//     private void OnSubmit()
//     {
//         string pin = pinInputField.text;
//         UserDataManager.User user = UserDataManager.Instance.GetUserByPin(pin);

//         if (user != null)
//         {
//             UserDataManager.Instance.SetUserClockedIn(pin, true);
            
//             switch (user.role)
//             {
//                 case EmployeeRole.Wait:
//                     SceneManager.LoadScene(floorStatusSceneName);
//                     break;

//                 // Add cases for other roles and load their respective scenes.
                
//                 default:
//                     Debug.LogWarning("Invalid role. Please check the users dictionary.");
//                     break;
//             }
//         }
//         else
//         {
//             Debug.LogWarning("Invalid PIN.");
//             pinInputField.text = ""; // Clear the input field.
//         }
//     }
// }
