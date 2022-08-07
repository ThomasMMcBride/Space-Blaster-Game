using UnityEngine;

public class PlayerMovementDashNBlast : MonoBehaviour
{
   
     public float maxSpeed = 0.001f;
     public Camera MainCamera;
     private Rect screenBounds;
     private float objectWidth;
     private float objectHeight;
 

    // Start is called before the first frame update

     void Start() {
         float cameraHeight = MainCamera.orthographicSize * 2;
         float cameraWidth = cameraHeight * MainCamera.aspect;
         Vector2 cameraSize = new Vector2(cameraWidth, cameraHeight);
         Vector2 cameraCenterPosition = MainCamera.transform.position;
         Vector2 cameraBottomLeftPosition = cameraCenterPosition - (cameraSize / 2);
         screenBounds = new Rect(cameraBottomLeftPosition , cameraSize);
         objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
         objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
     }

    // Update is called once per frame

     void FixedUpdate() {
         Vector3 pos = transform.position;
         pos.x += Input.GetAxis("Horizontal") * maxSpeed;
         pos.y += Input.GetAxis("Vertical") * maxSpeed;
         transform.position = pos;
         screenBounds.position = (Vector2)MainCamera.transform.position - (screenBounds.size / 2);
     }

    // LateUpdate is called once per frame after Update

     void LateUpdate() {
         Vector3 viewPos = transform.position;
         viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x + screenBounds.width - objectWidth);
         viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y + screenBounds.height - objectHeight);
         transform.position = viewPos;
     }
 }

