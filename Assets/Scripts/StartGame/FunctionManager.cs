using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class FunctionManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    ItemSorter itemSorter;
    private void Start()
    {
        itemSorter = GameObject.FindObjectOfType<ItemSorter>();
    }
    public void QuitGame()
    {
        Debug.Log("We quite");
        Application.Quit();
    }

    public void ChangeQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);

    }

    public void ChangeGameVolume(float volume)
    {
        audioMixer.SetFloat("MainVolume", volume);
        audioMixer.SetFloat("Music", volume);
        audioMixer.SetFloat("Effects", volume);
    }

    public void ChangeMusic(float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }

    public void ChangeSoundEffects(float volume)
    {
        audioMixer.SetFloat("Effects", volume);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        itemSorter.ReloadNumbers();
    }

    
}
