using UnityEngine;
using UnityEngine.UI;

public class SacrificeManager : MonoBehaviour
{
    public GameObject sacrificePanel;
    public Button card1Button;
    public Button card2Button;
    public Button card3Button;
    public PlayerMovement player; 
    public Image blackPanel; // drag your black panel here

    private float timer = 0f;
    private float interval = 10f;

    void Start()
    {
        card1Button.onClick.AddListener(() => ChooseCard(1));
        card2Button.onClick.AddListener(() => ChooseCard(2));
        card3Button.onClick.AddListener(() => ChooseCard(3));

        sacrificePanel.SetActive(false);
        blackPanel.color = new Color(0, 0, 0, 0); // start transparent
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            ShowPanel();
            timer = 0f;
        }
    }

    void ShowPanel()
    {
        Time.timeScale = 0f;
        sacrificePanel.SetActive(true);
    }

    void ChooseCard(int cardID)
    {
        if (cardID == 1)
        {
            player.playerSpeed = Mathf.Max(3.5f, player.playerSpeed - 3.5f);
        }
        else if (cardID == 2)
        {
            player.horizontalSpeed = Mathf.Max(3f, player.horizontalSpeed - 3.5f);
        }
        else if (cardID == 3)
        {
            // Black screen effect
            blackPanel.color = new Color(0, 0, 0, 0.8f); // almost fully black
        }

        sacrificePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
