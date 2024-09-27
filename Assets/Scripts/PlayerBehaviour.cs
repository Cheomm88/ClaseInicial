using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int coins = 0;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSFX;
    public AudioClip specialCoinSFX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            Debug.Log("He tocado una moneda");
            coins++;
            AudioSource.PlayClipAtPoint(coinSFX, transform.position);

        }
        else if (other.CompareTag("SpecialCoin"))
        {
            Debug.Log("He tocado una moneda especial");
            coins += 5; //coins = coins + 5;
            AudioSource.PlayClipAtPoint(specialCoinSFX, transform.position);
        }

        if (other.tag.Contains("Coin"))
        {
            coinsText.text = coins.ToString() ;
            other.gameObject.SetActive(false);
        }
        
    }
}
