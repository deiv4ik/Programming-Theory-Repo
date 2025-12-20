using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class TranslateToMainMenu : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField nameUser;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !string.IsNullOrWhiteSpace(nameUser.text))
        {
            PlayerData.Instance.Set(nameUser.text);
            ExchangeScenes();
        }
    }

    private void ExchangeScenes()
    {
        SceneManager.LoadScene("main");
    }
}
