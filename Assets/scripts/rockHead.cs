using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockHead : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    private float timer = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .5f)
        {
            if (timer >= 3f)
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length) { currentWaypointIndex = 0; }
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime * 1f;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

    }
}
