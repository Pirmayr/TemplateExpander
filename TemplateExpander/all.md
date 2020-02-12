# interface 3DEngine

#### remark

Stellt unter Anderem folgende Funktionalitäten zur Verfügung:

* Grafiken erstellen, speichern und laden.
* Grafikobjekte erstellen und bearbeiten
* Logging
* Snapshots

## property

### property long m_DefaultRoot

### property long m_hInstance

## public-func

### function HRESULT AddAutoalignMeasureElement

### function HRESULT AddCatchLine

### function HRESULT AddCatchLineAxis

### function HRESULT AddCatchLineOrientation

### function HRESULT AddCatchPoint

### function HRESULT AddCatchPointAxis

### function HRESULT AddCatchPointOrientation

### function HRESULT AddDefaultPos

### function HRESULT AddLineElement

### function HRESULT AddMeasureElement

### function HRESULT AddMeasureElementToView

Erzeugt ein Maß.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_PositionFromX | X-Koordinate des Maßanfangs. |
| double_PositionFromY | Y-Koordinate des Maßanfangs. |
| double_PositionFromZ | Z-Koordinate des Maßanfangs. |
| double_PositionFromX | X-Koordinate des Maßendes. |
| double_PositionFromY | Y-Koordinate des Maßendes. |
| double_PositionFromZ | Z-Koordinate des Maßendes. |
| BSTR_Text | Maßtext |
| BSTR_ViewId | Kennung der Ansicht, in der das Maß angezeigt werden soll. |

#### Rückgabewert

long ID des erzeugten Maßes.

#### remark

Das Maß wird zum Root-Objekt der Grafik hinzugefügt.

### function HRESULT AddObjectMeasureElement

### function HRESULT AddPickPoint

Fügt einem Objekt einen Pickpoint hinzu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idObj | Objekt-ID |
| BSTR_Name | Name des Pickpoints |
| double_PosX | X-Koordinate des Pickpoints |
| double_PosY | Y-Koordinate des Pickpoints |
| double_PosZ | Z-Koordinate des Pickpoints |

### function HRESULT AddTextElement

Erzeugt einen Text.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BSTR_Text | Text |
| BSTR_FontName | Zeichensatzname |
| double_Height | Texthöhe |
| double_Thickness | Textdicke |

#### Rückgabewert

long ID des erzeugten Textes.

#### remark

* Text sind Grafikobjekte, und haben daher auch einen Dicke (Tiefe). Üblicherweise erzeugt man Text mit sehr geringer Dicke (Bruchteile von Millimetern).
* Der erzeugte Text wird dem Root-Objekt der Grafik hinzugefügt.

### function HRESULT ArcLeft

Bewegt die "Turtle" in einem Kreisbogen nach links.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Angle | Winkel des Kreisbogens. |
| double_Radius | Radius des Kreisbogens. |

#### Rückgabewert

boolean Wenn die "Turtle" bewegt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT ArcRight

Bewegt die "Turtle" in einem Kreisbogen nach rechts.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Angle | Winkel des Kreisbogens. |
| double_Radius | Radius des Kreisbogens. |

#### Rückgabewert

boolean Wenn die "Turtle" bewegt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT Beautify

Sorgt dafür, dass bestimmte Kanten in der Grafik nicht dargestellt werden.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Angle | Winkel |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Unterschreitet der Winkel zwischen zwei Flächen den angegebenen Wert, wird die Kante zwischen den Flächen nicht dargestellt.

### function HRESULT Box

Erzeugt einen Quader.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_SizeX | Breite des Quaders. |
| double_SizeY | Tiefe des Quaders. |
| double_SizeZ | Höhe des Quaders. |

#### Rückgabewert

long ID des erzeugten Quaders.

#### remark

Der erzeugte Quader wird dem Root-Objekt der Grafik hinzugefügt.

### function HRESULT CatchAlign

### function HRESULT CatchAlignAny

### function HRESULT CompressEdges

### function HRESULT CompressFaces

### function HRESULT CompressPoints

### function HRESULT Cone

### function HRESULT Copy

Kopiert ein Objekt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idOriginal | ID des Objektes, das kopiert werden soll. |

#### Rückgabewert

long ID der Kopie.

#### remark

Es werden auch die Objekt-Attribute mitkopiert.

### function HRESULT CreateCatalog

### function HRESULT CreateDoubleAttribute

Legt ein Attribut vom Type "double" an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Wenn das Attribut bereits existiert, wird es unverändert belassen.

### function HRESULT CreateIntAttribute

Legt ein Attribut vom Type "long" an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

* Wenn das Attribut bereits existiert, wird es unverändert belassen.
* Die Funktion ist identisch mit der Funktion "CreateLongAttribute".

### function HRESULT CreateLongAttribute

Legt ein Attribut vom Type "long" an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

* Wenn das Attribut bereits existiert, wird es unverändert belassen.
* Die Funktion ist identisch mit der Funktion "CreateIntAttribute".

### function HRESULT CreateMaterial

### function HRESULT CreateNewJoint

### function HRESULT CreateNewObject

Erzeugt ein Objekt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BSTR_Name | Objektname |

#### Rückgabewert

long Wenn der Aufruf erfolgreich war, wird die ID des erzeugten Objekts zurückgegeben, sonst 0.

### function HRESULT CreateProducer

### function HRESULT CreateStringAttribute

Legt ein Attribut vom Type "BSTR" an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Wenn das Attribut bereits existiert, wird es unverändert belassen.

### function HRESULT Cut

Schneidet ein Objekt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| double_PositionX | X-Koordinate eines Punktes auf der Schnittebene. |
| double_PositionY | Y-Koordinate eines Punktes auf der Schnittebene. |
| double_PositionX | Z-Koordinate eines Punktes auf der Schnittebene. |
| double_AboveX | X-Koordinate eines Richtungsvektors zur Definition der Schnittebene. |
| double_AboveY | Y-Koordinate eines Richtungsvektors zur Definition der Schnittebene. |
| double_AboveZ | Z-Koordinate eines Richtungsvektors zur Definition der Schnittebene. |
| long_AboveId | ID des Schnittobjektes oberhalb der Schnittebene; kann 0 sein. |
| long_BelowId | ID des Schnittobjektes unterhalb der Schnittebene; kann 0 sein. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

An sich benötigt man einen Positionsvektor und zwei Richtungsvektoren, und im Raum eine Ebene zu definieren. Die Funktion kommt mit einem einzigen Richtungsvektor aus, weil implizit der Normalvektor in X- oder Y-Richtung als zweiter Richtungsvektor herangezogen wird. Wenn der Betrag des Kreuzproduktes aus Richtungsvektor und Normalvektor in X-Richtung größer als der Betrag des Kreuzproduktes aus Richtungsvektor und Normalvektor in Y-Richtung ist, wird der Normalvektor in X-Richtung als zweiter Richtungsvektor verwendet, sonst der Normalvektor in Y-Richtung.

### function HRESULT Cylinder

### function HRESULT DebugDlg

### function HRESULT DeGroup

Entfernt ein Kindobjekt von einem Elternobjekt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| Type_Name | ID des Kindobjekts. |

#### Rückgabewert

Type Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT DeleteAttribute

### function HRESULT DeletePickPoint

### function HRESULT DeleteTextureCoordinates

Löscht die Texturkoordinaten in den Geometrien des angegebenen Objekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idObj | Objekt-ID |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT Difference

