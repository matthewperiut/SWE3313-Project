using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        InitializeUsers();
    }

    private void InitializeUsers()
    {
        // What an interesting restaurant this would be...
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
    }

    public void SetUserClockedIn(string pin, bool isClockedIn)
    {
        User user = GetUserByPin(pin);
        if (user != null)
        {
            user.isClockedIn = isClockedIn;
        }
    }

    public User GetUserByPin(string pin)
    {
        return users.Find(user => user.pin == pin);
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
