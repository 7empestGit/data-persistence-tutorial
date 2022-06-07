using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
  [SerializeField] private TMP_Text inputFieldText;
  [SerializeField] private TMP_Text bestScoreText;

  void Start ()
  {
    bestScoreText.text = $"Best Score: ";
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
