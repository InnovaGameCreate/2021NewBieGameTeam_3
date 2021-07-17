using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontroller : MonoBehaviour
{
    public float x_sensi;
    public float y_sensi;
    public new GameObject camera;
    public Vector3 cameraAngle;
    [SerializeField] GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameracon();
    }
    void LateUpdate()
    {
        head.transform.localEulerAngles = new Vector3(0, 0, -cameraAngle.x);
    }
    
    void cameracon()
    {
        float x_Rotation = Input.GetAxis("Mouse X");
        float y_Rotation = Input.GetAxis("Mouse Y");
        x_Rotation = x_Rotation * x_sensi;
        y_Rotation = y_Rotation * y_sensi;
        this.transform.Rotate(0, x_Rotation, 0);
        camera.transform.Rotate(-y_Rotation, 0, 0);
        cameraAngle = camera.transform.localEulerAngles;
        if (cameraAngle.x < 280 && cameraAngle.x > 180)
        {
            cameraAngle.x = 280;
        }
        if (cameraAngle.x > 45 && cameraAngle.x < 180)
        {
            cameraAngle.x = 45;
        }
        cameraAngle.y = 0;
        cameraAngle.z = 0;
        camera.transform.localEulerAngles = cameraAngle;
    }
}