Bildet die Differenz zweier Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId1 | ID des ersten Objekts |
| long_ObjId2 | ID des zweiten Objekts |

#### Rückgabewert

BOOL ID des Objektes mit der Geometrie, die sich aus ObjId1 - ObjId2 ergibt.

### function HRESULT EnableDeveloperMode

Wenn ein Wert ungleich 0 angegeben wird, dann wird der Entwicklermodus eingeschaltet. Wenn der Wert 0 eingegeben wird, dann wird der Entwicklermodus ausgeschaltet.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Enable | Wert der angibt, ob der Entwicklermodus ein- oder ausgeschaltet werden soll. |

### function HRESULT EnGroup

Fügt einem Elternobjekt ein Kindobjekt hinzu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| Type_Name | ID des Elternobjekts. |
| Type_Name | ID des Kindobjekts. |

#### Rückgabewert

Type Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT ExploreFile

### function HRESULT Extrude

### function HRESULT ExtrudePath

### function HRESULT FindAttribute

### function HRESULT FindMaterial

Sucht ein Material anhand von Hersteller, Katalog und Materialname.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Producer | Hersteller. |
| string_Catalog | Katalog. |
| string_Material | Materialname. |

#### Rückgabewert

long Falls das Material gefunden werden konnte, wird dessen Id zurückgegeben, andernfalls 0.

### function HRESULT ForceIntoBox

Limitiert ein Grafikobjekt auf den Bereich einer angegebenen Box.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Obj | Grafikobjekt. |
| long_Box | Box. |

#### Rückgabewert

long Neues, auf die angegebene Box beschränktes Objekt.

#### remark

Diese Funktion arbeitet wie "SqueezeIntoBox", nur dass ein neues Objekt zurückgegeben wird, und das ursprüngliche Objekt unverändert bleibt. Daher kann sie in geeigneten Fällen als Ersatz für "Intersection" verwendet werden.

### function HRESULT GetAmbientColor

### function HRESULT GetAttributeCount

### function HRESULT GetAttributeHeadPosition

### function HRESULT GetAttributeType

### function HRESULT GetBasePath

### function HRESULT GetCatalogCount

### function HRESULT GetCatalogHeadPosition

### function HRESULT GetCatalogPath

### function HRESULT GetColorProperties

### function HRESULT GetDefaultMaterialPath

### function HRESULT GetDiffuseColor

### function HRESULT GetDoubleAttributeValue

Ermittelt den Wert einen Attributs vom Typ "double".

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

double Wert

### function HRESULT GetElementAngles

### function HRESULT GetElementChildCount

### function HRESULT GetElementHeadPosition

Ermittelt die Anfangsposition der Kindobjektliste des angegebenen Elternobjekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| longlong_ObjId | ID des Elternobjekts. |

### function HRESULT GetElementLayer

### function HRESULT GetElementName

Ermittelt den Namen eines Objektes.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |

#### Rückgabewert

BSTR Objektname

### function HRESULT GetElementOrientation

### function HRESULT GetElementPosition

Ermittelt die Position eines Objektes.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| double_PosX | X-Koordinate der Position. |
| double_PosY | Y-Koordinate der Position. |
| double_PosZ | Z-Koordinate der Position. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT GetElementSize

Ermittelt die Größe des angegebenen Objekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| double*_SizeX | Breite. |
| double*_SizeY | Tiefe. |
| double*_SizeZ | Höhe. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT GetElementVisibility

### function HRESULT GetExploreHeadPosition

### function HRESULT GetFather

### function HRESULT GetIntAttributeValue

Ermittelt den Wert einen Attributs vom Typ "long".

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

long Wert

#### remark

Die Funktion ist identisch mit der Funktion "GetLongAttributeValue".

### function HRESULT GetInterface

### function HRESULT GetLongAttributeValue

Ermittelt den Wert einen Attributs vom Typ "long".

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

long Wert

#### remark

Die Funktion ist identisch mit der Funktion "GetIntAttributeValue".

### function HRESULT GetMaterialHeadPosition

### function HRESULT GetMaterialPool

### function HRESULT GetMeasureDefaultColor

### function HRESULT GetNextAttribute

### function HRESULT GetNextCatalog

### function HRESULT GetNextElement

Ermittelt das nächste Kindobjekt in der Kindobjektliste des angegebenen Elternobjekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | ID des Elternobjekts. |
| longlong*_Position | Position in der Kindobjektliste. |

#### Rückgabewert

longlong ID des nächsten Kindobjekts.! Ausgabe der Object-IDs aller Kindobjekte von "objectId": position = GetElementHeadPosition(objectId) WHILE position <> 0 DO currentObject = GetNextElement(objectId, position) MESSAGE Str$(currentObject) END

### function HRESULT GetNextExplore

### function HRESULT GetNextMaterial

### function HRESULT GetNextProducer

### function HRESULT GetPath

Gibt den Pfad, die die "Turtle" zurückgelegt hat, als Polylinie zurück.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |

#### Rückgabewert

Vector3DCollection Der Pfad, den die "Turtle" zurückgelegt hat, als Polylinie.

### function HRESULT GetPickPoint

### function HRESULT GetPrimitiveStringAttributeValue

Ermittelt den Wert eines String-Attributs im angegebenen Primitiv.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Primitive | Primitiv. |
| string_AttributeName | Name des Attributs. |
| string_AttributeValue | Der Wert des Attributs, falls das Attribut existiert, andernfalls ein Leerstring. |

#### Rückgabewert

boolean Wenn das Attribut existiert, wird "true" zurückgegeben, andernfalls "false".

### function HRESULT GetProducerCount

### function HRESULT GetProducerHeadPosition

### function HRESULT GetRootItem

Ermittelt das Root-Objekt der Grafik.

#### Rückgabewert

long Root-Objekt.

### function HRESULT GetSpecularColor

### function HRESULT GetStringAttributeValue

Ermittelt den Wert einen Attributs vom Typ "BSTR".

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### Rückgabewert

BSTR Wert

### function HRESULT GetTextElementFont

### function HRESULT GetTextElementHeight

### function HRESULT GetTextElementText

### function HRESULT GetTextElementThickness

### function HRESULT GetTexture

### function HRESULT GetValue

### function HRESULT GetVersion

### function HRESULT Intersection

Bildet die Schnittmenge zweier Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId1 | ID des ersten Objekts |
| long_ObjId2 | ID des zweiten Objekts |

#### Rückgabewert

BOOL ID des Objektes mit der Geometrie, die sich aus ObjId1 * ObjId2 ergibt.

### function HRESULT IsDeveloperModeEnabled

Ermittelt, ob der Entwicklermodus ein oder ausgeschaltet ist.

#### Rückgabewert

long Wird ein Wert ungleich 0 zurückgegeben, dann ist der Entwicklermodus eingeschaltet. Wird 0 zurückgegeben, dann ist der Entwicklermodus ausgeschaltet.

### function HRESULT IsModified

Ermittelt, ob es seit dem letzten Aufruf von "IsModified" Änderungen im Grafikkernel gegeben hat.

#### Rückgabewert

boolean Wenn es Änderungen im Grafikkernel gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function HRESULT IsObjectId

Ermittelt, ob eine Objekt-ID gültig ist.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |

#### Rückgabewert

