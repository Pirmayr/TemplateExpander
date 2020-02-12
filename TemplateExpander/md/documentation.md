# class TemplateExpander````::````Expander

## private-attrib

### variable const string DefaultFilter

### variable const string DelimiterVariable

### variable const string ExtensionTemplate

### variable const string NameAlias

### variable const string NameFilter

### variable const string NameReplacement

### variable const char SeparatorValues

### variable const string ValueName

### variable const string VariableNameValue

## public-static-func

### function string Expansion

## private-static-func

### function bool Accept

Checks, if the node is accepted for processing.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| node | Node |
| parameters | Parameters |

#### Rückgabewert

"true" if the node ist accepted; otherwise, false.

### function void AddExpansion

### function void AddExpansions

### function string CleanValue

### function string Expansion

### function string GetTemplate

### function Parameters ReadParameters

### function Strings ReadTemplates

### function string RemoveVariables

### function string ReplaceExhaustive

# class TemplateExpander````::````Expander````::````Parameters

## public-func

### function string Get

### function Strings Get

# class TemplateExpander````::````Expander````::````Strings

# class TemplateExpander````::````Program

## private-static-func

### function void AddDoxygenCompounds

### function void Main

### function XmlDocument ReadXml

# namespace System````::````Collections

# namespace System````::````Collections````::````Generic

# namespace System````::````IO

# namespace System````::````Linq

# namespace System````::````Text

# namespace System````::````Xml

# namespace TemplateExpander

# file Expander.cs

# file manual.md

# file Program.cs

# page md_manual

## Documentation for "TemplateExpanded"

### Synopsis

"TemplateExpander" is a command-line program, which read an XML-file and transforms it according to a given set of templates.