using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatLog : MonoBehaviour
{
    public TextMeshProUGUI chatText;
    public ScrollRect scrollRect;

    public void AddMessage(string message)
    {
        chatText.text = message + "\n" + chatText.text;
        //UpdateScrollPosition();
    }

    public void UpdateScrollPosition()
    {
        Canvas.ForceUpdateCanvases();
        scrollRect.verticalNormalizedPosition = 0f;
    }
}
