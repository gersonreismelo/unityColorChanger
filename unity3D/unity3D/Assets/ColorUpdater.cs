using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class ColorOption
{
    public string hexadecimal;
}

public class ColorUpdater : MonoBehaviour
{
    private string serverEndpoint = "http://localhost:1337/cors";

    void Start()
    {
        StartCoroutine(UpdateColorRoutine());
    }

    IEnumerator UpdateColorRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            UnityWebRequest www = UnityWebRequest.Get(serverEndpoint);

            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Failed to fetch color from server. Error: " + www.error);
            }
            else
            {
                string jsonResponse = www.downloadHandler.text;
                ColorOption colorOption = JsonUtility.FromJson<ColorOption>(jsonResponse);

                if (colorOption != null)
                {
                    string colorCode = colorOption.hexadecimal;
                    UpdateObjectColor(colorCode);
                }
                else
                {
                    Debug.LogError("Failed to parse color option from JSON: " + jsonResponse);
                }
            }
        }
    }

    void UpdateObjectColor(string colorCode)
    {
        Color newColor;

        if (ColorUtility.TryParseHtmlString(colorCode, out newColor))
        {
            GetComponent<Renderer>().material.color = newColor;
        }
        else
        {
            Debug.LogError("Failed to parse color code: " + colorCode);
        }
    }
}
