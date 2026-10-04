using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DataPersistance : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        MenuManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
