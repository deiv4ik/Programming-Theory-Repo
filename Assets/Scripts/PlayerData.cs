using UnityEngine;
using UnityEngine.UIElements;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    private string userName;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public void Set(string user)
    {
        userName = user;
    }

    public string Get()
    {
        return userName;
    }
}
