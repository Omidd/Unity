using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionController : MonoBehaviour {

    public GameObject MenuInstruction0;
    public GameObject MenuInstruction1;
    public GameObject MenuInstruction2;
    public GameObject MenuInstruction3;
    public GameObject MenuInstruction4;
    public GameObject MenuInstruction5;
    public GameObject MenuInstruction6;
    public GameObject MenuInstruction7;
    public GameObject MenuInstruction8;
    public GameObject MenuInstruction9;
    public GameObject MenuInstruction10;
    public GameObject MenuInstruction11;

    public GameObject AssemblyIntruction1;
    public GameObject AssemblyIntruction2;
    public GameObject AssemblyIntruction3;
    public GameObject AssemblyIntruction4;
    public GameObject AssemblyIntruction5;
    public GameObject AssemblyIntruction6;
    public GameObject AssemblyIntruction7;
    public GameObject AssemblyIntruction8;
    public GameObject AssemblyIntruction9;
    public GameObject AssemblyIntruction10;
    public GameObject AssemblyIntruction11;

    public ClickCounter ClickCounter;
    public bool EnableTask;

    // Use this for initialization
    void Start () {
        EnableInstruction0();
        UpdateInstruction();
        //ClickCounter.ResetClickCount();
    }
	
	// Update is called once per frame
	void Update () {
		
    }

    public void UpdateInstruction()
    {
        if (ClickCounter.GetClickCount() == 0)
            EnableInstruction0();

        if (ClickCounter.GetClickCount() == 1)
            EnableInstruction1();

        if (ClickCounter.GetClickCount() == 2)
            EnableInstruction2();

        if (ClickCounter.GetClickCount() == 3)
            EnableInstruction3();

        if (ClickCounter.GetClickCount() == 4)
            EnableInstruction4();

        if (ClickCounter.GetClickCount() == 5)
            EnableInstruction5();

        if (ClickCounter.GetClickCount() == 6)
            EnableInstruction6();

        if (ClickCounter.GetClickCount() == 7)
            EnableInstruction7();

        if (ClickCounter.GetClickCount() == 8)
            EnableInstruction8();

        if (ClickCounter.GetClickCount() == 9)
            EnableInstruction9();

        if (ClickCounter.GetClickCount() == 10)
            EnableInstruction10();

        if (ClickCounter.GetClickCount() == 11)
            EnableInstruction11();
    }

    private void EnableInstruction0()
    {
        MenuInstruction0.SetActive(true);   //active
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction1()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(true);   //active
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(true);   //active
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction2()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(true);   //active
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(true);   //active
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction3()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(true);   //active
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(true);   //active
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction4()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(true);   //active
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(true);   //active
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction5()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(true);   //active
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(true);   //active
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction6()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(true);   //active
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(true);   //active
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction7()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(true);   //active
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(true);   //active
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction8()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(true);   //active
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(true);   //active
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction9()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(true);   //active
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(true);   //active
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction10()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(true);   //active
        MenuInstruction11.SetActive(false);

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(true);   //active
        AssemblyIntruction11.SetActive(false);
    }

    private void EnableInstruction11()
    {
        MenuInstruction0.SetActive(false);
        MenuInstruction1.SetActive(false);
        MenuInstruction2.SetActive(false);
        MenuInstruction3.SetActive(false);
        MenuInstruction4.SetActive(false);
        MenuInstruction5.SetActive(false);
        MenuInstruction6.SetActive(false);
        MenuInstruction7.SetActive(false);
        MenuInstruction8.SetActive(false);
        MenuInstruction9.SetActive(false);
        MenuInstruction10.SetActive(false);
        MenuInstruction11.SetActive(true);   //active

        AssemblyIntruction1.SetActive(false);
        AssemblyIntruction2.SetActive(false);
        AssemblyIntruction3.SetActive(false);
        AssemblyIntruction4.SetActive(false);
        AssemblyIntruction5.SetActive(false);
        AssemblyIntruction6.SetActive(false);
        AssemblyIntruction7.SetActive(false);
        AssemblyIntruction8.SetActive(false);
        AssemblyIntruction9.SetActive(false);
        AssemblyIntruction10.SetActive(false);
        AssemblyIntruction11.SetActive(true);   //active
    }
}
