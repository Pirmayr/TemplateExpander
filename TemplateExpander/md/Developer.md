# Inhalt

## Klasse TemplateExpander::Expander<br>
### Öffentliche statische Methoden<br>
<a href="#FunktionstringExpansion">Funktion string Expansion</a><br>
<a href="#FunktionstringReplaceWord">Funktion string ReplaceWord</a><br>
### Private statische Methoden<br>
<a href="#FunktionboolAccept">Funktion bool Accept</a><br>
<a href="#FunktionvoidAddExpansion">Funktion void AddExpansion</a><br>
<a href="#FunktionvoidAddExpansions">Funktion void AddExpansions</a><br>
<a href="#FunktionstringCleanValue">Funktion string CleanValue</a><br>
<a href="#FunktionstringExpansion">Funktion string Expansion</a><br>
<a href="#FunktionHashSet< string >GetFormats">Funktion HashSet< string > GetFormats</a><br>
<a href="#FunktionstringGetTemplate">Funktion string GetTemplate</a><br>
<a href="#FunktionHashSet< string >GetVariables">Funktion HashSet< string > GetVariables</a><br>
<a href="#FunktionParametersReadParameters">Funktion Parameters ReadParameters</a><br>
<a href="#FunktionStringsReadTemplates">Funktion Strings ReadTemplates</a><br>
<a href="#FunktionstringRemoveVariables">Funktion string RemoveVariables</a><br>
<a href="#FunktionstringReplaceExhaustive">Funktion string ReplaceExhaustive</a><br>

# Klasse TemplateExpander::Expander

## Öffentliche statische Methoden

<a id="FunktionstringExpansion"></a>
### Funktion string Expansion

<a id="FunktionstringReplaceWord"></a>
### Funktion string ReplaceWord

Replaces word in text.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| text | Text |
| word | Word |
| replacement | Replacement |
| options | Options |

#### Rückgabewert

String with word replaced.

## Private statische Methoden

<a id="FunktionboolAccept"></a>
### Funktion bool Accept

Checks, if the node is accepted for processing.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| node | Node |
| Parameter | Parameters |

#### Rückgabewert

"true" if the node ist accepted; otherwise, false.

<a id="FunktionvoidAddExpansion"></a>
### Funktion void AddExpansion

<a id="FunktionvoidAddExpansions"></a>
### Funktion void AddExpansions

<a id="FunktionstringCleanValue"></a>
### Funktion string CleanValue

Cleans string.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| Value | String to be cleaned. |
| removeCarriageReturn | Should carriage-returns be removed by replacing them with blanks? |

#### Rückgabewert

Cleaned string.

<a id="FunktionstringExpansion"></a>
### Funktion string Expansion

<a id="FunktionHashSet< string >GetFormats"></a>
### Funktion HashSet< string > GetFormats

<a id="FunktionstringGetTemplate"></a>
### Funktion string GetTemplate

<a id="FunktionHashSet< string >GetVariables"></a>
### Funktion HashSet< string > GetVariables

<a id="FunktionParametersReadParameters"></a>
### Funktion Parameters ReadParameters

<a id="FunktionStringsReadTemplates"></a>
### Funktion Strings ReadTemplates

<a id="FunktionstringRemoveVariables"></a>
### Funktion string RemoveVariables

<a id="FunktionstringReplaceExhaustive"></a>
### Funktion string ReplaceExhaustive