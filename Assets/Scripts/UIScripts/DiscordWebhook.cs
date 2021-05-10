using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class DiscordWebhook : MonoBehaviour
{
    string webhook_link = "https://discord.com/api/webhooks/840882836671823883/gfZd0doxFSSTkcX5U-N1irzE9WwzQrGrrsqOHqGz7nkZE0EJJDQKGSS3eSP8o8zYMRkx";

    public void SendDiscordMessage( string playerName, byte[] imageToLoad, float percentage, string difficulty)
    {
        StartCoroutine(SendWebhook(webhook_link, playerName, imageToLoad, percentage, difficulty, (success) =>
        {
            if (success)
                Debug.Log("Message Sent");
        }));
    }

    IEnumerator SendWebhook(string link, string playerName, byte[] image , float percentage, string difficulty, System.Action<bool> action)
    {
        WWWForm form = new WWWForm();
        form.AddField("content", $"{playerName} got {percentage}% correct on {difficulty} Level!");
        form.AddBinaryData("File", image, "tattoo.png", "image/png");
        using UnityWebRequest www = UnityWebRequest.Post(link, form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success || www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(www.error);
            action(false);
        }
        else
            action(true);
    }
}