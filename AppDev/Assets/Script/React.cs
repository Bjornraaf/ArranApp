using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour
{
    [SerializeField] GameObject fireWork;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.z = 0f;
                    //touchPosition.y = -2f;
                    Instantiate(fireWork, touchPosition, Quaternion.identity);
                    Debug.Log("Started");
                    break;

                //Determine if the touch is a moving touch
                //case TouchPhase.Moved:
                // Determine direction by comparing the current touch position with the initial one
                //direction = touch.position - startPos;
                //Debug.Log("Moved");
                //break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    Debug.Log("Ended");
                    break;
            }
        }
        //if(Input.touchCount > 0)
        //{
        //Touch touch = Input.GetTouch(0);
        //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        //touchPosition.z = 0f;
        //transform.position = touchPosition;  
        //}



        //for(int i = 0;  i < Input.touchCount; i++)
        //{
        //    Vector3 touchPostion = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
        //    touchPostion.z = 0;
        //    Debug.DrawLine(Vector3.zero, touchPostion, Color.red);
        //    Instantiate(fireWork, touchPostion, Quaternion.identity);
        //}

    }
}
