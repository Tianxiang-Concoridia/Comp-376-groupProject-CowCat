using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : Interactable
{
    [SerializeField] GameObject newCamera;
    [SerializeField] GameObject oldCamera;

    AudioSource audio;

    [SerializeField] GameObject playerObject;

    [SerializeField] Vector2 destinationVector;



    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {

            useDoor();
        }
    }

    private void useDoor()
    {
        oldCamera.SetActive(false);
        newCamera.SetActive(true);
        playerObject.transform.position = destinationVector;
        audio.Play();
    }
}
