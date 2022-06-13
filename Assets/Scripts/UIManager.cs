using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
  [SerializeField] private TMP_Text inputFieldText;
  [SerializeField] private TMP_Text bestScoreText;

  void Start ()
  {
    SaveData saveData = DataManager.Instance.LoadBestScore ();
    bestScoreText.text = saveData == null ? "No best scores yet" : $"Best score: {saveData.name} : {saveData.bestScore}";
    inputFieldText.text = DataManager.Instance.PlayerName;
  }

  public void OnNameChanged (string name)
  {
    DataManager.Instance.PlayerName = name;
  }

  public void OnQuitClick ()
  {
    Application.Quit ();
  }

  public void OnStartClick ()
  {
    SceneManager.LoadScene (1);
  }
}
