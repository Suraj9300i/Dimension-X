using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackHandler : MonoBehaviour
{
    [SerializeField] float TrackSpeed = 5f;
    [SerializeField] GameObject TrackPrefab;
    float DistanceOfDeletion = -200f;
    private void Update()
    {
        gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * TrackSpeed);
        if (gameObject.transform.position.z <= DistanceOfDeletion)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
            GameObject lastTrack = gameObject.transform.GetChild(gameObject.transform.childCount - 1).gameObject;
            GameObject newTrack = Instantiate(TrackPrefab, new Vector3(0, 0, lastTrack.transform.position.z + 200), Quaternion.identity);
            newTrack.transform.parent = gameObject.transform;
            DistanceOfDeletion -= 200;
        }

    }
}
