using UnityEngine;
using System.Collections;

public class Functions_Methods: MonoBehaviour {

    public int StarFallSpeed = 10;
    private int stars = 5;
    
    void Start()
    {
        //StarFallSpeed = 20;
        //Debug.Log(StarFallSpeed + 3);

        //Debug.Log(stars * 4);

        StarFallSpeed = AddStarsByFive(StarFallSpeed);
        Debug.Log(StarFallSpeed);

        stars = AddStarsByFive(stars);
        Debug.Log(stars);

    }


    int AddStarsByFive(int numberOfStars)
    {
        int ret;
        ret = numberOfStars + 5;
        return ret;
    }


    void Update()
    {


    }



}