BOOL Wenn die Objekt-ID gültig ist, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT KillObject

Entfernt ein Objekt aus der Grafik.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | ID des Objektes, das entfernt werden soll. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Ab dem Aufruf von "KillObject(id)" liefert "IsObjectId(id)" den Wert FALSE zurück.

### function HRESULT LoadFilter

### function HRESULT LoadObject

Lädt ein Objekt aus einer A3D-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_FileName | Pfad zur A3D-Datei. |
| string_ObjectName | Name des zu ladenden Objekts. |

#### Rückgabewert

long Die Objekt-ID, wenn das Objekt erfolgreich geladen werden konnte, andernfalls 0.

### function HRESULT LoadObjectEx

### function HRESULT Log

Schreibt die angegebene Meldung in die Log-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Msg | Meldung |

### function HRESULT Mirror

### function HRESULT MirrorEx

Erzeugt eine gespiegelte Kopie des angegebenen Objekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idOriginal | Objekt-ID |
| short_Axis | Achse, an der gespiegelt werden soll. |

#### Rückgabewert

long ID des erzeugten Objekts.

#### remark

Das erzeugte Objekte wird dem Root-Objekt der Grafik hinzugefügt.

### function HRESULT MoveForward

Bewegt die "Turtle" geradlinig in Richtung der aktuellen Ausrichtung.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Distance | Die Strecke, die die "Turtle" bewegt werden soll in mm. |

#### Rückgabewert

boolean Wenn die "Turtle" bewegt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT NewTurtle

Gibt eine neue "Turtle" zurück.

#### par

Turtle

#### Rückgabewert

long Die neue "Turtle".

### function HRESULT Objects

Liefert ein Dictionary aller Objekte im Baum, der vom angegebenen Objekt ausgeht.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Root | Objekt. |

#### Rückgabewert

Dictionary Dictionary aus Objekten.

### function HRESULT Primitives

Liefert ein Dictionary aller Primitiva im Baum, der vom angegebenen Objekt ausgeht.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt. |

#### Rückgabewert

Dictionary Dictionary aus Primitiva.

### function HRESULT RegisterViewer

### function HRESULT RotateBy

Rotiert ein Objekt um die angegebenen Werte.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| short_Axis | Die Rotationsachse. |
| double_RotCenterX | X-Koordinate des Rotationszentrums. |
| double_RotCenterY | Y-Koordinate des Rotationszentrums. |
| double_RotCenterZ | Z-Koordinate des Rotationszentrums. |
| double_Angle | Wert in Grad, um den rotiert werden soll. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Die Achsen lauten wie folgt:

* 1: X-Achse
* 2: Y-Achse
* 3: Z-Achse

### function HRESULT RotateTo

### function HRESULT RotationalSweep

### function HRESULT SaveElementToFile

Schreibt Grafikobjekt in eine A3d-Datei.

#### par

Save

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Id des Grafikobjektes. |
| string_FileName | Pfad der A3d-Datei. |
| string_ObjectName | Gewünschter Name des Objektes in der A3d-Datei. |

#### Rückgabewert

boolean Wenn das Objekt erfolgreich in die A3d-Datei geschrieben werden konnte, wird "true" zurückgegeben, sonst "false".

### function HRESULT SaveFileLink

### function HRESULT SaveMaterialsToFile

### function HRESULT ScaleBy

Ändert die Größe eines Objekts um die angegebenen Faktoren.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_x | Faktor in X-Richtung. |
| double_y | Faktor in Y-Richtung. |
| double_x | Faktor in Z-Richtung. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT ScaleTo

Ändert die Größe eines Objekts um die angegebenen Werte.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_x | Wert in X-Richtung. |
| double_y | Wert in Y-Richtung. |
| double_x | Wert in Z-Richtung. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT SeparatePrimitives

Verschiebt alle Primitiva, die im angegebenen Objekt enthalten sind, in separate Subobjekte. Nach der Operation enthält das ursprüngliche Objekt keine Primitive mehr. Es wird je Primitiv ein eigenes Subobjekt angelegt. Die Operation wird nur durchgeführt, wenn das Objekt mehr als ein Primitiv enthält.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId" | Das Objekt, dessen Primitiva verschoben werden sollen. |

#### Rückgabewert

boolean Erfolg?

### function HRESULT SetAmbientColor

### function HRESULT SetAutoStretchFactor

### function HRESULT SetBasePath

### function HRESULT SetCatalogPath

Setzt den Pfad zu einer Materialdatei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BSTR_ProducerName | Name des Herstellers |
| BSTR_CatalogName | Name des Katalogs |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT SetColorProperties

### function HRESULT SetDefaultMaterialPath

### function HRESULT SetDiffuseColor

### function HRESULT SetDoubleAttributeValue

### function HRESULT SetElementAngles

### function HRESULT SetElementLayer

Ordnet einem Objekt einen Layer zu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idObj | Objekt-ID |
| int_Layer | Die Nummer des Layers, der dem Objekt zugeordnet werden soll. |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Die Layer-Nummern beginnen bei 1.

### function HRESULT SetElementMaterial

Setzt das Material im angegebenen Objekt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_MaterialName | Materialname |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT SetElementName

### function HRESULT SetElementOrientation

### function HRESULT SetElementSelMaterial

### function HRESULT SetElementVisibility

### function HRESULT SetFlag

Setzt ein Flag zur Steuerung der Verarbeitung von Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Name | Name des Flags. |
| boolean_State | Wenn das Flag setzt werden soll, ist 1 zu übergehen; wenn es gelöscht werden soll, ist 0 zu übergeben. |

### function HRESULT SetHeading

Setzt die Ausrichtung der "Turtle".

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Angle | Ausrichtung der "Turtle" in Grad. |

#### Rückgabewert

boolean Wenn die Anfangsposition gesetzt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

#### remark

Eine Ausrichtung von 0 Grad bedeutet, daß die "Turtle" nach rechts zeigt.

### function HRESULT SetIntAttributeValue

### function HRESULT SetJointTo

### function HRESULT SetLogFile

Setzt den vollständigen Pfad zur Log-Datei. Wenn als Pfad eine Leerstring angegeben wird, dann wird keine Log-Datei erzeugt.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_LogPath | Vollständiger Pfad zur Log-Datei. |

### function HRESULT SetLongAttributeValue

### function HRESULT SetMeasureDefaultColor

Setzt die Standardfarbe für Bemaßungen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Red | Roter Anteil. |
| double_Green | Grüner Anteil. |
| double_Blue | Blauer Anteil. |

### function HRESULT SetMeasureDefaultFont

Setzt Standard-Zeichensatz und Standard-Texthöhe für Maße und freie Texte.

#### par

FreierText, Bemaßungen

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_FontName | Name des Standard-Zeichensatzes. |
| double_MeasureTextHeight | Standard-Texthöhe. |

#### remark

Die Werte werden bei der Erzeugung des nächsten Maßes oder freien Textes verwendet. Bereits bestehende Maße oder freie Texte bleiben unverändert.

### function HRESULT SetMeasureDefaultTextDist

Setzt den Standardabstand zwischen Maßen.

#### par

Bemaßungen

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double | MeasureTextDist Standardabstand. |

#### remark

Der Wert wird bei der Erzeugung des nächsten Maßes oder freien Textes verwendet. Bereits bestehende Maße oder freie Texte bleiben unverändert.

