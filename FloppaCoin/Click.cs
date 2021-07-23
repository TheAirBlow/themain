using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
	public GameObject text_coin;

	public GameObject img;

	public Sprite img1;

	public Sprite img2;

	public double coin;

	public double add_coin = 1.0;

	private void Start()
	{
	}

	private void Update()
	{
		text_coin.GetComponent<Text>().text = "FloppaCoin = " + coin;
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}

	private void OnMouseDown()
	{
		coin += add_coin;
		img.GetComponent<SpriteRenderer>().sprite = img1;
	}

	private void OnMouseUp()
	{
		img.GetComponent<SpriteRenderer>().sprite = img2;
	}
}
