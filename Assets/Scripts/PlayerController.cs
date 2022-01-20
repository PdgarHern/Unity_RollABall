using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
  public float speed = 0;
  public float jumpAmount = 10;
  public TextMeshProUGUI countText;
  public GameObject countTextObject;
  public TextMeshProUGUI countdown;
  public GameObject countdownObject;
  public GameObject winTextObject;
  public GameObject failTextObject;
  public GameObject quitButton;
  public GameObject retryButton;
  public GameObject backToMenuButton;

  private Rigidbody rb;
  private BoxCollider boxCollider;
  private int count;
  private int total;
  private float movementX;
  private float movementY;
  private float floorDist;

  private bool dead;

  // Start is called before the first frame update
  void Start() {
    rb = GetComponent<Rigidbody>();
    count = 0; 
    total = 12;

    floorDist = gameObject.transform.position.y;

    SetCountText();
    winTextObject.SetActive(false);
    failTextObject.SetActive(false);
    quitButton.SetActive(false);
    retryButton.SetActive(false);
    backToMenuButton.SetActive(false);

  }

  void OnMove(InputValue movementValue) {
    if (!dead) {
      Vector2 movementVector = movementValue.Get<Vector2>();

      movementX = movementVector.x;
      movementY = movementVector.y;

    } else {
      Vector2 movementVector = movementValue.Get<Vector2>();

      movementX = 0;
      movementY = 0;

    }
    

  }

  void SetCountText() {
    countText.text = "Count: " + count.ToString();
    countdown.text = "Total: " + total.ToString();
    if (count >= 12) {
      winTextObject.SetActive(true);
      quitButton.SetActive(true);
      backToMenuButton.SetActive(true);
      countTextObject.SetActive(false);
      countdownObject.SetActive(false);

    }

  }

  void SetFailText() {
    failTextObject.SetActive(true);
    retryButton.SetActive(true);
    backToMenuButton.SetActive(true);

  }

  void Update() {
    if (IsGrounded() && Input.GetKeyDown(KeyCode.Space) && !dead) {
      // && GameObject.Find("Player").transform.position.y == 0.5
      rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);

    }

    if (GameObject.Find("Player").transform.position.y <= 0) {
      SetFailText();

    }

    Rotation();

  }

  private bool IsGrounded() {
    //RaycastHit raycastHit = Physics.CheckCapsule(collider.bounds.center,new Vector3(collider.bounds.center.x,collider.bounds.min.y-0.1f,collider.bounds.center.z),0.18f);
    //RaycastHit raycastHit = Physics.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, new Vector3(0, 0, 0), Quaternion.Euler(0,0,0), 1f);

    //return raycastHit.collider != null;

    return Physics.Raycast(transform.position, -Vector3.up, floorDist + 0.5f);
  }

  void FixedUpdate() {
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);

    rb.AddForce(movement * speed);

  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("PickUp")) {
      other.gameObject.SetActive(false);
      count += 1;
      total -= 1;
      SetCountText();
      
    }

    if (other.gameObject.CompareTag("Enemy")) {
      //GameObject.Find("Player").SetActive(false);
      dead = true;

      countTextObject.SetActive(false);
      countdownObject.SetActive(false);
      failTextObject.SetActive(true);
      retryButton.SetActive(true);
      backToMenuButton.SetActive(true);

    }

  }

  void Rotation() {
   transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 4f, 0));

  }

}
