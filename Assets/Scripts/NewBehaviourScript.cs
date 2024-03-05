using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private PlayerInput playerInput;
    private Transform cameraTransform;
    //[SerializeField] private Transform baslangýc;
    [SerializeField] private GameObject kBaligiS;
    public Transform backside;
    private GameObject mahsur;


    
    public float playerSpeed = 5.0f;
    
   

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
        cameraTransform = Camera.main.transform;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mahsur"))
        {
            other.gameObject.transform.position = backside.transform.position;
            other.gameObject.transform.parent = backside.transform;
            playerSpeed = 8f;
        }
        if (other.CompareTag("kbaligi"))
        {
            Health.instance.health--;
            Destroy(other.gameObject);
            KbaligiSpawner();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        playerSpeed = 15f;
    }

    void Update()
    {


        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        move = move.x * cameraTransform.right + move.z * cameraTransform.forward;
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
    void KbaligiSpawner()
    {
        Vector3 index = new Vector3(Random.Range(-20, 30), 1, Random.Range(-20, 20));
        Instantiate(kBaligiS, index, Quaternion.identity);
    }

}
