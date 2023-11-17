using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;
using PA_DronePack;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System;
using System.IO;
using UnityEngine.Serialization;
using System.Collections.Specialized;

public class DroneSetting : MonoBehaviour
{
    public static int data = 0;
    public GameObject DroneAgent;
    public GameObject DroneAgent_2;
    public GameObject Goal;
    public GameObject Goal2;

    Vector3 areaInitPos;
    Vector3 droneInitPos;
    Vector3 droneInitPos2;
    Quaternion droneInitRot;
    Quaternion droneInitRot2;


    EnvironmentParameters m_ResetParams;

    private Transform AreaTrans;
    private Transform DroneTrans;
    private Transform DroneTrans_2;
    private Transform GoalTrans;
    private Transform GoalTrans2;

    private Rigidbody DroneAgent_Rigidbody;
    private Rigidbody DroneAgent_Rigidbody2;
    void Start()
    {
        /*
        for (int i = 0; i < BaseStationNumber; i++)
        {
            string temp;
            temp = "BaseStation" + i.ToString();
            this.BSlist.Add(GameObject.Find(temp));
            //Debug.Log(this.BSlist[i].transform.position.x);
        }
        */
        //Debug.Log(m_ResetParams);

        AreaTrans = gameObject.transform;
        DroneTrans = DroneAgent.transform;
        DroneTrans_2 = DroneAgent_2.transform;
        GoalTrans = Goal.transform;
        GoalTrans2 = Goal2.transform;

        areaInitPos = AreaTrans.position;
        droneInitPos = DroneTrans.position;
        droneInitRot = DroneTrans.rotation;

        droneInitPos2 = DroneTrans_2.position;
        droneInitRot2 = DroneTrans_2.rotation;

        DroneAgent_Rigidbody = DroneAgent.GetComponent<Rigidbody>();
        DroneAgent_Rigidbody2 = DroneAgent_2.GetComponent<Rigidbody>();

    }

    public void AreaSetting()
    {
        //DroneAgent_Rigidbody.velocity = Vector3.zero;
        //DroneAgent_Rigidbody.angularVelocity = Vector3.zero;

        //DroneTrans.position = droneInitPos;
        //DroneTrans.rotation = droneInitRot;

        GoalTrans.localPosition = new Vector3(UnityEngine.Random.Range(-25, 25), UnityEngine.Random.Range(0.1f, 3), UnityEngine.Random.Range(-20, 20));
        //GoalTrans2.localPosition = new Vector3(UnityEngine.Random.Range(-25, 25), UnityEngine.Random.Range(0.1f, 3), UnityEngine.Random.Range(-20, 20));

    }
    public void AreaSetting2()
    {
        //DroneAgent_Rigidbody.velocity = Vector3.zero;
        //DroneAgent_Rigidbody.angularVelocity = Vector3.zero;

        //DroneTrans.position = droneInitPos;
        //DroneTrans.rotation = droneInitRot;

        GoalTrans2.localPosition = new Vector3(UnityEngine.Random.Range(-25, 25), UnityEngine.Random.Range(0.1f, 3), UnityEngine.Random.Range(-20, 20));

    }
}