### function HRESULT SetMeasureDefaultUnit

Setzt Standardeinheit und Standardrundung für Maße.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| int_Unit | Standardeinheit; es gibt derzeit nur die Standardeinheit 0, d.h. Millimeter. |
| int_RoundTo | Zahl der Nachkommastellen. |

### function HRESULT SetMeasureFont

Neue Möglichkeit, die Größe des Textes anzugeben.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BSTR_fontName | Zeichensatzname. |

### function HRESULT SetModifiedElementMaterial

Setzt das Material eines Objektes, wobei die Textur modifiziert werden kann.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Obj | Grafikobjekt. |
| string_MaterialName | Materialname. |
| string_Modifications | Beschreibung der Modifikationen der Textur. |

#### remark

Die Prozedur legt automatisch ein neues Material an, der die modifizierte Texte zugewiesen wird. Der Materialname leitet sich aus dem angegebenen Materialname und der Beschreibung der Modifikationen ab. Derzeit gibt es drei Modifikationen:

* Rotate90
* VerticalMirror
* HorizontalMirror

### function HRESULT SetObjectRenderOffset

### function HRESULT SetPosition

Setzt die Anfangsposition der "Turtle".

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_X | X-Koordinate der Anfangsposition. |
| double_Y | Y-Koordinate der Anfangsposition. |

#### Rückgabewert

boolean Wenn die Anfangsposition gesetzt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT SetRecordPath

Setzt den Pfad zur Record-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_RecordPath | Pfad zur Record-Datei. |

#### remark

* In der Record-Datei zeichnet der Kernel die Abfolge bestimmter Funktionsaufrufe auf.
* Ist kein Pfad gesetzt, erfolgt keine Aufzeichnung.

### function HRESULT SetRedraw

Schaltet das Zeichnen der Grafik ein oder aus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BOOL_State | Wenn TRUE angegeben wird, wird das Zeichnen der Grafik eingeschaltet, sonst wird das Zeichnen der Grafik abgeschaltet. |

#### Rückgabewert

BOOL Voriger Status.

### function HRESULT SetSnapshotsDirectory

Setzt das Verzeichnis für die Snapshot-Dateien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_RecordPath | Verzeichnis für die Snapshot-Dateien. |

#### remark

* Der Kernel erstellt bei bestimmten Funktionsaufrufen Snapshots in Form von A3d-Dateien.
* Ist kein Directory gesetzt, werden keine Snapshots erzeugt.

### function HRESULT SetSpecularColor

### function HRESULT SetStringAttributeValue

Setzt ein String-Attribut in einem Objekt auf den angegebenen Wert.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Name des Attributs |
| BSTR_AttributeValue | String-Wert |

#### Rückgabewert

Type Wenn das Attribut erfolgreich gesetzt werden konnte, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT SetTextElementFont

### function HRESULT SetTextElementHeight

### function HRESULT SetTextElementText

### function HRESULT SetTextElementThickness

### function HRESULT SetTexture

### function HRESULT ShrinkPolygon3D

Verkleinert ein Polygon.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| V3DC_Polygon | Polygon, das verkleinert werden soll. |
| double_Amount | Betrag in mm, um den das Polygon verkleinert werden soll. |

#### remark

* Wird eine negative Zahl in "Amount" übergeben, so wird das Polygon vergrößert.
* Die Funktion kann z.B. für "ExtrudePath" verwendet werden, um den Extrusionspfad zu bearbeiten.

### function HRESULT SmoothElement

Sorgt dafür, dass Rundungen in der Grafik dargestellt werden.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Angle | Winkel |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

#### remark

Unterschreitet der Winkel zwischen zwei Flächen den angegebenen Wert, wird die Kante zwischen den Flächen gerundet dargestellt.

### function HRESULT Sphere

### function HRESULT SqueezeIntoBox

Limitiert ein Grafikobjekt auf den Bereich einer angegebenen Box.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idObj | Grafikobjekt. |
| long_idBox | Box. |

### function HRESULT Torus

### function HRESULT TranslateBy

Verschiebt ein Objekt um den angegebenen Richtungsvektor.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_x | X-Koordinate des Richtungsvektors. |
| double_y | Y-Koordinate des Richtungsvektors. |
| double_z | Z-Koordinate des Richtungsvektors. |

### function HRESULT TranslateTo

Verschiebt ein Objekt zur angegebenen Position.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| double_x | X-Koordinate der Position |
| double_y | Y-Koordinate der Position |
| double_z | Z-Koordinate der Position |

#### Rückgabewert

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT TurnLeft

Ändert die Ausrichtung der Turtle, indem sie um den angegebenen Winkel nach links gedreht wird.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Angle | Drehungswinkel. |

#### Rückgabewert

boolean Wenn die Ausrichtung geändert werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT TurnRight

Ändert die Ausrichtung der Turtle, indem sie um den angegebenen Winkel nach rechts gedreht wird.

#### par

Turtle

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Turtle | Die "Turtle". |
| double_Angle | Drehungswinkel. |

#### Rückgabewert

boolean Wenn die Ausrichtung geändert werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT Union

Bildet die Vereinigungsmenge zweier Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId1 | ID des ersten Objekts |
| long_ObjId2 | ID des zweiten Objekts |

#### Rückgabewert

BOOL ID des Objektes mit der Geometrie, die sich aus ObjId1 + ObjId2 ergibt.

### function HRESULT UnRegisterViewer

### function HRESULT UnSmoothElement

# interface OBJECTVIEWERLib::_DObjectViewer

#### remark

Arbeitet mit der 3D-Engine zusammen.! Initialisierung des 3D-OCX: kernel = new G3DKernel.G3DKernel viewer = new OBJECTVIEWER.ObjectViewerCtrl.1(form) viewer.UseKernelObject(kernel)

## property

### property Appearance id

## public-func

### function void Add2DLine

### function long Add3DLine

Fügt der Grafik eine 3D-Linie hinzu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| int_layer | Der Layer, in dem die Linie liegen soll. |
| double_x1 | X-Koordinate des Startpunktes. |
| double_y1 | Y-Koordinate des Startpunktes. |
| double_z1 | Z-Koordinate des Startpunktes. |
| double_x2 | X-Koordinate des Endpunktes. |
| double_y2 | Y-Koordinate des Endpunktes. |
| double_z2 | Z-Koordinate des Endpunktes. |
| int_color | Farbcode. |
| double_width | Breite der Linie. |
| int_style | Linientyp. |

#### Rückgabewert

int ID der hinzugefügten 3D-Linie.

#### remark

Die Farbcodes lauten wie folgt:

* 1: schwarz
* 2: braun
* 3: blau
* 4: purpur
* 5: grün
* 6: grau
* 7: gelb
* 8: rot
* 9: pink
* 10: hellblau
* 11: hellbraun
* 12: extra-helles Grau
* 13: weiß
* 14: orange

Die Linientypen lauten wie folgt:

* 1: durchgezogen
* 2: strichliert
* 3: punktiert
* 4: strichpunktiert

Weitere Hinweise:

* Mit Hilfe des Layers kann die Linie ein- und ausgeblendet werden.
* Die Breite der Linie entspricht derDefinition der Linienbreite in OpenGL.
* Mit Hilfe der ID kann die Linie durch Aufruf von "Remove3DLine" wieder entfernt werden.

### function void AddMenuItem

