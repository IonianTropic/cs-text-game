namespace Engine.Lextools;
/* Grammar example
 *  [Sentance] => "The room contains a " + [List]
 *  [List]
 *      => [Item]
 *      => [Items] + " and " + [Item]
 *  [Items]
 *      => [Item] + ", " + [Items]
 *      => [Item]
 *  [Item]
 *      => "\."
*/

/// <summary>
/// LexGen works as a reverse string parser
/// taking a tree of lexical tokens and a tree of rules
/// producing a string from successive calls to String.Format()
/// </summary>
public class LexGen {
    public LexGen() {

    }
}
