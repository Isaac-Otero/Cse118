using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawing : MonoBehaviour
{
    //create a line renderer 
    LineRenderer lr;
    // get the Tip we will use
    [SerializeField] private Transform Tip;
    //length of line renderer is 2
    public int lengthOfLineRenderer = 2;
    //to raycast out to see if something is hit
    private RaycastHit hit;
    //length of tip, for determining if close to tablet
    //private float tiplength;
    // Start is called before the first frame update
    private Vector2 Touchposition;
    void Start()
    {
        //get line renderer to modify
        lr = GetComponent<LineRenderer>();
        //turn of world space use
        lr.useWorldSpace = false;
        //set length of tip
        //tiplength = lr.localScale.y;
    
    }

    // Update is called once per frame
    void Update()
    {
        //if a pressed
        if (Input.GetKeyDown("A"))
        {
            if (Physics.Raycast(Tip.position, transform.up, out hit))
            {
                if(hit.transform.CompareTag("Tablet"))
                {
                    lr.useWorldSpace =true;
                    lr.positionCount=lengthOfLineRenderer;
                    var vector= new Vector3[lengthOfLineRenderer];
                    var time= Time.time;
                    for(int i=0;i<lengthOfLineRenderer;i++)
                    {
                        vector[i]= new Vector3(i * 0.5f,Mathf.Sin(i+time),0.0f);
                    }
                }
            }
        }
        //if b is pressed
      //  if (Input.GetKeyDown("B"))
        //{
//
        //}
    }
}
