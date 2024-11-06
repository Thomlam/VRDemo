using TMPro;
using UnityEngine;

public class EventLogger : MonoBehaviour
{
    public GameObject textPrefab;
    public Transform contentTransform;

    public void LogEvent(string eventName)
    {
        GameObject go = Instantiate(textPrefab, contentTransform);
        go.GetComponent<TextMeshProUGUI>().text = eventName;
    }
}
