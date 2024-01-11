using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCounter : MonoBehaviour

//503403 - This script attaches the parent gameobject of the skeleton & livemodels to reference
//variables passed from the XR Socket Tag Interactor 'Select Entered & Exited Events' to increment
//the bone count when player matches bones to the skeleton model.
//maxBones is set to 4 in this case as each model has 4 x missing bones to complete.

{
    public int maxBones;
    public int counter;
    public GameObject skeleton;
    public GameObject liveModel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (counter == maxBones)
        {
            skeleton.SetActive(false);
            liveModel.SetActive(true);
        }
    }

    public void counterIncrement() 
    { 
    counter++;
        Debug.Log("counter = " + counter);
    }

    public void counterDecrement()
    {
        counter--;
        Debug.Log("counter = " + counter);
    }




}
