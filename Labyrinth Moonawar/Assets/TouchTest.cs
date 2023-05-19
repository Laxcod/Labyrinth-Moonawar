// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TouchTest : MonoBehaviour
// {
//     [SerializeField] GameObject visualTemplate;

//     List<GameObject> visual list = new List<GameObject>();

//     void Update()
//     {
//        if(Input.touchCount ==0) 
//        return;

//        var touches = Input.touches;

//        while (visual)
//        {
        
//        }

//        for (int i = 0; i < touches.Length; i++)
//        {
        
//          var touch = touches[i];

//          switch (touch.phase)
//        {
//             case TouchPhase.Began:
//                 Debug.Log("BEgan " + i + "" + touch.position);
//                 break;
//             case TouchPhase.Stationary:
//                 Debug.Log("Stationary " + i + "" + touch.position);
//                 break;
//             case TouchPhase.Moved:
//                 Debug.Log("Moved " +i + "" + touch.deltaPosition);
//                 break;
//             case TouchPhase.Ended:
//                 Debug.Log("Ended " +i + "" + touch.position);
//                 break;
//             case TouchPhase.Canceled:
//             Debug.Log("Canceled " +i + "" + touch.position);
//                 break;
//        }

//        }
//     }
// }