Fügt dem Kontextmenü einen Eintrag hinzu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BSTR_MenuString | Text des Eintrags. |
| short_EventId | ID des Eintrags. |

### function void AddMenuSeperator

### function void AddSubMenuItem

Fügt einem Menüeintrag ein Untermenü hinzu.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_ParentEventId | ID des Menüeintrags, dem ein Untermenü hinzugefügt werden soll. |
| short_EventId | ID des Menüeintrags, der hinzugefügt werden soll. |
| BSTR_MenuItemText | Test des Eintrags |

### function BOOL AreOriginAxisEnabled

### function BOOL AreRotationAxisEnabled

Ermittelt, ob die Anzeige der Kugel zur Drehung der Grafik eingeschaltet ist.

#### Rückgabewert

BOOL Wenn die Anzeige der Kugel zur Drehung der Grafik eingeschaltet ist, wird TRUE zurückgegeben, sonst FALSE.

### function BOOL Beautify

Versucht, die Darstellung eines Grafikobjektes zur verbessern,.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Grafikobjekt, dessen Darstellung verbessert werden soll. |

#### Rückgabewert

boolean Wenn die Funktion ohne Fehler durchgeführt werden konnte, wird der Wert 1 zurückgegeben, sonst der Wert 0. Die erfolgreiche Durchführung der Funktion bedeutet nicht automatisch, dass sich die Darstellung des Objektes tatsächlich verbessert hat.

### function void BeginDragElement

### function void CatchSubElements

### function BOOL ChangeSelectedText

Setzt den Text des zur Zeit markierten Textelements auf den angegebenen Wert.

#### par

FreeText

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| boolean_NewText | Der neue Text für das Textelement. |

#### Rückgabewert

boolean Wenn der neue Text erfolgreich gesetzt werden konnte, wird "true" zurückgegeben, sonst "false" (z.B. wenn zur Zeit kein Textelement markiert ist).

### function void CheckMenuItem

### function void ClearAll2DLines

### function void ClearAll3DLines

Löscht alle 3D-Linien.

### function void ClearSelection

### function void CopySceneryToClipboard

### function short CreateLight

### function BOOL DeleteImageEx

Entfernt eine oder alle Bitmaps, die mit "SetImageEx" hinzugefügt wurden.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ImageHandle | Handle der Bitmap, die entfernt werden soll. Den Handle erhält man als Rückgabewert von "SetImageEx". Wird 0 als Handle übergeben, werden alle Bitmaps gelöscht. |

#### Rückgabewert

BOOL Wenn die Funktion erfolgreich durchgeführt werden konnte, wird TRUE zurückgegeben, andernfalls FALSE.

### function BOOL DeleteLight

### function BOOL DeleteMenuItem

### function BOOL DeleteMenuSeperator

### function BOOL DeleteSelectedText

Löscht das zur Zeit markierte Textelement.

#### par

FreeText

#### Rückgabewert

boolean Wenn das Textelement erfolgreich gelöscht werden konnte, wird "true" zurückgegeben, sonst "false" (z.B. wenn zur Zeit kein Textelement markiert ist).

### function void DisableMenuItem

Deaktiviert einen Menüeintrag.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_EventId | ID des Eintrags. |

### function void DragElement

### function short ElementChanged

Ermittelt, ob sich die Szenerie im Zusammenhang mit dem Selektieren von Pickpunkten geändert hat.

#### Rückgabewert

short Wenn es eine Änderung gegeben hat, wird ein Wert ungleich 0 zurückgegeben, andernfalls 0.

#### remark

Als Nebeneffekt wird durch den Aufruf der Funktion das Neuzeichnen der Szenerie angestoßen.

### function void EnableAutoAdjustView

### function void EnableAutoLighting

Schaltet die automatische Beleuchtung der Szenerie ein bzw. aus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| boolean_Enable | Automatische Beleuchtung ein- oder ausschalten? |

#### remark

Das System versucht bei eingeschalteter automatischer Beleuchtung verschiedene Maßnahmen zu ergreifen, um die empfundene Bildqualität zu verbessern

* Einschalten von Glanzlichern bei Texturen. Hölzer erscheinen damit z.B. wie lackiert.
* Veränderung von Materialdefinitionen, um diffuse bzw. spekulare Effekte zu verstärken.

### function HRESULT EnableDeveloperMode

Wenn ein Wert ungleich 0 angegeben wird, dann wird der Entwicklermodus eingeschaltet. Wenn der Wert 0 eingegeben wird, dann wird der Entwicklermodus ausgeschaltet.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Enable | Wert der angibt, ob der Entwicklermodus ein- oder ausgeschaltet werden soll. |

### function void EnableElementMove

### function void EnableMenuItem

Aktiviert einen Menüeintrag.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_EventId | ID des Eintrags |

### function void EnableOriginAxis

Schaltet die Anzeige der Koordinatenachsen ein oder aus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BOOL_Enable | Koordinatenachsen ein oder ausschalten. Wird TRUE übergeben, werden die Koordinatenachsen eingeschaltet, sonst ausgeschaltet. |

### function void EnablePickMode

Setzt den Pickmodus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_Mode | Neuer Pickmodus. |

#### remark

Folgende Modi sind möglich:

* 0: MMODE_NONE
* 1: MMODE_ZOOM
* 2: MMODE_VIEW
* 3: MMODE_MOVE
* 4: MMODE_IDENTIFY
* 5: MMODE_PICKPOINT
* 6: MMODE_LINEOP
* 7: MMODE_PICKANDLINEOP

### function void EnableRefreshImmediately

Schaltet das sofortige Neuzeichnen der Grafik nach bestimmten Befehlen ein oder aus. (1)

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BOOL_Enable | Wenn der Wert 0 ist, wird das sofortige Neuzeichnen der Grafik ausgeschaltet, sonst eingeschaltet. Standardmäßig ist das sofortige Neuzeichnen ausgeschaltet. |

#### remark

Bei bestimmten Methoden (z.B. "AddTextElement") wird die Grafik nach dem Aufruf sofort neu gezeichnet. Wenn viele solcher Methoden aufgerufen werden, bringt dies erhebliche Geschwindigkeitseinbußen mit sich. Ist das Neuzeichnen der Grafik ausgeschaltet, bündelt das System das Neuzeichnen der Grafik. Dies führt zu beträchtlichen Geschwindigkeitssteigerungen, wenn z.B. viele Texte in die Grafik eingefügt werden. Achtung: Dieses Feature ist experimentell. Nur einschalten, wenn sichergestellt ist, dass keine Seiteneffekte auftreten. Eine Alternative ist die Verwendung der Methode "SetRedraw" in der 3D-Engine.

### function void EnableRenderingToControl

### function void EnableRotation

Rotation der Grafik ein- oder ausschalten.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| BOOL_EnableRotation | Wenn die Rotation eingeschaltet werden soll, ist TRUE zu übergeben, sonst FALSE. |

### function void EnableRotationAxis

Legt fest, ob die Kugel zur Drehung der Grafik angezeigt werden soll.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| boolean_EnableAxis | Wenn die Kugel zur Drehung der Grafik angezeigt werden sollen, ist der Wert 1 zu übergeben, sonst der Wert 0. |

### function void EnableSetFocusOnMouseOver

