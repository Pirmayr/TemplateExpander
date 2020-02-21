# Dokumentation

Version 1

## Klasse TemplateExpander::Expander

### private-static-attrib

#### variable const string DefaultFilter

#### variable const string DelimiterVariable

#### variable const string ExtensionTemplate

#### variable const string NameAlias

#### variable const string NameFilter

#### variable const string NameReplacement

#### variable const char SeparatorFormat

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

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| node | XmlNode | Node |
| parameters | Parameters | Parameters |

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
| prefixVariable | bool | |
| expansions | Strings | |
| parameters | Parameters | |
| templates | Strings | |
| stringsStack | StringsStack | |

#### Funktion string CleanValue

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | String to be cleaned. |
| removeCarriageReturn | bool | Should carriage-returns be removed by replacing them with blanks? |

#### Funktion string Expansion

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| format | string | |
| node | XmlNode | |
| parameters | Parameters | |
| templates | Strings | |
| expansionsStack | StringsStack | |

#### Funktion HashSet< string > GetFormats

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| variables | HashSet< string > | Variables |

#### Funktion string GetTemplate

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templateSet | string | |
| tag | string | |
| templates | Strings | |

#### Funktion HashSet< string > GetVariables

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | |

#### Funktion Strings ReadTemplates

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templatesDirectory | string | Directory with template-files. |

#### Funktion string RemoveVariables

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | Removes unused variables from the given text. |

#### Funktion string ReplaceExhaustive

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | |
| searchString | string | |
| replacement | string | |

#### Funktion string ReplaceWord

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | this string | Text |
| word | string | Word |
| replacement | string | Replacement |
| options | RegexOptions | Options |

### private-static-attrib

#### variable const string DefaultFilter

#### variable const string DelimiterVariable

#### variable const string ExtensionTemplate

#### variable const string NameAlias

#### variable const string NameFilter

#### variable const string NameReplacement

#### variable const char SeparatorFormat

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

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| node | XmlNode | Node |
| parameters | Parameters | Parameters |

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
| prefixVariable | bool | |
| expansions | Strings | |
| parameters | Parameters | |
| templates | Strings | |
| stringsStack | StringsStack | |

#### Funktion string CleanValue

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | String to be cleaned. |
| removeCarriageReturn | bool | Should carriage-returns be removed by replacing them with blanks? |

#### Funktion string Expansion

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| format | string | |
| node | XmlNode | |
| parameters | Parameters | |
| templates | Strings | |
| expansionsStack | StringsStack | |

#### Funktion HashSet< string > GetFormats

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| variables | HashSet< string > | Variables |

#### Funktion string GetTemplate

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templateSet | string | |
| tag | string | |
| templates | Strings | |

#### Funktion HashSet< string > GetVariables

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | |

#### Funktion Strings ReadTemplates

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| templatesDirectory | string | Directory with template-files. |

#### Funktion string RemoveVariables

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | string | Removes unused variables from the given text. |

#### Funktion string ReplaceExhaustive

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| value | string | |
| searchString | string | |
| replacement | string | |

#### Funktion string ReplaceWord

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| text | this string | Text |
| word | string | Word |
| replacement | string | Replacement |
| options | RegexOptions | Options |

## Klasse TemplateExpander::Parameters

### public-static-attrib

#### variable const char SeparatorValues

### Öffentliche statische Methoden

#### Funktion bool Accept

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| target | string | |
| currentTarget | string | |
| format | string | |
| currentFormat | string | |

#### Funktion Parameters ReadParameters

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| path | string | |
| target | string | |
| format | string | |

### public-func

#### Funktion Strings Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |

#### Funktion string Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

#### Funktion string[] GetValues

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

### public-static-attrib

#### variable const char SeparatorValues

### Öffentliche statische Methoden

#### Funktion bool Accept

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| target | string | |
| currentTarget | string | |
| format | string | |
| currentFormat | string | |

#### Funktion Parameters ReadParameters

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| path | string | |
| target | string | |
| format | string | |

### public-func

#### Funktion Strings Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |

#### Funktion string Get

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

#### Funktion string[] GetValues

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| name | string | |
| key | string | |
| defaultValue | string | |

## Klasse TemplateExpander::Program

### Private statische Methoden

#### Funktion void AddDoxygenCompounds

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| xmlPath | string | |
| root | XmlDocument | |

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

### Private statische Methoden

#### Funktion void AddDoxygenCompounds

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| xmlPath | string | |
| root | XmlDocument | |

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

### public-func

#### Funktion void Append

| Name | Typ | Beschreibung |
| :--- | :--- |	:--- |
| key | string | |
| value | string | |

## Klasse TemplateExpander::StringsStack

### public-func

#### Funktion Strings GetActiveValues

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

### Name

### Übersicht

### Beschreibung

### Optionen

### Version

### Noch ein Abschnitt