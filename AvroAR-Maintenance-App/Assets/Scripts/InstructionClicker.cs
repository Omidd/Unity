// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Adapted by Josh Kukulsky from CycleClicker, Feb 2018

using UnityEngine;
using System.Collections;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Examples.Prototyping;

/// <summary>
/// Advances a iCycle component on click
/// </summary>
public class InstructionClicker : MonoBehaviour, IInputClickHandler
{

    public GameObject CycleObject;
    private ICycle mCycleComp;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        mCycleComp = CycleObject.GetComponent<ICycle>();

        if (mCycleComp != null)
            mCycleComp.MoveNext();
    }
}