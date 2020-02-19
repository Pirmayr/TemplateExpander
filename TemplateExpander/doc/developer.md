# Inhalt

## Klasse TemplateExpander::Expander<br>
### Öffentliche statische Methoden<br>
<a href="#FunktionstringExpansion">Funktion string Expansion</a><br>
### Private statische Methoden<br>
<a href="#FunktionboolAccept">Funktion bool Accept</a><br>
<a href="#FunktionvoidAddExpansion">Funktion void AddExpansion</a><br>
<a href="#FunktionvoidAddExpansions">Funktion void AddExpansions</a><br>
<a href="#FunktionstringCleanValue">Funktion string CleanValue</a><br>
<a href="#FunktionstringExpansion">Funktion string Expansion</a><br>
<a href="#FunktionHashSet< string >GetFormats">Funktion HashSet< string > GetFormats</a><br>
<a href="#FunktionstringGetTemplate">Funktion string GetTemplate</a><br>
<a href="#FunktionHashSet< string >GetVariables">Funktion HashSet< string > GetVariables</a><br>
<a href="#FunktionStringsReadTemplates">Funktion Strings ReadTemplates</a><br>
<a href="#FunktionstringRemoveVariables">Funktion string RemoveVariables</a><br>
<a href="#FunktionstringReplaceExhaustive">Funktion string ReplaceExhaustive</a><br>
<a href="#FunktionstringReplaceWord">Funktion string ReplaceWord</a><br>
## Klasse TemplateExpander::Program<br>
### Private statische Methoden<br>
<a href="#FunktionvoidAddDoxygenCompounds">Funktion void AddDoxygenCompounds</a><br>
<a href="#FunktionvoidExecuteProgram">Funktion void ExecuteProgram</a><br>
<a href="#FunktionvoidMain">Funktion void Main</a><br>
<a href="#FunktionvoidOnDataReceived">Funktion void OnDataReceived</a><br>
<a href="#FunktionXmlDocumentReadXml">Funktion XmlDocument ReadXml</a><br>

# Klasse TemplateExpander::Expander

## Öffentliche statische Methoden

<a id="FunktionstringExpansion"></a>
### Funktion Expansion

#### Declaration

<pre>string Expansion
(
    string format
    string templatesDirectory
    XmlNode root
    Parameters parameters
)
</pre>

## Private statische Methoden

<a id="FunktionboolAccept"></a>
### Funktion Accept

Checks, if the node is accepted for processing.

#### Declaration

<pre>bool Accept
(
    XmlNode node
    Parameters parameters
)
</pre>

#### Parameters

| Name | Beschreibung |
| :--- | :--- |
| node | Node |
| parameters | Parameters |

#### Rückgabewert

true if the node ist accepted; otherwise, false.

<a id="FunktionvoidAddExpansion"></a>
### Funktion AddExpansion

#### Declaration

<pre>void AddExpansion
(
    Strings expansions
    string key
    string value
    Parameters parameters
)
</pre>

<a id="FunktionvoidAddExpansions"></a>
### Funktion AddExpansions

#### Declaration

<pre>void AddExpansions
(
    string format
    IEnumerable nodes
    bool isValueTemplate
    bool prefixVariable
    Strings expansions
    Parameters parameters
    Strings templates
    StringsStack stringsStack
)
</pre>

<a id="FunktionstringCleanValue"></a>
### Funktion CleanValue

Cleans string.

#### Declaration

<pre>string CleanValue
(
    string value
    bool removeCarriageReturn
)
</pre>

#### Parameters

| Name | Beschreibung |
| :--- | :--- |
| value | String to be cleaned. |
| removeCarriageReturn | Should carriage-returns be removed by replacing them with blanks? |

#### Rückgabewert

Cleaned string.

<a id="FunktionstringExpansion"></a>
### Funktion Expansion

#### Declaration

<pre>string Expansion
(
    string format
    XmlNode node
    Parameters parameters
    Strings templates
    StringsStack expansionsStack
)
</pre>

<a id="FunktionHashSet< string >GetFormats"></a>
### Funktion GetFormats

Gets the requested formats from the given variables.

#### Declaration

<pre>HashSet< string > GetFormats
(
    HashSet< string > variables
)
</pre>

#### Parameters

| Name | Beschreibung |
| :--- | :--- |
| variables | Variables |

#### Rückgabewert

The requested formats.

#### Hinweise

Example: In _mdtoc:heading_ the format _mdtoc_ is requested for the variable _heading_ .

<a id="FunktionstringGetTemplate"></a>
### Funktion GetTemplate

#### Declaration

<pre>string GetTemplate
(
    string templateSet
    string tag
    Strings templates
)
</pre>

<a id="FunktionHashSet< string >GetVariables"></a>
### Funktion GetVariables

#### Declaration

<pre>HashSet< string > GetVariables
(
    string text
)
</pre>

<a id="FunktionStringsReadTemplates"></a>
### Funktion ReadTemplates

Reads all template-files in a directory.

#### Declaration

<pre>Strings ReadTemplates
(
    string templatesDirectory
)
</pre>

#### Parameters

| Name | Beschreibung |
| :--- | :--- |
| templatesDirectory | Directory with template-files. |

#### Rückgabewert

A dictionary with the templates read.

#### Hinweise

The keys of the dictionary are the filenames (without extension) of the template-files. The keys in turn are the names of nodes or attributes in the XML-file.

<a id="FunktionstringRemoveVariables"></a>
### Funktion RemoveVariables

Removes unused variables from the given text.

#### Declaration

<pre>string RemoveVariables
(
    string text
)
</pre>

This is a remark.

<a id="FunktionstringReplaceExhaustive"></a>
### Funktion ReplaceExhaustive

#### Declaration

<pre>string ReplaceExhaustive
(
    string value
    string searchString
    string replacement
)
</pre>

<a id="FunktionstringReplaceWord"></a>
### Funktion ReplaceWord

Replaces word in text.

#### Declaration

<pre>string ReplaceWord
(
    this string text
    string word
    string replacement
    RegexOptions options
)
</pre>

#### Parameters

| Name | Beschreibung |
| :--- | :--- |
| text | Text |
| word | Word |
| replacement | Replacement |
| options | Options |

#### Rückgabewert

String with word replaced.

# Klasse TemplateExpander::Program

## Private statische Methoden

<a id="FunktionvoidAddDoxygenCompounds"></a>
### Funktion AddDoxygenCompounds

#### Declaration

<pre>void AddDoxygenCompounds
(
    string xmlPath
    XmlDocument root
)
</pre>

<a id="FunktionvoidExecuteProgram"></a>
### Funktion ExecuteProgram

#### Declaration

<pre>void ExecuteProgram
(
    string command
    string arguments
    string workingDirectory
)
</pre>

<a id="FunktionvoidMain"></a>
### Funktion Main

#### Declaration

<pre>void Main
(
    string[] arguments
)
</pre>

<a id="FunktionvoidOnDataReceived"></a>
### Funktion OnDataReceived

#### Declaration

<pre>void OnDataReceived
(
    object sender
    DataReceivedEventArgs e
)
</pre>

<a id="FunktionXmlDocumentReadXml"></a>
### Funktion ReadXml

#### Declaration

<pre>XmlDocument ReadXml
(
    string xmlPath
)
</pre>