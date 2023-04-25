using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;

public enum EmployeeRole
{
    Wait,
    Cook,
    Manager,
    Bus,
    Host
}

public class UserDataManager : MonoBehaviour
{
    public static UserDataManager Instance;

    [System.Serializable]
    public class User {
        public string pin;
        public string name;
        public EmployeeRole role;
        public bool isClockedIn;
    }

    public List<User> users;

    void Awake()
    {
        // Singleton patter
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadUsersFromFile();
    }
    
    private void SaveUsersToFile()
    {
        string userDataFilePath = Path.Combine(Application.persistentDataPath, "UserData.txt");
        StringBuilder userDataContent = new StringBuilder();

        foreach (User user in users)
        {
            userDataContent.AppendLine($"{user.pin},{user.name},{user.role}");
        }

        File.WriteAllText(userDataFilePath, userDataContent.ToString());
    }

    public bool AddNewUser(string pin, string name, EmployeeRole role)
    {
        if (pin.Length != 4)
        {
            Debug.LogWarning("PIN must be 4 characters long.");
            return false;
        }

        // Check if the pin is already in use
        if (GetUserByPin(pin) != null)
        {
            Debug.LogWarning("PIN is already in use.");
            return false;
        }

        User newUser = new User
        {
            pin = pin,
            name = name,
            role = role,
            isClockedIn = false
        };

        users.Add(newUser);

        SaveUsersToFile();

        return true;
    }

    private void LoadUsersFromFile()
    {
        users = new List<User>();

        string userDataFilePath = Path.Combine(Application.persistentDataPath, "UserData.txt");

        if (File.Exists(userDataFilePath))
        {
            string[] userDataLines = File.ReadAllLines(userDataFilePath);

            foreach (string line in userDataLines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                string[] userData = line.Split(',');

                if (userData.Length == 3)
                {
                    User user = new User
                    {
                        pin = userData[0].Trim(),
                        name = userData[1].Trim(),
                        role = (EmployeeRole)System.Enum.Parse(typeof(EmployeeRole), userData[2].Trim()),
                        isClockedIn = false
                    };

                    users.Add(user);
                }
            }
        }
        else
        {
            // File does not exist, create default values
            users = new List<User>
            {
                new User { pin = "3141", name = "Ada Lovelace", role = EmployeeRole.Wait},
                new User { pin = "5926", name = "Charles Babbage", role = EmployeeRole.Wait},
                new User { pin = "5358", name = "Alan Turing", role = EmployeeRole.Wait},
                new User { pin = "9793", name = "Leonhard Euler", role = EmployeeRole.Wait},
                new User { pin = "2384", name = "Joseph Fourier", role = EmployeeRole.Wait},
                new User { pin = "6264", name = "Gottfried Leibniz", role = EmployeeRole.Wait},
                new User { pin = "3383", name = "Archimedes", role = EmployeeRole.Wait},
                new User { pin = "2795", name = "Benoit Mandelbrot", role = EmployeeRole.Wait},
                new User { pin = "0288", name = "John Nash", role = EmployeeRole.Wait},
                new User { pin = "4197", name = "Grace Hopper", role = EmployeeRole.Wait} // HOOYAH
            };

            SaveUsersToFile();
        }
    }


    public User GetUserByPin(string pin)
    {
        return users.Find(user => user.pin == pin);
    }

    public void SetUserClockedIn(string pin, bool isClockedIn)
    {
        User user = GetUserByPin(pin);
        if (user != null)
        {
            user.isClockedIn = isClockedIn;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
