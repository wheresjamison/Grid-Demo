using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerManager : MonoBehaviour
{
    private GameManager gm;

    public Vector3 playerPosition; //startPosition
    public Vector3 targetPosition; //endPosition

    private float desiredDuration = 3f;
    private float timeElapsed;

    public void Start()
    {
        playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.Log("PlayerManager.cs: playerPosition is = " + playerPosition.ToString());
        gm = FindAnyObjectByType<GameManager>();
        targetPosition = gm.GetNewPosition();
        Debug.Log("PlayerManager.cs: targetPosition has been set to" + gm.GetNewPosition().ToString());
    }

    public void Update()
    {
        UpdateTargetPosition();
        PlayerLerp();
    }

    public void UpdateTargetPosition()
    {
        if (gm.GetNewPositionWithoutDebug() != targetPosition)
        {
            Vector3 oldPosition = targetPosition;
            targetPosition = gm.GetNewPositionWithoutDebug();
            Debug.Log("PlayerManager.cs: targetPosition has been updated to" + gm.GetNewPositionWithoutDebug().ToString() + " from " + oldPosition.ToString());
        }
    }

    public void PlayerLerp()
    {
        if (playerPosition != targetPosition)
        {
            timeElapsed += Time.deltaTime;
            float percentageComplete = timeElapsed / desiredDuration;

            transform.position = Vector3.Lerp(playerPosition, targetPosition, percentageComplete);

            Debug.Log("PlayerManager.cs : percentageComplete = " + percentageComplete.ToString());
        }
        if (transform.position == targetPosition)
        {
            playerPosition = targetPosition;
            timeElapsed = 0f;
            //this ensures that the player is moving smoothly from the target square and the start square every time.
        }
    }
}
