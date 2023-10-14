using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public Text clockText;
    public float secondsPerGameMinute = 60f; // Adjust this value as needed.

    private float currentTime = 0f; // Current in-game time in seconds.
    private int currentHour = 0;

    private void Start()
    {
        currentTime = 0f; // Start at midnight.
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        UpdateClockText();
    }

    private void UpdateClockText()
    {
        int hours = Mathf.FloorToInt(currentTime / 3600) % 24;
        int minutes = Mathf.FloorToInt((currentTime % 3600) / 60);

        // Format the time as a 24-hour clock (00:00 to 23:59).
        string timeString = string.Format("{0:D2}:{1:D2}", hours, minutes);

        clockText.text = timeString;
    }
}
