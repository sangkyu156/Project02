using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkillData
{
    //스킬이름은 항상 Pefeb이름과 같아야 한다. 그래야 Resources 폴더에서 가져옴
    public enum Skills
    {
        /**********1000**********/
        A = 1000,B,C,D,
        /**********900***********/

        /**********800***********/

        /**********700***********/

        /**********600***********/

        /**********500***********/

        /**********400***********/

        /**********300***********/

        /**********200***********/

        /**********100***********/
        
        /**********90************/

        /**********80************/

        /**********70************/

        /**********60************/

        /**********50************/
        E = 50,
        /**********40************/

        /**********30************/

        /**********20************/

        /**********10************/

    }

    public enum SkillPrice
    {
        //등급 별로 가격나눔 임시로 원,투,쓰리
        One = 100, Two = 200, Three = 300
    }
}
