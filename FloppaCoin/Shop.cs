using UnityEngine;

public class Shop : MonoBehaviour
{
	public GameObject main;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Buy1()
	{
		if (main.GetComponent<Click>().coin >= 100.0)
		{
			main.GetComponent<Click>().add_coin += 1.0;
			main.GetComponent<Click>().coin -= 100.0;
		}
	}
}
