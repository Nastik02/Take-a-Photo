using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFrames : Progressible
{
   public void Take()
    {
        Value -= 1;
    }
}
