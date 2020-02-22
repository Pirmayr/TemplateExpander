# Dokumentation

Version 1

## Klasse TemplateExpander::Expander

### Private Konstanten

#### variable const string DefaultFilter

#### variable const string DelimiterVariable

The delimiter for variables in templates.

#### variable const string ExtensionTemplate

#### variable const string NameAlias

#### variable const string NameFilter

#### variable const string NameReplacement

#### variable const char SeparatorFormat

The character used for separating format from tag in variable-names.

#### variable const string ValueName

#### variable const string VariableNameValue

### Öffentliche statische Methoden

#### Funktion string Expansion

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| format | string | |
| templatesDirectory | string | |
| root | XmlNode | |
| parameters | Parameters | |

### Private statische Methoden

#### Funktion bool Accept

Checks, if the node is accepted for processing.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| node | XmlNode | Node |
| parameters | Parameters | Parameters |

Rückgabewert

If the node is accepted, true is returned; otherwise, false.

#### Funktion void AddExpansion

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| expansions | Strings | |
| key | string | |
| value | string | |
| parameters | Parameters | |

#### Funktion void AddExpansions

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| format | string | |
| nodes | IEnumerable | |
| isValueTemplate | bool | |
| expansions | Strings | |
| parameters | Parameters | |
| templates | Strings | |
| stringsStack | StringsStack | |

#### Funktion string CleanValue

Cleans string.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | String to be cleaned. |
| removeCarriageReturn | bool | Should carriage-returns be removed by replacing them with blanks? |

Rückgabewert

Cleaned string.

#### Funktion string Expansion

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| format | string | |
| node | XmlNode | |
| parameters | Parameters | |
| templates | Strings | |
| expansionsStack | StringsStack | |

#### Funktion HashSet< string > GetFormats

Gets the requested formats from the given variables.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| variables | HashSet< string > | Variables |
| defaultFormat | string | A format, that is always contained in the result. |

Rückgabewert

The requested formats.

Example: Inmdtoc:headingthe formatmdtocis requested for the variableheading.

#### Funktion string GetTemplate

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templateSet | string | |
| tag | string | |
| templates | Strings | |

#### Funktion HashSet< string > GetVariables

Gets the variables contained in a text.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | Text to be searched for variables. |

Rückgabewert

The variables found in the text.

#### Funktion Strings ReadTemplates

Reads all template-files in a directory.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templatesDirectory | string | Directory with template-files. |

Rückgabewert

A dictionary with the templates read.

The keys of the dictionary are the filenames (without extension) of the template-files. The keys in turn are the names of nodes or attributes in the XML-file.

#### Funktion string RemoveVariables

Removes unused variables from the given text.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | Removes unused variables from the given text. |

This is a remark.

#### Funktion string ReplaceExhaustive

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | |
| searchString | string | |
| replacement | string | |

#### Funktion string ReplaceWord

Replaces word in text.

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | this string | Text |
| word | string | Word |
| replacement | string | Replacement |
| options | RegexOptions | Options |

Rückgabewert

String with word replaced.

## Klasse TemplateExpander::Parameters

### Private Konstanten

#### variable const char SeparatorValues

### Öffentliche statische Methoden

#### Funktion Parameters ReadParameters

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| path | string | |
| target | string | |
| format | string | |

### public-func

#### Funktion string Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

#### Funktion Strings Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |

#### Funktion string[] GetValues

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

### Private statische Methoden

#### Funktion bool Accept

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| target | string | |
| currentTarget | string | |
| format | string | |
| currentFormat | string | |

## Klasse TemplateExpander::Program

### Private statische Methoden

#### Funktion void ExecuteProgram

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| command | string | |
| arguments | string | |
| workingDirectory | string | |

#### Funktion void Main

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| arguments | string[] | |

#### Funktion void OnDataReceived

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| sender | object | |
| e | DataReceivedEventArgs | |

#### Funktion XmlDocument ReadXml

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| xmlPath | string | |

## Klasse TemplateExpander::Strings

### public-func

#### Funktion void Append

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| key | string | |
| value | string | |

## Klasse TemplateExpander::StringsStack

### public-func

#### Funktion Strings GetActiveValues

## Namensraum System

## Namensraum System::Collections

## Namensraum System::Collections::Generic

## Namensraum System::Diagnostics

## Namensraum System::IO

## Namensraum System::Linq

## Namensraum System::Runtime::InteropServices

## Namensraum System::Text

## Namensraum System::Text::RegularExpressions

## Namensraum System::Xml

## Namensraum System::Xml::Xsl

## Namensraum TemplateExpander

## Datei Expander.cs

## Datei manual.md

## Datei Parameters.cs

## Datei Program.cs

## Datei Strings.cs

## Datei StringsStack.cs

## Documentation

## Name

TemplateExpander

## Übersicht

TemplateExpander format templates-directory xml-path output-path parameters-path

## Beschreibung

TemplateExpander liest eine XML-Datei und transformiert sie anhand der angegebenen Schablonen.

## Optionen

## format

Gibt an, welcher Vorlagensatz verwendet werden soll. Erster Teil des Vorlagennamens. Beispiel: "md.para.txt". Das Format ist hier "md" und die Vorlage ist für einen Tag oder ein Attribut "para".

## Version

6