Legt fest, ob das Control automatisch den Fokus erhalten soll, wenn sich der Mauszeiger darüber befindet.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| boolean_Enable | Wenn das Control automatisch den Fokus erhalten soll, ist der Wert 1 zu übergeben, sonst der Wert 0. |

### function void EnableShadow

### function void EnableShadowBox

### function void EnableZoom

### function void EndDragElement

### function long GetAdjustmentMode

### function short GetAntialiasingQuality

Gibt die derzeit eingestellte Antialiasing-Qualität zurück.

#### Rückgabewert

short Antialiasing-Qualität.

#### attention

Die Antialiasing-Qualität wird ignoriert, wenn Hardware-Antialiasing aktiviert ist.

### function int GetBitmapAntialiasingFactor

Ermittelt den Antialiasing-Faktor für den Bitmap-Export.

#### Rückgabewert

int Antialiasing-Faktor.

### function short GetCatchDisplayMode

### function short GetCatchDistance

### function BOOL GetCatchSubElements

### function void GetDragElementPosition

### function double GetEdgeEnhancementOffset

Aufruf wird an den Kernel weitergereicht. Beschreibung siehe dort.

#### Rückgabewert

double Beschreibung des Rückgabewertes siehe Kernel.

### function BSTR GetExtensions

Liefert die Liste der OpenGL-Extensions, so wie sie vom Grafikkartentreiber gemeldet wird.

#### Rückgabewert

string Liste von Extensions.

### function short GetIdentifyMode

### function void GetKernel

### function BOOL GetLightColor

### function BOOL GetLightPosition

### function short GetMouseMode

### function short GetPickMode

### function void GetPickPointColor

### function short GetPrintQuality

### function double GetRealBitmapHeight

Ermittelt die Höhe einer Bitmap in mm. Dazu müssen in der Bitmap die DPI (z.B. durch Editieren mit IrfanView) definiert sein.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Path | Der Pfad zur Bitmap. |

#### Rückgabewert

double Bitmaphöhe in mm. Im Fehlerfall wird -1 zurückgegeben

### function double GetRealBitmapWidth

Ermittelt die Breite einer Bitmap in mm. Dazu müssen in der Bitmap die DPI (z.B. durch Editieren mit IrfanView) definiert sein.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Path | Der Pfad zur Bitmap. |

#### Rückgabewert

double Bitmapbreite in mm. Im Fehlerfall wird -1 zurückgegeben

### function short GetRenderMode

Gibt den aktuell eingestellten Rendermodus zurück.

#### Rückgabewert

short Der aktuell eingestellte Rendermodus.

### function short GetSelectedCount

### function long GetSelectedElement

### function void GetSelectedPickPointColor

### function void GetSelectionColor

### function short GetSelectionMode

### function void GetVersion

### function void GetView

Ermittelt die aktuelle Sicht auf die Grafik.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double*_AngleX | Winkel um die X-Achse. |
| double*_AngleY | Winkel um die Y-Achse. |
| double*_AngleZ | Winkel um die Z-Achse. |

#### remark

Winkeleinheit sind Grad.

### function short GetViewMode

### function long GetWindowHandle

### function void GetWorkplane

### function short GetZoomMode

### function BOOL HasGraphics

Ermittelt, ob in der Szenerie eine Grafik existiert.

#### Rückgabewert

BOOL Wenn in der Szenerie eine Grafik existiert, wird TRUE zurückgegeben, sonst FALSE.

### function long IdentifyElement

Identifiziert das Element an der Cursor-Position.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_MousePosX | X-Koordinate der Cursor-Position. |
| short_MousePosY | Y-Koordinate der Cursor-Position. |

#### Rückgabewert

Typ Gültige Object-ID, wenn ein Element identifiziert werden konnte, sonst 0.

### function long IdentifyPickPoint

### function BOOL IsAutoAdjustViewEnabled

### function BOOL IsAutoLightingEnabled

Ermittelt, ob die automatische Beleuchtung eingeschaltet ist.

#### Rückgabewert

boolean Automatische Beleuchtung eingeschaltet?

### function HRESULT IsDeveloperModeEnabled

Ermittelt, ob der Entwicklermodus ein oder ausgeschaltet ist.

#### Rückgabewert

long Wird ein Wert ungleich 0 zurückgegeben, dann ist der Entwicklermodus eingeschaltet. Wird 0 zurückgegeben, dann ist der Entwicklermodus ausgeschaltet.

### function BOOL IsElementMoveEnabled

### function BOOL IsElementSelected

### function VARIANT IsHardwareAntialiasingEnabled

Ermittelt, ob das Hardware-Antialiasing eingeschaltet ist.

#### Rückgabewert

long Wenn das Hardware-Antialiasing eingeschaltet ist, wird der Wert 1 zurückgegeben, sonst der Wert 0.

### function BOOL IsLayerVisible

### function BOOL IsModified

Ermittelt, ob es seit dem letzten Aufruf von "IsModified" Änderungen im Grafikkernel gegeben hat.

#### Rückgabewert

boolean Wenn es Änderungen im Grafikkernel gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function BOOL IsObjectDamaged

Ermittelt, ob eine Grafikobjekt "beschädigt" ist.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Grafikobjekt, das auf Beschädigungen überprüft werden soll. |

#### Rückgabewert

boolean Wenn das Grafikobjekt beschädigt ist, wird der Wert 1 zurückgegeben, sonst der Wert 0.

#### remark

Ab und zu können Grafikobjekte durch Bearbeitungen (z.B. Schneidevorgänge) in ihrer internen Datenstruktur beschädigt werden. Das ist im allgemeinen Fall kaum mit absoluter Sicherheit zu vermeiden. Diese Funktion versucht, solche Beschädigungen zu erkennen. Wenn ein Objekt beschädigt ist, könnten folgende Maßnahmen helfen:

* Die Funktion "Beautify" aufrufen. Diese Funktion versucht unter anderem, Probleme innerhalb der internen Datenstruktur zu beheben.
* Wenn das nicht hilft, könnte die Bearbeitungsfunktion, die zur Beschädigung geführt hat, mit leicht variierten Parametern (z.B. mit einer leicht verschobenen Schnittebene) wiederholt werden.

### function BOOL IsRefreshImmediatelyEnabled

Ermittelt, ob das sofortige Neuzeichnen der Grafik ein- oder ausgeschaltet ist.

#### Rückgabewert

BOOL Wenn 0 zurückgegeben wird, ist das sofortige Neuzeichen der Grafik ausgeschaltet, sonst eingeschaltet.

### function BOOL IsRenderingToControlEnabled

### function BOOL IsRotationEnabled

@ brief Ermittelt, ob die Rotation eingeschaltet ist.

#### Rückgabewert

BOOL Wenn die Rotation eingeschaltet ist, wird TRUE zurückgegeben, sonst FALSE.

### function BOOL IsSetFocusOnMouseOverEnabled

Ermittelt, ob das Control den Fokus erhält, wenn sich der Mauszeiger darüber befindet.

#### Rückgabewert

boolean Wenn das Control automatisch den Fokus erhält, wird der Wert 1 zurückgegeben, sonst der Wert 0.

### function BOOL IsShadowBoxEnabled

### function BOOL IsShadowEnabled

### function BOOL IsTextSelected

Ermittelt, ob zur Zeit ein Textelement markiert ist.

#### par

FreeText

#### Rückgabewert

boolean Wenn zur Zeit ein Textelement markiert ist, wird "true" zurückgegeben, sonst "false".

