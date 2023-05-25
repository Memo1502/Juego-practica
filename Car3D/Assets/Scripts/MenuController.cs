using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string nextLevel;
    public GameObject pnl_Settings;

    public void LoadScene()
    {
        SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
    }

    public void ActiveSettingsPanel(bool active)
    {
        pnl_Settings.SetActive(active);
    }
}
