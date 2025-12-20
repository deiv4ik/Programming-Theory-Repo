using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class TItleUserGreeting : MonoBehaviour
{
    [SerializeField]
    private TMP_Text outputingUserName;
    private int delay = 3;
    void Start()
    {
        outputingUserName.text = $"Hello, {PlayerData.Instance.Get()}";
        StartCoroutine(HideObjectAfterDelay());
    }

    IEnumerator HideObjectAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        outputingUserName.text = "";
    }
}
