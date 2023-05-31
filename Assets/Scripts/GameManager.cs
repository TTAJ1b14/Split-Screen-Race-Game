using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button understoodButton;
    [SerializeField] TextMeshProUGUI tooltip;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UnderstoodControls()
    {
        understoodButton.gameObject.SetActive(false);
        tooltip.gameObject.SetActive(false);
    }

}