### function BOOL IsZoomEnabled

### function void Log

Fügt eine Meldung am Ende der Log-Datei an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Msg | Meldung, die angefügt werden soll. |

### function BOOL ManualMeasuresModified

Ermittelt, ob es seit dem Laden der aktuellen Grafik Änderungen im Bereich manueller Maße gegeben hat.

#### Rückgabewert

boolean Wenn es Änderungen gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function void OnHint

### function short PickEnabled

Ermittelt, ob Pickpunkte definiert sind.

#### Rückgabewert

short Wenn Pickpunkte definiert sind, wird ein Wert ungleich 0 zurückgegeben, andernfalls 0.

#### remark

Als Nebeneffekt wird die Liste der Pickpunkte manipuliert.

### function void PostLoad

### function void PreSave

### function void PrintPage

### function void RefreshWindow

### function void Remove2DLine

### function BOOL Remove3DLine

Löscht die angegebene 3D-Linie.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| int_Id | Id der 3D-Linie. |

#### Rückgabewert

bool Wenn die Linie erfolgreich entfernt werden konnte, wird TRUE zurückgegeben, andernfalls FALSE.

#### remark

Die Id ist der Rückgabewert der Funktion "Add3DLine".

### function void RemoveFromTextureCache

### function void Reset

Setzt einige Einstellungen im Object-Viewer und im 3D-Kernel auf Standardwerte zurück.

#### remark

Es werden folgende Einstellung auf Standardwerte zurückgesetzt:

* CG3DKernel::SetMeasureDefaultFont(DefaultMeasureFont = "Arial", DefaultTextHeight = 0.075)
* CG3DKernel::SetMeasureDefaultTextDist(DefaultTextDist = 0.015)
* CG3DKernel::SetMeasureDefaultUnit(DefaultMeasureUnit = 0, DefaultMeasureRoundTo = 0)
* CObjectViewerCtrl::EnableOriginAxis(Enable = TRUE)
* CObjectViewerCtrl::SetMouseMode(MouseMode = MMODE_NONE) // = 0
* CObjectViewerCtrl::EnableRotationAxis(Enable = FALSE)
* CObjectViewerCtrl::SetZoomMode(ZoomMode = ZMODE_POINT_IN) // = 3
* CObjectViewerCtrl::SetPrintQuality(6)
* CObjectViewerCtrl::EnableRotation(Enable = FALSE)

Die obigen Einstellungen sind die gleichen, die im A3d beim Speichern mitgesichert und beim Laden wiederhergestellt werden.

### function void ResetView

Weist den Objektviewer an, bestimmte Einstellungen auf die Standardwerte zurückzustellen.

### function void ResetZoom

Setzt den Zoom zurück.

### function BSTR SaveSceneryToBase64

Schreibt die aktuelle Szenerie in eine BASE64 und gibt diese in Form eines Wertes vom Typ "string" zurück.

#### par

Export

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_ImageFormat | Das gewünschte Bitmapformat. |
| short_Width | Breite der Bitmap. |
| short_Height | Höhe der Bitmap. |
| boolean_Crop | Wenn die Bitmap auf den eigentlichen Darstellungsbereich zugeschnitten werden soll, ist der Wert TRUE zu übergeben, andernfalls der Wert FALSE. |

#### Rückgabewert

string Bitmap als Wert vom Typ "Variant".

#### remark

Der Rückgabewert enthält die Bitmap als Bytearray. Dieses Bytearray ist identisch mit dem Inhalt der Datei, die beim Schreiben der Bitmap auf Festplatte entstehen würde.

### function BOOL SaveSceneryToFile

Speichert die aktuelle Szenerie als Bitmap.

#### par

Export

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_FileName | Name der Datei, in der die Bitmap geschrieben werden soll. |
| string_ImageFormat | Gewünschtes Dateiformat. |
| short_Width | Breite der Bitmap in Bildpunkten. |
| short_Height | Höhe der Bitmap in Bildpunkten. |
| boolean_Crop | Falls die Bitmap exakt in der angeforderten Größe erstellt werden soll, ist der Wert 0 zu übergeben. Falls nur der Bildbereich, der von der Szenerie beansprucht wird, gespeichert werden soll, ist der Wert 1 zu übergeben. Im letzteren Fall kann sich die tatsächliche Bitmapgröße von den angeforderten Werten unterscheiden. |

#### Rückgabewert

boolean Wenn die Bitmap erfolgreich erstellt werden konnte, wird der Wert 1 zurückgegeben, sonst der Wert 0.

#### remark

Um eine möglichst hohe Bildqualität zu erreichen, wird die Bitmap in einer höheren Auflösung errechnet und vor dem Speichern auf die korrekte Größe verkleinert. Derzeit werden folgende Formate unterstützt:

* "BMP": Windows-Bitmap
* "JPG" or "JPEG": JPEG-Format
* "PNG": PNG-Format

### function VARIANT SaveSceneryToMemory

Schreibt die aktuelle Szenerie in eine Bitmap und gibt diese in Form eines Wertes vom Typ "Variant" zurück.

#### par

Export

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_ImageFormat | Das gewünschte Bitmapformat. |
| short_Width | Breite der Bitmap. |
| short_Height | Höhe der Bitmap. |
| boolean_Crop | Wenn die Bitmap auf den eigentlichen Darstellungsbereich zugeschnitten werden soll, ist der Wert TRUE zu übergeben, andernfalls der Wert FALSE. |

#### Rückgabewert

bytearray Bitmap als Wert vom Typ "Variant".

#### remark

Der Rückgabewert enthält die Bitmap als Bytearray. Dieses Bytearray ist identisch mit dem Inhalt der Datei, die beim Schreiben der Bitmap auf Festplatte entstehen würde.

### function BOOL SelectElement

### function BOOL SelectPickPoint

### function void Set2DLineColor

### function void SetAdjustmentMode

Setzt den Modus, der beim Einpassen der Grafik in das Ausgabefenster verwendet werden soll.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_AdjustmentMode | Einpassungsmodus.

* 0: Standardmodus, d.h. es werden die Objektboxen von allen Objekten berücksichtigt.
* 1: Es werden nur die normalen Objekte berücksichtigt, die ein oder mehrere Primitiva haben.

 |

### function short SetAntialiasingQuality

Setzt die Antialiasing-Qualität als Wert von 0 bis 10.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_Quality | Antialiasing-Qualität (0 = kein Antialiasing, 10 = bestes Antialiasing). |

#### Rückgabewert

short Im Fehlerfall wird der Wert -1 zurückgegeben, sonst die tatsächlich gesetzte Antialiasing-Qualität. Im letzteren Fall ist der Rückgabewert gleich dem Wert des Parameters "Quality".

#### attention

Wenn Hardware-Antialiasing aktiviert ist, bleibt diese Einstellung, je nach Grafikkarte und Treiber, eventuell ohne Auswirkung. In diesem Fall wird immer mit Antialiasing gerendert, wobei die höchste Qualitätsstufe verwendet wird, den die Grafikkarte unterstützt.

### function double SetAutoStretchFactor

Setzt den Wert, der bei Grafikoperationen (z.B. Union) verwendet wird, um die betroffenen Objekte temporär zu vergrößern.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Value | Wert in mm, um den die Objekte vergrößert werden sollen. |

#### Rückgabewert

