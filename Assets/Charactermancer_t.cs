using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermancer_t : MonoBehaviour
{
    // determine elements to use
    // determine combat types: read "Charactermancer"
}

/* list of Charactermancer qualities: 
 * BASIC ATTACK (BOOLEAN)
 * SPELL (BOOLEAN)
 * ~ THE ABOVE SERVES AS A FOUNDATION FOR "ABILITIES" ~
 * 
 * PASSIVE TRAIT (BOOLEAN)
 * MODIFIER TRAIT [BUFF/DEBUFF, OR OTHERWISE] (BOOLEAN)
 * TRANSFORMATIVE TRAIT (BOOLEAN)
 * 
 * ~ THE ABOVE SERVES AS TRAITS WHICH CHANGE THE INNATE NATURE OF A GIVEN ABILITY OR OTHERWISE ~
 * 
 * CAST DURATION (FLOAT)
 * TARGET SPECIFIER (OBJECT)
 * VALID TARGET QUANTITIES (INTEGER)
 * RADIUS [AREA] OF EFFECT (CALCULATED FLOAT)
 * RESOURCE USED (STRING)
 * COMBO PIECE (BOOLEAN)
 * CHANNELED (BOOLEAN)
 * MULTICHANNELED (BOOLEAN)
 * ~ THE ABOVE SERVES AS DESCRIPTORS THAT CAN BE MODIFIED FOR ABILITIES OR OTHERWISE ~
 * 
 */

// Generate an empty game object using this framework.

public class Charactermancer
{
    public void MakeCharacterContainer()
    {
        GameObject CONTAINER_CHARACTER = new GameObject("CHARACTER CONTAINER"); // can insert components in arg params with typeof(ComponentType)
    }

    // detail the above traits and elements in serializable fields to enable hot reloading and dynamic iterative design.

    // default bools are set to false.
    /* 
     * 
     * 
     * skills are the container for skill qualities. skill qualities can be housed by the skill container to an arbitrarily infinite number.
     * 
     * the reason to abstract skills out to have qualities is to allow malleability of skill generation.
     * 
     * a skill that has the qualities of an attack, spell, and passive, can house the meanings of the aforementioned qualities;
     * that is, there are aspects to the skill that are passive ("increase on-hit damage" as long as the skill is "on-the-rack");
     * there are aspects to the skill that are spell-associative ("whenever a spell is cast, increase the character's attributes");
     * and there are aspects to the skill that are attack-based ("whenever this character attacks, do action x").
     * 
     * 
     * 
     * */

    private bool IS_BASICATTACK; // is this skill quality considered an attack? attacks count towards combo counters.
    private bool IS_SPELL; // is this skill quality considered a spell? spells do not count towards combo counters.
    private bool IS_PASSIVE; // is this
    private bool IS_MODIFIER;
    private bool IS_TRANSFORMATIVE;
    
}