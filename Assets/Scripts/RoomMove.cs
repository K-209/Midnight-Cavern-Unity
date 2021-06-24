using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
  private CameraMovement cam;
  public Vector2 newMaxPos;
  public Vector2 newMinPos;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OntriggerEnter2D(Collider2D other)
    {
        if(other.tag == ("Player"))
      {
            cam.maxPosition = newMaxPos;
            cam.minPosition = newMinPos;
      }
    }
}