double Der vorherige Wert, der für die Vergrößerung verwendet worden ist.

#### remark

Hintergrund für diesen Wert: Einige Grafikoperationen arbeiten besser, wenn sie mit leicht vergrößerten Objekten durchgeführt werden. Vor allem werden dadurch Grenzfälle, wie direkt übereinander liegende Flächen, vermieden, die zur Fehlfunktionen bei der Ausführung der Operation führen können.

#### attention

Der Name der Funktion ist etwas irreführend. Es handelt sich nicht um einen Faktor, sondern um ein Maß in mm, um den die Objekte vergrößert werden.

### function BOOL SetBackgroundColor

### function void SetBitmapAntialiasingFactor

Setzt den Antialiasing-Faktor für den Bitmap-Export.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| int_bitmapAntialiasingFactor | Antialiasing-Faktor für den Bitmap-Export. |

#### remark

Beim Export von Bitmaps werden diese zunächst um den Antialiasing-Factor vergrößert erstellt und dann vor dem Schreiben in die Datei auf die gewünschte Größe verkleinert. Dadurch werden schräge Kanten im Bild ohne Treppeneffekt dargestellt.

### function void SetBrightness

Setzt einen generellen Helligkeitswert für die Szenerie.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Brightness | Helligkeit |

#### remark

Werte für die Helligkeit:

* 0: Normal.
* 1: Dunkler.
* 2: Heller.

### function void SetCatchDisplayMode

### function void SetCatchDistance

### function void SetDragElementPosition

### function void SetEdgeEnhancementOffset

Setzt den Wert (in mm), um den Kantenverstärkungen weiter hinten gezeichnet werden sollen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_edgeEnhancementOffset | Versatz in mm. |

#### remark

Motivation: Wenn mehrere Flächen knapp hintereinander liegen, können manchmal Kantenverstärkungen, die eigentlich zu einer weiter hinten liegenden Fläche gehören, bei einer weiter vorn liegenden Fläche durchschimmern. Dieser Effekt kann vermindert werden, wenn Kantenverstärkungen generell ein wenig hinter der Fläche, zu der sie gehören, gezeichnet werden.

### function void SetGlobalTransparencyColor

### function BOOL SetIdentifyMode

### function BOOL SetImage

### function long SetImageEx

Stellt eine Bitmap dar.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Path | Vollständiger Pfad zur Bitmap. |
| double_X | X-Koordinate der linken unteren Ecke der Bitmap in mm. |
| double_Y | Y-Koordinate der linken unteren Ecke der Bitmap in mm. |
| double_Width | Gewünschte Breite der Bitmap in mm. |
| double_Height | Gewünschte Höhe der Bitmap in mm. |
| double_Angle | Winkel, um den die Bitmap gedreht werden soll. Derzeit werden folgende Winkel unterstützt: 0, 90, 180 und 270. |

#### Rückgabewert

BOOL Wenn die Funktion erfolgreich durchgeführt werden konnte, wird ein Handle auf die Bitmap zurückgegeben, andernfalls 0.

### function long SetImageExLayer

Stellt eine Bitmap dar.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long | id von Image. |
| int | Layer auf den die Image sein soll. |

### function void SetLayerVisibility

### function void SetLayoutPath

### function BOOL SetLightColor

### function BOOL SetLightPosition

### function void SetLineFactor

Setzt ein Maß für die Drahtgitterdarstellung, das angibt, wie weit die Kanten vor den Flächen gezeichnet werden sollen, sodass eine gute Darstellungsqualität erreicht wird.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_LineFactor | Faktor. |

### function void SetLogFile

Setzt den Pfad zur Log-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_LogPath | Pfad zur Log-Datei. |

### function void SetMenuItemData

### function void SetMenuItemDataString

### function BOOL SetMenuItemText

### function void SetMesaNiceRender

Setzt ein Flag, wodurch Mesa Grafiken etwas schöner gerendert werden.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| niceRender | Angabe ob schönes Mesa rendering aktiviert sein soll oder nicht |

### function void SetMouseMode

### function BOOL SetPickPointColor

### function void SetPrintQuality

### function void SetRenderMode

Setzt den Rendermodus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_RenderMode | Der zu setzende Rendermodus. |

#### remark

Es sind folgende Werte gültig:

* 0 Drahtgitterdarstellung.
* 1 Verbesserte Darstellung mit Farbflächen (Glanzlichter, Perspektive).
* 2 Wie 3 und zusätzlich Kantenverstärkung.
* 3 Darstellung mit Farbflächen.
* 4 Wie 1 und zusätzlich Kantenverstärkung.
* 5 Fotorealistische Darstellung.
* 6 Fotorealistische Darstellung in bester Qualität.

### function BOOL SetSelectedPickPointColor

### function BOOL SetSelectionColor

Setzt die Farbe, die für Markierungen verwendet wird.

#### par

FreeText

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Red | Roter Anteil. |
| double_Green | Grüner Anteil. |
| double_Blue | Blau Anteil. |

#### Rückgabewert

boolean Wenn die Farbe erfolgreich gesetzt konnte, wird "true" zurückgegeben, sonst "false".

### function BOOL SetSelectionMode

### function void SetSettingsDirectory

Setzt das Verzeichnis, in das die Einstellungsdatei für den Object-Viewer geschrieben wird.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_SettingsDirectory | Einstellungsverzeichnis. |

#### remark

* Wenn kein Verzeichnis gesetzt wurde, wird die Einstellungsdatei in das gleiche Verzeichnis geschrieben, in dem sich der Object-Viewer befindet.
* Wenn das angegebene Verzeichnis nicht existiert, wird es angelegt.
* Der Name der Einstellungsdatei lautet "ObjectViewerSettings.ini".
* In der Einstellungsdatei befinden sich ausschließlich Einstellungen, die für das Debugging relevant sind.
* Im Normalbetrieb ist keine Einstellungsdatei nötig.

### function void SetStartPosition

### function void SetView

Setzt die Sicht auf die Grafik.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_ViewAngX | Winkel um die X-Achse. |
| double_ViewAngY | Winkel um die Y-Achse. |
| double_ViewAngZ | Winkel um die Z-Achse. |

#### remark

Winkeleinheit sind Grad.

### function void SetViewMode

Setzt den Ansichtsmodus.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_RenderMode | Ansichtsmodus (Parameter falsch benannt; er müsste "ViewMode" heißen). |

#### remark

Es gibt folgende Ansichtsmodi:

* 0: Orthogonale Ansicht
* 1: Perspektivische Ansicht

### function void SetWorkplane

### function BOOL SetZoomMode

### function void ShowHelp

Zeigt die im ObjectViewer integrierte Hilfe im Internet-Explorer an.

#### remark

Damit die Hilfedatei angezeigt werden kann, muss der Internet-Explorer als Standardbrowser eingestellt sein.

### function BOOL StraightenTextures

### function void Test

Wird nur intern für Testzwecke verwendet.

### function void UnCheckAllMenuEntries

### function void UndoLastElementMove

### function void UndoLastZoom

### function BOOL UnSelectElement

### function BOOL UnSelectPickPoint

### function void UpdateNow

### function BOOL UseKernel

### function BOOL UseKernelObject

### function void UseWorkplane

### function void ZoomToFit

# page 3D-OCX

## Benutzerdokumentation

### Überschrift 1

Text 1

### Überschrift 2

Text 2