using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string playerName;

    public int MaxScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveHighScore(int score, string name)
    {
        if (score > PlayerPrefs.GetInt("MaxScore", 0))
        {
            PlayerPrefs.SetInt("MaxScore", score);
            PlayerPrefs.SetString("MaxScoreName", name);
            PlayerPrefs.Save();
        }
    }

    public int GetHighScore() => PlayerPrefs.GetInt("MaxScore", 0);
    public string GetHighScoreName() => PlayerPrefs.GetString("MaxScoreName", "");
    // Update is called once per frame
    void Update()
    {
        
    }
}
