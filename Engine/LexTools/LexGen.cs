namespace Engine.Lextools;
/* -- Grammar example --
 *  [S]     => "The room contains a " + [list] + "\."
 *  [list]  => [item]
 *  [list]  => [items] + " and " + [item]
 *  [items] => [item]
 *  [items] => [Item] + ", " + [items]
 *  [item]  => ".*"
 *
 * -- Corresponding format strings --
 *  string fmt1 = "The room contains a {0}.";
 *  string fmt2 = "{0} and {1}";
 *  string fmt3 = "{0}, {1}";
 *
 * -- Desired Output --
 *  input = ["key","dagger", "blue potion", "gray map"]
 * Runs:
 *  i = String.Format(fmt3, "key", "dagger");
 *  i = String.Format(fmt3, i1, "blue potion");
 *  i = String.Format(fmt2, i2, "gray map");
 *  output = String.Format(fmt1, i);
 * OR
 *  output = String.Format(fmt1, 
 *          String.Format(fmt2, 
 *          String.Format(fmt3, 
 *          String.Format(fmt3, 
 *          "key", "dagger"), "blue potion"), "gray map"));
 *
 * -- Steps of execution --
 *  1. Build a syntax tree from input strings conforming to the Grammar's order of tokens
 *  2. Execute String.Format, traversing the string depth first from the bottom left
*/

/// <summary>
/// LexGen works as a reverse string parser
/// taking a tree of lexical tokens and a tree of rules
/// producing a string from successive calls to String.Format()
/// </summary>
public class LexGen {
    enum NonTerminals {

    }
    enum Terminals {
        
    }
}
