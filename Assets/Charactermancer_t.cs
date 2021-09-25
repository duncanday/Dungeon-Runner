using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermancer_t : MonoBehaviour
{
    // determine elements to use
    // determine combat types: read "Charactermancer"
}

/* list of Charactermancer qualities: 
 * ATTACK (BOOLEAN)
 * SPELL (BOOLEAN)
 * ~ THE ABOVE SERVES AS A FOUNDATION FOR "ABILITIES" ~
 * 
 * PASSIVE TRAIT (BOOLEAN)
 * MODIFIER TRAIT [BUFF/DEBUFF, OR OTHERWISE] (BOOLEAN)
 * TRANSFORMATIVE TRAIT (BOOLEAN)
 * 
 * ~ THE ABOVE SERVES AS TRAITS WHICH CHANGE THE INNATE NATURE OF A GIVEN ABILITY OR OTHERWISE ~
 * 
 * CAST DELAY (FLOAT)
 * CAST DURATION (FLOAT)
 * TARGET SPECIFIER (OBJECT)
 * VALID TARGET QUANTITIES (INTEGER)
 * RADIUS [AREA] OF EFFECT (CALCULATED FLOAT)
 * RESOURCE USED (STRING)
 * COMBO PIECE (BOOLEAN)
 * ALLOW MULTICAST
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

    // default bools are initialized as false.
    // default numerical primitives are initialized as 0, 0.0, or otherwise.

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

    private bool IS_ATTACK; // is this skill quality considered an attack? 
                            // this quality catalyzes combat and "manual" activation; if the skill does not have this designation, it cannot do damage.

    private bool IS_SPELL; // is this skill quality considered a spell? 
                           // this quality enables other skill methods via a read-only function. (if spell or spell is cast, then...)

    private bool IS_PASSIVE; // is this skill quality considered passive in nature? 
                             // this quality enables additional effects to be designated without requiring activation via the ATTACK or SPELL designations.

    private bool IS_MODIFIER; // is this skill quality considered a modifier? 
                              // this quality enables the alteration of attributes associated with characters.

    private bool IS_TRANSFORMATIVE; // is this skill quality considered transformative? 
                                    // this quality enables the skill to be temporarily replaced by ATTACK or SPELL activations.

    private float CAST_DELAY; // what is the duration of the delay before casting this skill occurs? 
                              // by design, the delay must decrement to 0 before the skill occurs, or any other skill can be cast.

    private float CAST_DURATION; // what is the duration of the skill's cast? 
                                 // naturally, as n ~> +inf, duration increases to +inf. computationally, this value must be capped at 240.0 seconds for game design purposes.
                                 // a value of 0.0f means that the cast is instantaneous after delay has been decremented to 0.
                                 // a value of exactly -1.0f will be translated to read "infinitely long." 
                                 // "infinitely long" means that the skill will always be activated and refreshed by the computer's framerate.

    private bool IS_TARGETED; // is this skill a targeted ability? 
                              // in FPS terms, think of how Titanfall's Smart Pistol doesn't require aiming (except by having the target within FOV).

    private GameObject TARGETS_SPECIFIED; // what are the GameObject references that the skill takes into account? 
                                          // > Targeted skill: create an abstraction container (when the skill is loaded on the rack.
                                          // Read the specified GameObject(s) applied by the targeting method (such as selecting via cursor click) and apply game methods.
                                          // > Untargeted skill: create an abstraction container (when the skill is loaded on the rack).
                                          // Read all specified GameObject(s) within the AREA OF EFFECT. Apply the appropriate and valid game methods.

    private readonly int VALID_TARGET_QUANTITY; // how many targets within the TARGETS_SPECIFIED container were considered "valid targets?" Debugging variable.


    private float AREA_OF_EFFECT; // this is a computational query. the current solution seems computationally heavy and is a rough draft.
                                  // four Vector2's can be determined from the skill's origin point, and from the "conclusion" target of the cast.
                                  // these vectors are normalized and then multiplied by this bespoke scalar variable.
                                  // furthermore, methods that employ AREA_OF_EFFECT create a bounded shape defined by a composite Bezier curve utilizing those 4 points.
                                  // it can otherwise use simpler shaping methods (circular, square, rectangular, triangular) to use.
                                  // AREA_OF_EFFECT will multiply the finalized shape (which is not 3-dimensional in this case) to expand its size.

    private string RESOURCE_USED; // what is the type of resource being used for this skill? a custom resource can be created and designated.
                                  // if no resource is designated, the skill won't require it.
                                  // this can be referenced via an enum as an alternative.

    private bool IS_COMBO; // the game will be using an in-game combo counting tracker. the number can be used for various numerical method purposes.
                           // if the skill specifies that this is a combo, any time an designation trigger occurs (attack hit/spellcast success), it adds to the counter.

    private bool ALLOW_MULTICAST; // a multicast skill/ability overrides the CAST_DELAY restrictions.
                                  // that is, a skill with this quality can cast during the CAST_DELAY restriction period.
                                  // this is useful for skills that are toggle on/off.

    
}