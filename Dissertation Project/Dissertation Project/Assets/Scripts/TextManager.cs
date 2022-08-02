using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public Grid grid;

    public TextMeshProUGUI AgentsPassedText;
    public TextMeshProUGUI TimeText;
    public int AgentsPassed;
    public float time;

    public TextMeshProUGUI FPSCounterText;
    public TextMeshProUGUI FPSAverageText;
    int i;
    int TotalFps;
    void Update()
    {
        if (grid.AgentsList != null)
        {
            if (AgentsPassed != grid.AgentsList.Count)
            {
                time += Time.unscaledDeltaTime;
                TimeText.text = ("Time Taken:" + time.ToString());

            }
        }
        if (grid.AgentsList != null)
        {
            if (AgentsPassed != grid.AgentsList.Count)
            {
                //Framerate
                float frames = 1 / Time.unscaledDeltaTime;
                int fps = Mathf.RoundToInt(frames);
                FPSCounterText.text = "Frames Per Second:" + fps;
                if (AgentsPassed < 1)
                {
                    i += 1;
                    TotalFps += fps;
                    int AverageFps = TotalFps / i;
                    FPSAverageText.text = "Average Frames: " + AverageFps;
                }
            }
        }
    }
    public void AddText()
    {
        AgentsPassed += 1;
        AgentsPassedText.text = ("Agents Passed: " + AgentsPassed);
    }
}
