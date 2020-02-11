# struct _DObjectViewerEventsVtbl

## public-attrib

### variable REFIID LPOLESTR UINT cNames

### variable _In_ DISPID dispIdMember

### variable UINT iTInfo

### variable UINT LCID lcid

### variable REFIID LPOLESTR UINT LCID lcid

### variable _In_ DISPID _In_ REFIID _In_ LCID lcid

### variable UINT * pctinfo

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS * pDispParams

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO * pExcepInfo

### variable UINT LCID ITypeInfo ** ppTInfo

### variable BEGIN_INTERFACE REFIID _COM_Outptr_ void ** ppvObject

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO _Out_opt_ UINT * puArgErr

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT * pVarResult

### variable REFIID LPOLESTR UINT LCID DISPID * rgDispId

### variable REFIID LPOLESTR * rgszNames

### variable BEGIN_INTERFACE REFIID riid

### variable REFIID riid

### variable _In_ DISPID _In_ REFIID riid

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD wFlags

## public-func

### function BEGIN_INTERFACE HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function ULONG

### function ULONG

# struct _DObjectViewerVtbl

## public-attrib

### variable REFIID LPOLESTR UINT cNames

### variable _In_ DISPID dispIdMember

### variable UINT iTInfo

### variable UINT LCID lcid

### variable REFIID LPOLESTR UINT LCID lcid

### variable _In_ DISPID _In_ REFIID _In_ LCID lcid

### variable UINT * pctinfo

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS * pDispParams

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO * pExcepInfo

### variable UINT LCID ITypeInfo ** ppTInfo

### variable BEGIN_INTERFACE REFIID _COM_Outptr_ void ** ppvObject

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO _Out_opt_ UINT * puArgErr

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT * pVarResult

### variable REFIID LPOLESTR UINT LCID DISPID * rgDispId

### variable REFIID LPOLESTR * rgszNames

### variable BEGIN_INTERFACE REFIID riid

### variable REFIID riid

### variable _In_ DISPID _In_ REFIID riid

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD wFlags

## public-func

### function BEGIN_INTERFACE HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function ULONG

### function ULONG

# struct _IID

## public-attrib

### variable unsigned char c

### variable unsigned short s1

### variable unsigned short s2

### variable unsigned long x

# struct C3dEnvironment

## public-attrib

### variable CVector m_cameraPosition

### variable CObjectViewerCtrl & m_control

### variable CVector m_lookAtPosition

### variable CString m_outputPath

### variable OBJID m_rootId

## public-func

### function C3dEnvironment

### function const CVector & GetCameraPosition

### function double GetFieldOfVision

### function const CVector & GetLookAtPosition

### function IMaterialPool & GetMaterialPool

### function CString GetOutputPath

### function OBJID GetRoot

# class C3dMeasure

## protected-attrib

### variable double m_Blue

### variable double m_FontHeight

### variable CString m_FontName

### variable double m_Green

### variable OBJID m_idObj

### variable int m_MeasureSizeDisplayType

### variable int m_nMeasureUnit

### variable double m_Red

### variable int m_RoundTo

### variable double m_TextDist

### variable int m_TypeLeft

### variable int m_TypeRight

### variable CVector m_v

### variable CString m_ViewId

### variable CMatrix m_WorkPlane

## public-func

### function C3dMeasure

### function C3dMeasure

### function C3dMeasure

### function void GetColor

### function CVector GetEndPosition

### function int GetEndType

### function int GetRoundTo

### function CVector GetStartPosition

### function int GetStartType

### function CString GetText

### function double GetTextDist

### function CString GetTextFont

### function double GetTextHeight

### function int GetTextHeightType

### function int GetUnit

### function CString GetViewId

### function CMatrix & GetWorkPlane

### function void ReadFromObject

### function void SetColor

### function void SetEndPosition

### function void SetEndType

### function void SetRoundTo

### function void SetStartPosition

### function void SetStartType

### function void SetText

### function void SetTextDist

### function void SetTextFont

### function void SetTextHeight

### function void SetTextHeightType

### function void SetUnit

### function void SetViewId

### function void WriteToObject

## public-static-func

### function OBJID CreateMeasure

### function CString FormatText

### function CString FormatText

# class C3dText

## protected-attrib

### variable double m_Angle

### variable BOOL m_bBold

### variable BOOL m_bHasWorkPlane

### variable BOOL m_bItalic

### variable BOOL m_bUnderline

### variable int m_Escapement

### variable CString m_FontName

### variable double m_Height

### variable int m_HorizAlign

### variable OBJID m_idObj

### variable CString m_Name

### variable CVector m_Pos

### variable double m_RotX

### variable double m_RotY

### variable double m_RotZ

### variable CString m_Text

### variable double m_Thickness

### variable int m_VertAlign

### variable CMatrix m_WorkPlane

## public-func

### function C3dText

### function C3dText

### function C3dText

### function void GetAlignement

### function double GetAngle

### function BOOL GetBold

### function CString GetFont

### function double GetHeight

### function BOOL GetItalic

### function CVector GetPosition

### function void GetRotation

### function CString GetText

### function double GetThickness

### function BOOL GetUnderline

### function const CMatrix & GetWorkPlane

### function void ReadFromObject

### function void SetAlignement

### function void SetAngle

### function void SetBold

### function void SetFont

### function void SetHeight

### function void SetItalic

### function void SetPosition

### function void SetRotation

### function void SetText

### function void SetThickness

### function void SetUnderline

### function void WriteToObject

## public-static-func

### function OBJID CreateText

# class CActiveScriptHost

## protected-attrib

### variable HWND m_hHostWnd

### variable IActiveScriptParse * m_pAxsParse

### variable IActiveScript * m_pAxsScript

### variable CMapStringToPtr mapNamedItems

## public-func

### function CActiveScriptHost

### function CActiveScriptHost

### function ~CActiveScriptHost

### function ~CActiveScriptHost

### function BOOL AddScriptCode

### function BOOL AddScriptCode

### function BOOL AddScriptItem

### function BOOL AddScriptItem

### function BOOL AddScriptlet

### function BOOL AddScriptlet

### function BOOL CreateEngine

### function BOOL CreateEngine

### function LPDISPATCH CreateObjectHelper

### function LPDISPATCH CreateObjectHelper

### function DECLARE_OLECTLTYPE

### function DECLARE_OLECTLTYPE

### function void DestroyDataHelper

### function void DestroyDataHelper

### function STDMETHOD() EnableModeless

### function STDMETHOD() EnableModeless

### function STDMETHOD() GetClassInfo

### function STDMETHOD() GetClassInfo

### function STDMETHOD() GetDocVersionString

### function STDMETHOD() GetDocVersionString

### function STDMETHOD() GetGUID

### function STDMETHOD() GetGUID

### function STDMETHOD() GetInfoOfIndex

### function STDMETHOD() GetInfoOfIndex

### function STDMETHOD() GetItemInfo

### function STDMETHOD() GetItemInfo

### function STDMETHOD() GetMultiTypeInfoCount

### function STDMETHOD() GetMultiTypeInfoCount

### function STDMETHOD() GetWindow

### function STDMETHOD() GetWindow

### function HRESULT InvokeFuncHelper

### function HRESULT InvokeFuncHelper

### function STDMETHOD() OnEnterScript

### function STDMETHOD() OnEnterScript

### function STDMETHOD() OnLeaveScript

### function STDMETHOD() OnLeaveScript

### function STDMETHOD() OnScriptError

### function STDMETHOD() OnScriptError

### function STDMETHOD() OnScriptTerminate

### function STDMETHOD() OnScriptTerminate

### function STDMETHOD() OnStateChange

### function STDMETHOD() OnStateChange

### function WCHAR * ReadTextFileHelper

### function WCHAR * ReadTextFileHelper

### function BOOL SetHostWindow

### function BOOL SetHostWindow

## protected-func

### function void CommonConstruct

### function void CommonConstruct

### function void ReleaseObjects

### function void ReleaseObjects

# class CCatalogDescription

## public-attrib

### variable BOOL m_Loaded

### variable CMaterialDB m_Materials

## private-attrib

### variable CString m_CatalogPath

### variable COLORREF m_globalAlphaColor

### variable CString m_ImagePath

### variable CString m_Name

### variable CString m_Producer

## public-func

### function CCatalogDescription

### function CCatalogDescription

### function CCatalogDescription

### function ~CCatalogDescription

### function CMaterial * FindMaterial

### function CSelectionMaterial * FindSelMaterial

### function CString GetCatalogPath

### function CString GetImageFileName

### function CString GetImageFileName

### function CString GetImagePath

### function POSITION GetMaterialHeadPosition

### function CString GetName

### function CMaterial * GetNextMaterial

### function CString GetProducer

### function void GuessDesiredColor

### function BOOL LoadMatFile

### function void LoadTextures

### function void SetCatalogPath

### function void SetGlobalAlphaColor

### function void SetName

### function void SetProducer

### function void UnLoadTextures

# class CCatalogDlg

## public-type

### enum %type% @5

## public-attrib

### variable CString m_Catalog

### variable CEdit m_ctlCatalog

### variable CListCtrl m_ctlCatalogs

### variable CEdit m_ctlPath

### variable CEdit m_ctlProducer

### variable CButton m_ctlUpdate

### variable CString m_Path

### variable CString m_Producer

## protected-attrib

### variable CG3DKernel * m_pKernel

## public-func

### function CCatalogDlg

## protected-func

### function void DoDataExchange

### function BOOL OnInitDialog

### function afx_msg void OnItemchangedCatalogs

### function afx_msg void OnUpdate

### function void UpdateControls

# class CCatchPoint

## public-attrib

### variable bool m_Active

### variable int m_CatchPointId

### variable long m_HostObject

### variable CString m_Mask

### variable CString m_Name

### variable CVector2D m_ScreenPos

### variable CVector2D m_ScreenTo

### variable int m_Type

### variable CMatrix m_WorldOffset

### variable CMatrix m_WorldPos

### variable CDoubleVector m_WorldTo

## public-func

### function CCatchPoint

### function CCatchPoint

### function CCatchPoint

# class CCatchSet

## public-func

### function bool Match

# class CContentDlg

## public-type

### enum %type% @6

## public-attrib

### variable BOOL m_bBox

### variable BOOL m_bEdges

### variable BOOL m_bFaceNormals

### variable BOOL m_bLoops

### variable BOOL m_bMatrix

### variable BOOL m_bMusterLines

### variable BOOL m_bObjAttribs

### variable BOOL m_bObjects

### variable BOOL m_bPoints

### variable BOOL m_bPrim

### variable BOOL m_bPrimAttribs

### variable BOOL m_bTextCoords

### variable CTreeCtrl m_ctlContents

### variable OBJID m_idRoot

### variable CString m_Info

## protected-attrib

### variable UINT_PTR m_checkTimer

### variable OBJID m_idCurSel

### variable CG3DKernel * m_pKernel

### variable hyper m_previousChangeCount

### variable UINT_PTR m_refreshTimer

## public-func

### function CContentDlg

### function void DetectChanges

## protected-func

### function HTREEITEM AddOneItem

### function void DisplayAttribSet

### function void DisplayItem

### function void DoDataExchange

### function HTREEITEM FillTreeControl

### function afx_msg void OnCatalogs

### function afx_msg void OnDestroy

### function afx_msg void OnDll

### function afx_msg void OnDoubleclickedRedolog

### function BOOL OnInitDialog

### function afx_msg void OnRDLSingleStep

### function afx_msg void OnRedolog

### function afx_msg void OnSelchangedContents

### function afx_msg void OnTimer

### function afx_msg void OnUpdate

### function void RefreshTree

### function void ShowPrimitive

### function void ShowPrimitiveBuild

# class CDelayedDirectoryChangeHandler

## protected-attrib

### variable bool m_bAppHasGUI

### variable DWORD m_dwFilterFlags

### variable DWORD m_dwPartialPathOffset

### variable CDelayedNotifier * m_pDelayNotifier

### variable CDirectoryChangeHandler * m_pRealHandler

## friend

### friend friend class CDirectoryChangeWatcher

### friend friend class CDirectoryChangeWatcher::CDirWatchInfo

## private-attrib

### variable HANDLE m_hWatchStoppedDispatchedEvent

### variable int m_nNumExcludeFilterSpecs

### variable int m_nNumIncludeFilterSpecs

### variable TCHAR * m_szExcludeFilter

### variable TCHAR * m_szIncludeFilter

## private-static-attrib

### variable BOOL s_bShlwapi_dllExists

### variable FUNC_PatternMatchSpec s_fpPatternMatchSpec

### variable HMODULE s_hShlwapi_dll

### variable long s_nRefCnt_hShlwapi

## private-func

### function CDelayedDirectoryChangeHandler

### function BOOL _PathMatchSpec

### function BOOL InitializePathMatchFunc

### function BOOL InitializePatterns

### function void UninitializePathMatchFunc

### function bool UsesRealPathMatchSpec

## public-func

### function CDelayedDirectoryChangeHandler

### function ~CDelayedDirectoryChangeHandler

### function void DispatchNotificationFunction

### function CDirectoryChangeHandler * GetRealChangeHandler

### function CDirectoryChangeHandler *& GetRealChangeHandler

### function void PostNotification

## protected-func

### function void DisposeOfNotification

### function bool ExcludeThisNotification

### function const CString & GetChangedDirectoryName

### function CDirChangeNotification * GetNotificationObject

### function bool IncludeThisNotification

### function bool NotifyClientOfFileChange

### function void On_FileAdded

### function void On_FileModified

### function void On_FileNameChanged

### function void On_FileRemoved

### function void On_ReadDirectoryChangesError

### function void On_WatchStarted

### function void On_WatchStopped

### function void SetChangedDirectoryName

### function void SetPartialPathOffset

### function BOOL WaitForOnWatchStoppedDispatched

# class CDelayedNotificationThread

## private-static-attrib

### variable DWORD s_dwThreadID

### variable HANDLE s_hThread

### variable long s_nRefCnt

## private-attrib

### variable HANDLE m_hThreadStartEvent

## public-func

### function CDelayedNotificationThread

### function ~CDelayedNotificationThread

### function void PostNotification

## private-func

### function long AddRef

### function long Release

### function BOOL SignalThreadStartup

### function bool StartThread

### function bool StopThread

### function BOOL WaitForThreadStartup

## private-static-func

### function UINT __stdcall ThreadFunc

# class CDelayedNotificationWindow

## private-static-attrib

### variable BOOL s_bRegisterWindow

### variable HWND s_hWnd

### variable long s_nRefCnt

## public-func

### function CDelayedNotificationWindow

### function ~CDelayedNotificationWindow

### function void PostNotification

## private-func

### function long AddRef

### function BOOL CreateNotificationWindow

### function BOOL RegisterWindowClass

### function long Release

# class CDelayedNotifier

## public-func

### function ~CDelayedNotifier

### function void PostNotification

# struct CDeveloperTools

## public-static-func

### function bstr_t GetInputString

### function void OpenDeveloperTools

Öffnet das Fenster mit den Entwicklerwerkzeugen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| pViewer | Zeiger auf die IDispatch-Schnittstelle im ObjectViewer. |
| assemblyPath | Vollständiger Pfad zur DevelperTools-Assembly. |

### function bool SaveAsEmf

# class CDimension

## private-attrib

### variable CVector _v1

### variable CVector _v2

## public-func

### function CDimension

### function CDimension

### function ~CDimension

### function double GetDirectDimenson

### function double GetDirectDimenson

### function double GetHorzDimenson

### function double GetHorzDimenson

### function double GetVertDimenson

### function double GetVertDimenson

### function void SetV1

### function void SetV2

# class CDirChangeNotification

## public-type

### enum %type% eFunctionToDispatch

## friend

### friend friend class CDirChangeNotification

### friend friend class CDelayedDirectoryChangeHandler

### friend friend class CDirectoryChangeWatcher

### friend friend DWORD GetPathOffsetBasedOnFilterFlags

## private-attrib

### variable DWORD m_dwError

### variable DWORD m_dwPartialPathOffset

### variable eFunctionToDispatch m_eFunctionToDispatch

### variable CDelayedDirectoryChangeHandler * m_pDelayedHandler

### variable TCHAR * m_szFileName1

### variable TCHAR * m_szFileName2

## private-func

### function CDirChangeNotification

## public-func

### function CDirChangeNotification

### function ~CDirChangeNotification

### function void DispatchNotificationFunction

### function void PostOn_FileAdded

### function void PostOn_FileModified

### function void PostOn_FileNameChanged

### function void PostOn_FileRemoved

### function void PostOn_ReadDirectoryChangesError

### function void PostOn_WatchStarted

### function void PostOn_WatchStopped

## protected-func

### function void PostNotification

# class CDirectoryChangeHandler

## private-attrib

### variable CCriticalSection m_csWatcher

### variable long m_nRefCnt

### variable long m_nWatcherRefCnt

### variable CDirectoryChangeWatcher * m_pDirChangeWatcher

### variable CString m_strChangedDirectoryName

## friend

### friend friend class CDelayedDirectoryChangeHandler

### friend friend class CDirectoryChangeWatcher

## public-func

### function CDirectoryChangeHandler

### function ~CDirectoryChangeHandler

### function long AddRef

### function long CurRefCnt

### function const CString & GetChangedDirectoryName

### function long Release

### function BOOL UnwatchDirectory

## protected-func

### function void On_FileAdded

### function void On_FileModified

### function void On_FileNameChanged

### function void On_FileRemoved

### function bool On_FilterNotification

### function void On_ReadDirectoryChangesError

### function void On_WatchStarted

### function void On_WatchStopped

### function void SetChangedDirectoryName

## private-func

### function long ReferencesWatcher

### function long ReleaseReferenceToWatcher

# class CDirectoryChangeWatcher

## public-type

### enum %type% @0

## friend

### friend friend class CDirectoryChangeHandler

### friend friend class CDirWatchInfo

## private-attrib

### variable bool m_bAppHasGUI

### variable CCriticalSection m_csDirWatchInfo

### variable CTypedPtrArray< CPtrArray, CDirWatchInfo * > m_DirectoriesToWatch

### variable DWORD m_dwFilterFlags

### variable DWORD m_dwThreadID

### variable HANDLE m_hCompPort

### variable HANDLE m_hThread

## public-func

### function CDirectoryChangeWatcher

### function ~CDirectoryChangeWatcher

### function DWORD GetFilterFlags

### function BOOL IsWatchingDirectory

### function int NumWatchedDirectories

### function DWORD SetFilterFlags

### function BOOL UnwatchAllDirectories

### function BOOL UnwatchDirectory

### function DWORD WatchDirectory

## protected-func

### function void On_ThreadExit

### function void On_ThreadInitialize

## private-func

### function int AddToWatchInfo

### function CDirWatchInfo * GetDirWatchInfo

### function CDirWatchInfo * GetDirWatchInfo

### function CDirWatchInfo * GetDirWatchInfo

### function void ProcessChangeNotifications

### function long ReleaseReferenceToWatcher

### function BOOL UnwatchDirectory

### function BOOL UnwatchDirectoryBecauseOfError

## private-static-func

### function UINT MonitorDirectoryChanges

# class CDirectoryChangeWatcher::CDirWatchInfo

## public-type

### enum %type% eRunningState

## public-attrib

### variable CHAR m_Buffer

### variable BOOL m_bWatchSubDir

### variable CCriticalSection m_cs

### variable DWORD m_dwBufLength

### variable DWORD m_dwChangeFilter

### variable DWORD m_dwReadDirError

### variable HANDLE m_hDir

### variable OVERLAPPED m_Overlapped

### variable CDelayedDirectoryChangeHandler * m_pChangeHandler

### variable eRunningState m_RunningState

### variable CEvent m_StartStopEvent

### variable CString m_strDirName

## private-func

### function CDirWatchInfo

### function ~CDirWatchInfo

### function CDirWatchInfo & operator=

## public-func

### function CDirWatchInfo

### function BOOL CloseDirectoryHandle

### function void DeleteSelf

### function CDelayedDirectoryChangeHandler * GetChangeHandler

### function CDirectoryChangeHandler * GetRealChangeHandler

### function BOOL LockProperties

### function CDirectoryChangeHandler * SetRealDirectoryChangeHandler

### function DWORD StartMonitor

### function BOOL UnlockProperties

### function BOOL UnwatchDirectory

## protected-func

### function BOOL SignalShutdown

### function BOOL WaitForShutdown

# class CDllDlg

## public-type

### enum %type% @7

## public-attrib

### variable CListCtrl m_ctlImport

### variable CListCtrl m_ctlPlugins

## protected-attrib

### variable CG3DKernel * m_pKernel

## public-func

### function CDllDlg

## protected-func

### function void DoDataExchange

### function BOOL OnInitDialog

# struct CDotnetHelpers

## public-static-func

### function bstr_t GetInputString

### function double GetRealImageHeight

### function double GetRealImageWidth

### function void SaveImageToFile

### function void ShowDotnetVersion

# struct CDotnetHelpersImplementation

## public-static-func

### function bstr_t GetInputString

### function double GetRealImageHeight

### function double GetRealImageWidth

### function void OnClickCancel

### function void OnClickOk

### function void SaveImageToFile

# class CDynamicPopUpMenu

## protected-static-attrib

### variable CWindowIdManager m_IdManager

## protected-attrib

### variable CMenuItemArray m_Items

### variable CMenu m_Menu

### variable CDynamicPopUpMenu * m_pFather

## public-func

### function CDynamicPopUpMenu

### function ~CDynamicPopUpMenu

### function BOOL AddSeperator

### function BOOL CheckMenuItem

### function BOOL CreateSubMenu

### function BOOL DeleteMenuItem

### function BOOL DeleteSeperator

### function BOOL DisableMenuItem

### function void DisplayPopUpMenu

### function BOOL EnableMenuItem

### function CDynamicPopUpMenu * GetFather

### function HMENU GetMenuHandle

### function MenuItem * GetMenuItem

### function UINT GetMenuItemCount

### function BOOL GetMenuItemData

### function int GetMenuItemMessageId

### function BOOL GetMenuItemString

### function CDynamicPopUpMenu * GetSubMenu

### function BOOL InsertMenuItem

### function BOOL InsertSubMenuItem

### function void SetFather

### function BOOL SetMenuItemData

### function BOOL SetMenuItemString

### function BOOL SetMenuItemText

### function BOOL UnCheckAllMenuEntries

### function int WindowsIdToMessageId

## protected-func

### function void UpdatePositon

# class CFaceMaterialsDeleter

## public-func

### function CFaceMaterialsDeleter

### function BOOL BeginFace

# class CFileNotifyInformation

## protected-attrib

### variable DWORD m_dwBufferSize

### variable BYTE * m_pBuffer

### variable PFILE_NOTIFY_INFORMATION m_pCurrentRecord

## public-func

### function CFileNotifyInformation

### function BOOL CopyCurrentRecordToBeginningOfBuffer

### function DWORD GetAction

### function CString GetFileName

### function CString GetFileNameWithPath

### function BOOL GetNextNotifyInformation

# class CFontPool

## public-attrib

### variable BOOL m_fontsCreated

## protected-attrib

### variable CArray< CGLFont, CGLFont & > m_Fonts

## public-func

### function CFontPool

### function ~CFontPool

### function IGLFont * Add

### function void CreateFonts

### function void CreateFonts

### function IGLFont * GetFont

### function void UnloadFonts

## private-func

### function CFontPool

### function CFontPool & operator=

# class CG3DKernel

## public-type

### enum %type% FixObjectAfterBooleanOperations

### enum %type% LoadObjectFlag

## protected-static-attrib

### variable CMapPtrToPtr s_instances

## public-attrib

### variable double m_autoStretchFactor

### variable CString m_DefaultMaterialPath

### variable long m_DefaultRoot

### variable CStringList m_ExploreNames

### variable HINSTANCE m_hKernelInstance

### variable C3dImportManager m_importManager

### variable BOOL m_inRecord

### variable bool m_IsRedoingLog

### variable FILE * m_LogFile

### variable CMaterialCatalogSet m_Materials

### variable double m_MeasureBlue

### variable CString m_MeasureFont

### variable double m_MeasureGreen

### variable double m_MeasureObjectDist

### variable double m_MeasureRed

### variable int m_MeasureRoundTo

### variable int m_MeasureSizeDisplayType

### variable double m_MeasureTextDist

### variable double m_MeasureTextHeight

### variable int m_MeasureUnit

### variable CContentDlg * m_pContentDlg

### variable C3dPlugInManager m_PluginManager

### variable BOOL m_RedrawState

### variable CPtrArray m_RegisteredViews

### variable CString m_TextFont

### variable CPolylineTurtle m_turtle

### variable BOOL m_useClipperLibrary

### variable BOOL m_viewerAttached

## private-attrib

### variable CString m_basePath

### variable FixObjectAfterBooleanOperations m_fixObject

### variable CString m_mostRecentObjectName

### variable CString m_mostRecentSaveOrLoadPath

### variable hyper m_previousChangeCount

## public-func

### function CG3DKernel

### function ~CG3DKernel

### function STDMETHOD() AddAutoalignMeasureElement

### function STDMETHOD() AddCatchLine

### function STDMETHOD() AddCatchLineAxis

### function STDMETHOD() AddCatchLineOrientation

### function STDMETHOD() AddCatchPoint

### function STDMETHOD() AddCatchPointAxis

### function STDMETHOD() AddCatchPointOrientation

### function STDMETHOD() AddDefaultPos

### function STDMETHOD() AddLineElement

### function STDMETHOD() AddMeasureElement

### function STDMETHOD() AddMeasureElementToView

### function STDMETHOD() AddObjectMeasureElement

### function STDMETHOD() AddPickPoint

### function STDMETHOD() AddTextElement

### function STDMETHOD() ArcLeft

### function STDMETHOD() ArcRight

### function STDMETHOD() Beautify

### function STDMETHOD() Box

### function STDMETHOD() CatchAlign

### function STDMETHOD() CatchAlignAny

### function void Cleanup

### function STDMETHOD() CompressEdges

### function STDMETHOD() CompressFaces

### function STDMETHOD() CompressPoints

### function STDMETHOD() Cone

### function STDMETHOD() Copy

### function STDMETHOD() CreateCatalog

### function STDMETHOD() CreateDoubleAttribute

### function STDMETHOD() CreateIntAttribute

### function STDMETHOD() CreateLongAttribute

### function STDMETHOD() CreateMaterial

### function STDMETHOD() CreateNewJoint

### function STDMETHOD() CreateNewObject

### function STDMETHOD() CreateProducer

### function STDMETHOD() CreateStringAttribute

### function STDMETHOD() Cut

### function STDMETHOD() Cylinder

### function STDMETHOD() DebugDlg

### function STDMETHOD() DeGroup

### function STDMETHOD() DeleteAttribute

### function STDMETHOD() DeletePickPoint

### function STDMETHOD() DeleteTextureCoordinates

### function STDMETHOD() Difference

### function OBJID DoBox

### function OBJID DoCone

### function OBJID DoCreateNewObject

### function long DoCreateRoot

### function OBJID DoCylinder

### function void DoDeGroup

### function long DoDifference

### function void DoEnGroup

### function long DoExtrude

### function long DoExtrudePath

### function long DoGetElementChildCount

### function long long DoGetElementHeadPosition

### function bool DoGetElementName

### function BOOL DoGetElementVisibility

### function OBJID DoGetFather

### function long long DoGetNextElement

### function OBJID DoGetRootItem

### function long DoIntersection

### function bool DoKillObject

### function OBJID DoLoadObject

### function bool DoSaveElementToFile

### function bool DoSaveFileLink

### function void DoSetElementVisibility

### function BOOL DoSetRedraw

### function bool DoSmoothElement

### function OBJID DoSphere

### function OBJID DoTorus

### function long DoUnion

### function bool DoUnSmoothElement

### function STDMETHOD() EnableDeveloperMode

### function STDMETHOD() EnGroup

### function STDMETHOD() ExploreFile

### function STDMETHOD() Extrude

### function STDMETHOD() ExtrudePath

### function STDMETHOD() FindAttribute

### function STDMETHOD() FindMaterial

### function STDMETHOD() ForceIntoBox

### function STDMETHOD() get_m_DefaultRoot

### function STDMETHOD() get_m_hInstance

### function STDMETHOD() GetAmbientColor

### function STDMETHOD() GetAttributeCount

### function STDMETHOD() GetAttributeHeadPosition

### function STDMETHOD() GetAttributeType

### function STDMETHOD() GetBasePath

### function STDMETHOD() GetCatalogCount

### function STDMETHOD() GetCatalogHeadPosition

### function STDMETHOD() GetCatalogPath

### function STDMETHOD() GetColorProperties

### function STDMETHOD() GetDefaultMaterialPath

### function STDMETHOD() GetDiffuseColor

### function STDMETHOD() GetDoubleAttributeValue

### function STDMETHOD() GetElementAngles

### function STDMETHOD() GetElementChildCount

### function STDMETHOD() GetElementHeadPosition

### function STDMETHOD() GetElementLayer

### function STDMETHOD() GetElementName

### function STDMETHOD() GetElementOrientation

### function STDMETHOD() GetElementPosition

### function STDMETHOD() GetElementSize

### function STDMETHOD() GetElementVisibility

### function STDMETHOD() GetExploreHeadPosition

### function STDMETHOD() GetFather

### function STDMETHOD() GetIntAttributeValue

### function STDMETHOD() GetInterface

### function STDMETHOD() GetLongAttributeValue

### function STDMETHOD() GetMaterialHeadPosition

### function STDMETHOD() GetMaterialPool

### function CMaterialCatalogSet * GetMaterialPool

### function STDMETHOD() GetMeasureDefaultColor

### function STDMETHOD() GetNextAttribute

### function STDMETHOD() GetNextCatalog

### function STDMETHOD() GetNextElement

### function STDMETHOD() GetNextExplore

### function STDMETHOD() GetNextMaterial

### function STDMETHOD() GetNextProducer

### function STDMETHOD() GetPath

### function STDMETHOD() GetPickPoint

### function STDMETHOD() GetPrimitiveStringAttributeValue

### function STDMETHOD() GetProducerCount

### function STDMETHOD() GetProducerHeadPosition

### function STDMETHOD() GetRootItem

### function STDMETHOD() GetSpecularColor

### function STDMETHOD() GetStringAttributeValue

### function STDMETHOD() GetTextElementFont

### function STDMETHOD() GetTextElementHeight

### function STDMETHOD() GetTextElementText

### function STDMETHOD() GetTextElementThickness

### function STDMETHOD() GetTexture

### function STDMETHOD() GetValue

### function STDMETHOD() GetVersion

### function STDMETHOD() Intersection

### function STDMETHOD() IsDeveloperModeEnabled

### function STDMETHOD() IsModified

### function STDMETHOD() IsObjectId

### function STDMETHOD() KillObject

### function STDMETHOD() LoadFilter

### function STDMETHOD() LoadObject

### function STDMETHOD() LoadObjectEx

### function STDMETHOD() Log

### function STDMETHOD() Mirror

### function STDMETHOD() MirrorEx

### function STDMETHOD() MoveForward

### function STDMETHOD() NewTurtle

### function STDMETHOD() Objects

### function STDMETHOD() Primitives

### function STDMETHOD() RegisterViewer

### function bool ReplayRecord

### function STDMETHOD() RotateBy

### function STDMETHOD() RotateTo

### function STDMETHOD() RotationalSweep

### function STDMETHOD() SaveElementToFile

### function STDMETHOD() SaveFileLink

### function STDMETHOD() SaveMaterialsToFile

### function STDMETHOD() ScaleBy

### function STDMETHOD() ScaleTo

### function STDMETHOD() SeparatePrimitives

### function STDMETHOD() SetAmbientColor

### function STDMETHOD() SetAutoStretchFactor

### function STDMETHOD() SetBasePath

### function STDMETHOD() SetCatalogPath

### function STDMETHOD() SetColorProperties

### function STDMETHOD() SetDefaultMaterialPath

### function STDMETHOD() SetDiffuseColor

### function STDMETHOD() SetDoubleAttributeValue

### function STDMETHOD() SetElementAngles

### function STDMETHOD() SetElementLayer

### function STDMETHOD() SetElementMaterial

### function STDMETHOD() SetElementName

### function STDMETHOD() SetElementOrientation

### function STDMETHOD() SetElementSelMaterial

### function STDMETHOD() SetElementVisibility

### function STDMETHOD() SetFlag

### function STDMETHOD() SetHeading

### function STDMETHOD() SetIntAttributeValue

### function STDMETHOD() SetJointTo

### function STDMETHOD() SetLogFile

### function STDMETHOD() SetLongAttributeValue

### function STDMETHOD() SetMeasureDefaultColor

### function STDMETHOD() SetMeasureDefaultFont

### function STDMETHOD() SetMeasureDefaultObjectDist

### function STDMETHOD() SetMeasureDefaultTextDist

### function STDMETHOD() SetMeasureDefaultUnit

### function STDMETHOD() SetMeasureFont

### function STDMETHOD() SetModifiedElementMaterial

### function STDMETHOD() SetObjectRenderOffset

### function STDMETHOD() SetPosition

### function STDMETHOD() SetRecordPath

### function STDMETHOD() SetRedraw

### function STDMETHOD() SetSnapshotsDirectory

### function STDMETHOD() SetSpecularColor

### function STDMETHOD() SetStringAttributeValue

### function STDMETHOD() SetTextElementFont

### function STDMETHOD() SetTextElementHeight

### function STDMETHOD() SetTextElementText

### function STDMETHOD() SetTextElementThickness

### function STDMETHOD() SetTexture

### function STDMETHOD() ShrinkPolygon3D

### function STDMETHOD() SmoothElement

### function STDMETHOD() Sphere

### function STDMETHOD() SqueezeIntoBox

### function STDMETHOD() Torus

### function STDMETHOD() TranslateBy

### function STDMETHOD() TranslateTo

### function STDMETHOD() TurnLeft

### function STDMETHOD() TurnRight

### function STDMETHOD() Union

### function STDMETHOD() UnRegisterViewer

### function STDMETHOD() UnSmoothElement

### function void UpdateAllViews

## public-static-func

### function void CleanupAllInstances

## protected-func

### function BOOL AttribExists

### function void CreateCatalogs

### function bool DoPerformCatch

### function CMatrix FindNamedMatrix

### function bool FindObjectForCatch

### function bool FindObjectForCatch

### function void FixCatalogs

### function void FixObject

### function void ForceRedrawWindow

### function void ForceUpdateAll

### function void GetCatchInfo

### function void LoadImportFilter

### function void LoadKernelDll

### function void MakeSnapshot

### function void MakeSnapshotObject

### function BOOL Record

### function void SetNamedMatrix

### function BOOL TransferCatalogsDescriptions

### function void UpdateFonts

# class CGLFont

## private-attrib

### variable BOOL m_bCreated

### variable CMap< UINT, UINT, void *, void * > m_createdUnicodeCharacters

### variable float m_dMAmbient

### variable float m_dMDiffuse

### variable float m_dMEmission

### variable float m_dMShininess

### variable float m_dMSpecular

### variable CString m_FontName

### variable double m_FontSize

### variable GLFontType m_FontType

### variable GLYPHMETRICSFLOAT * m_gmfNonUnicode

### variable GLYPHMETRICSFLOAT * m_gmfUnicode

### variable CDoubleVector m_Offset

### variable CObjectViewerCtrl * m_pCurrentControl

### variable CDC * m_pDrawDC

### variable HDC m_previousUnicodeDC

### variable CDoubleVector m_Rotate

### variable CDoubleVector m_Scale

### variable UINT m_uiListID

## public-func

### function CGLFont

### function CGLFont

### function ~CGLFont

### function void Allocate

### function BOOL CreateFont

### function BOOL CreateFontUnicodeCharacter

### function BOOL CreateFontUnicodeCharacters

### function CObjectViewerCtrl * GetCurrentControl

### function CString GetFontName

### function double GetFontSize

### function GLFontType GetFontType

### function GLYPHMETRICSFLOAT * GetGmfNonUnicode

### function GLYPHMETRICSFLOAT * GetGmfUnicode

### function UINT GetListId

### function CDoubleVector GetRotate

### function CDoubleVector GetScale

### function double GetTextGlyphLength

### function double GetThickness

### function CDoubleVector GetYOffset

### function BOOL IsCreated

### function CGLFont & operator=

### function void RenderText

### function void SetCreated

### function void SetFontName

### function void SetFontSize

### function void SetFontType

### function void SetOffset

### function void SetRotate

### function void SetScale

## public-static-func

### function BOOL CreateFontNonUnicode

### function BOOL CreateFontUnicode

## private-func

### function void Delete

# class CInputDialog

## public-type

### enum %type% @1

## public-attrib

### variable bstr_t m_inputText

## protected-attrib

### variable CString m_defaultText

### variable CEdit m_inputTextEdit

## public-func

### function CInputDialog

### function ~CInputDialog

### function bstr_t GetInput

## protected-func

### function void DoDataExchange

### function int OnInitDialog

### function void OnOK

# class CKernelLicense

## protected-static-func

### function BOOL GetLicenseKey

### function BOOL IsLicenseValid

### function BOOL VerifyLicenseKey

### function BOOL VerifyUserLicense

# struct CLayer

## public-attrib

### variable bool m_Detectable

### variable bool m_Visible

# class CLayerManager

## protected-attrib

### variable CLayer m_Layers

## public-func

### function CLayerManager

### function bool IsDetectable

### function bool IsVisible

### function void SetDetectable

### function void SetVisible

# class CLight

## protected-attrib

### variable float m_Color

### variable float m_constantAttenuation

### variable unsigned int m_glNumber

### variable float m_linearAttenuation

### variable float m_Pos

### variable float m_quadraticAttenuation

## public-func

### function CLight

### function void DoGlLightInit

### function void GetColor

### function int GetLightMode

### function CVector GetPosition

### function void SetAttenuation

### function void SetColor

### function void SetLightMode

### function void SetPosition

# class CLightArray

## public-func

### function CLightArray

# struct CLightSetting

## public-attrib

### variable bool m_areaLight

### variable bool m_castShadows

### variable CVector m_luminance

### variable CVector m_position

## public-func

### function CLightSetting

# class ClipperLib::Clipper

## private-attrib

### variable TEdge * m_ActiveEdges

### variable PolyFillType m_ClipFillType

### variable ClipType m_ClipType

### variable bool m_ExecuteLocked

### variable JoinList m_GhostJoins

### variable IntersectNode * m_IntersectNodes

### variable JoinList m_Joins

### variable PolyOutList m_PolyOuts

### variable bool m_ReverseOutput

### variable std::set< cInt, std::greater< cInt > > m_Scanbeam

### variable TEdge * m_SortedEdges

### variable bool m_StrictSimple

### variable PolyFillType m_SubjFillType

### variable bool m_UsingPolyTree

## public-func

### function Clipper

### function ~Clipper

### function void Clear

### function bool Execute

### function bool Execute

### function bool ReverseSolution

### function void ReverseSolution

### function bool StrictlySimple

### function void StrictlySimple

## protected-func

### function bool ExecuteInternal

### function void Reset

## private-func

### function void AddEdgeToSEL

### function void AddGhostJoin

### function void AddJoin

### function void AddLocalMaxPoly

### function OutPt * AddLocalMinPoly

### function OutPt * AddOutPt

### function void AppendPolygon

### function void BuildIntersectList

### function void BuildResult

### function void BuildResult2

### function void ClearGhostJoins

### function void ClearJoins

### function void CopyAELToSEL

### function OutRec * CreateOutRec

### function void DeleteFromAEL

### function void DeleteFromSEL

### function void DisposeAllOutRecs

### function void DisposeIntersectNodes

### function void DisposeOutRec

### function void DoMaxima

### function void DoSimplePolygons

### function void FixHoleLinkage

### function void FixupFirstLefts1

### function void FixupFirstLefts2

### function bool FixupIntersectionOrder

### function void FixupOutPolygon

### function OutRec * GetOutRec

### function void InsertEdgeIntoAEL

### function void InsertIntersectNode

### function void InsertLocalMinimaIntoAEL

### function void InsertScanbeam

### function void IntersectEdges

### function bool IsContributing

### function bool IsEvenOddAltFillType

### function bool IsEvenOddFillType

### function bool IsHole

### function bool IsTopHorz

### function void JoinCommonEdges

### function bool JoinPoints

### function cInt PopScanbeam

### function void PrepareHorzJoins

### function void ProcessEdgesAtTopOfScanbeam

### function void ProcessHorizontal

### function void ProcessHorizontals

### function bool ProcessIntersections

### function void ProcessIntersectList

### function void SetHoleState

### function void SetWindingCount

### function void SwapPositionsInAEL

### function void SwapPositionsInSEL

### function void UpdateEdgeIntoAEL

# class ClipperLib::ClipperBase

## protected-attrib

### variable LocalMinima * m_CurrentLM

### variable EdgeList m_edges

### variable bool m_HasOpenPaths

### variable LocalMinima * m_MinimaList

### variable bool m_PreserveCollinear

### variable bool m_UseFullRange

## public-func

### function ClipperBase

### function ~ClipperBase

### function bool AddPath

### function bool AddPaths

### function bool AddPolygon

### function bool AddPolygons

### function void Clear

### function IntRect GetBounds

### function bool PreserveCollinear

### function void PreserveCollinear

## protected-func

### function TEdge * AddBoundsToLML

### function void AscendToMax

### function TEdge * DescendToMin

### function void DisposeLocalMinimaList

### function void DoMinimaLML

### function void InsertLocalMinima

### function void PopLocalMinima

### function void Reset

# class ClipperLib::clipperException

## private-attrib

### variable std::string m_descr

## public-func

### function clipperException

### function ~clipperException

### function const char * what

# struct ClipperLib::DoublePoint

## public-attrib

### variable double X

### variable double Y

## public-func

### function DoublePoint

### function DoublePoint

# class ClipperLib::Int128

## public-attrib

### variable cInt hi

### variable cUInt lo

## public-func

### function Int128

### function Int128

### function Int128

### function double AsDouble

### function bool operator!=

### function Int128 operator+

### function Int128 & operator+=

### function Int128 operator-

### function Int128 operator-

### function Int128 & operator-=

### function Int128 operator/

### function bool operator<

### function bool operator<=

### function Int128 & operator=

### function bool operator==

### function bool operator>

### function bool operator>=

# struct ClipperLib::IntersectNode

## public-attrib

### variable TEdge * Edge1

### variable TEdge * Edge2

### variable IntersectNode * Next

### variable IntPoint Pt

# struct ClipperLib::IntPoint

## public-attrib

### variable cInt X

### variable cInt Y

## public-func

### function IntPoint

## friend

### friend friend bool operator!=

### friend friend bool operator==

# struct ClipperLib::IntRect

## public-attrib

### variable cInt bottom

### variable cInt left

### variable cInt right

### variable cInt top

# struct ClipperLib::Join

## public-attrib

### variable IntPoint OffPt

### variable OutPt * OutPt1

### variable OutPt * OutPt2

# struct ClipperLib::LocalMinima

## public-attrib

### variable TEdge * LeftBound

### variable LocalMinima * Next

### variable TEdge * RightBound

### variable cInt Y

# class ClipperLib::OffsetBuilder

## private-attrib

### variable double m_cos

### variable Path * m_curr_poly

### variable double m_delta

### variable size_t m_i

### variable size_t m_j

### variable size_t m_k

### variable double m_miterLim

### variable const Paths & m_p

### variable double m_sin

### variable double m_sinA

### variable double m_Steps360

### variable std::vector< DoublePoint > normals

## private-static-attrib

### variable const int buffLength

## public-func

### function OffsetBuilder

## private-func

### function void AddPoint

### function void DoMiter

### function void DoRound

### function void DoSquare

### function void OffsetPoint

# struct ClipperLib::OutPt

## public-attrib

### variable int Idx

### variable OutPt * Next

### variable OutPt * Prev

### variable IntPoint Pt

# struct ClipperLib::OutRec

## public-attrib

### variable OutPt * BottomPt

### variable OutRec * FirstLeft

### variable int Idx

### variable bool IsHole

### variable bool IsOpen

### variable PolyNode * PolyNd

### variable OutPt * Pts

# class ClipperLib::PolyNode

## public-attrib

### variable PolyNodes Childs

### variable Path Contour

### variable PolyNode * Parent

## private-attrib

### variable unsigned Index

### variable bool m_IsOpen

## friend

### friend friend class Clipper

## public-func

### function PolyNode

### function int ChildCount

### function PolyNode * GetNext

### function bool IsHole

### function bool IsOpen

## private-func

### function void AddChild

### function PolyNode * GetNextSiblingUp

# class ClipperLib::PolyTree

## private-attrib

### variable PolyNodes AllNodes

## friend

### friend friend class Clipper

## public-func

### function ~PolyTree

### function void Clear

### function PolyNode * GetFirst

### function int Total

# struct ClipperLib::TEdge

## public-attrib

### variable IntPoint Bot

### variable IntPoint Curr

### variable IntPoint Delta

### variable double Dx

### variable TEdge * Next

### variable TEdge * NextInAEL

### variable TEdge * NextInLML

### variable TEdge * NextInSEL

### variable int OutIdx

### variable PolyType PolyTyp

### variable TEdge * Prev

### variable TEdge * PrevInAEL

### variable TEdge * PrevInSEL

### variable EdgeSide Side

### variable IntPoint Top

### variable int WindCnt

### variable int WindCnt2

### variable int WindDelta

# class CMaterialCatalog

## protected-attrib

### variable CMapStringToPtr m_Cataloges

### variable CString m_ProducerName

## public-func

### function ~CMaterialCatalog

### function CCatalogDescription * AddCatalog

### function void DeleteAll

### function CCatalogDescription * GetCatalog

### function int GetCount

### function POSITION GetFirstCatalog

### function CCatalogDescription * GetNextCatalog

### function CString GetProducer

### function void SetProducer

# class CMaterialCatalogSet

## friend

### friend friend class CG3DKernel

## protected-attrib

### variable CMapStringToPtr m_Cataloges

## public-func

### function CMaterialCatalogSet

### function ~CMaterialCatalogSet

### function void AddCatalog

### function CMaterialCatalog * AddMaterialCatalog

### function CCatalogDescription * FindCatalog

### function CColor * FindMaterial

### function BOOL FindSelMaterial

### function POSITION GetCatalogHeadPosition

### function CString GetCatalogImagePath

### function int GetCount

### function CString GetCurrentCatalog

### function CString GetCurrentProducer

### function POSITION GetFirstMaterialCatalog

### function CMaterialCatalog * GetMaterialCatalog

### function CCatalogDescription * GetNextCatalog

### function CMaterialCatalog * GetNextMaterialCatalog

### function void GuessDesiredColor

### function void ImportCatalogDescriptions

### function CColor * ReadMaterialFromAttrib

### function void SaveMaterials

## public-static-func

### function SECImage * LoadAttribTexture

### function void SaveAttribTexture

## protected-func

### function void DeleteAll

# class CMaterialReloader

## protected-attrib

### variable CString m_currentlyWatchedDirectory

### variable CMaterialsChangeHandler m_handler

### variable CObjectViewerCtrl & m_viewer

### variable CDirectoryChangeWatcher m_watcher

## public-func

### function CMaterialReloader

### function void SetMonitor

# class CMaterialReloader::CMaterialsChangeHandler

## protected-attrib

### variable CObjectViewerCtrl & m_viewer

## public-func

### function CMaterialsChangeHandler

## protected-func

### function void On_FileModified

# class CMaterialsChanger

## private-attrib

### variable const CMapStringToString & m_replacements

## public-func

### function CMaterialsChanger

### function BOOL BeginFace

### function BOOL BeginObject

### function BOOL BeginPrimitive

## private-func

### function CString ChangedMaterial

# class CMeasureSorter

## private-attrib

### variable long m_nPosition

### variable OBJID m_Root

### variable long m_Side

### variable long m_View

## public-func

### function CMeasureSorter

### function ~CMeasureSorter

### function void CollectMeasure

### function void Resort

# class CMenuItemArray

## public-func

### function CMenuItemArray

### function ~CMenuItemArray

### function BOOL DeleteMenuItem

### function MenuItem * GetMenuItem

## protected-func

### function void CleanUpMemory

# class CMultisample

## public-static-func

### function HGLRC CreateMultisampleContext

Versucht, einen Multisampling-Kontext zur erzeugen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hWnd | (HWND) Fenster, für das der Kontext erzeugt werden soll. |
| hDC | (HDC) Ein dem Fester zugeordneter Device-Kontext. |
| bitsPerPixel | (int) Gewünschte Farbtiefe. |

#### return

(HGLRC) Enthält den Multisampling-Kontext, wenn dieser erfolgreich erzeugt werden konnte, sonst NULL.

# class CMultisampleHelper

## private-attrib

### variable int g_arbMultisampleFormat

Wenn größer 0, die Nummer des angeforderten und von der Hardware unterstützten Multisampling-Formats.

### variable bool g_arbMultisampleSupported

TRUE, wenn die Hardware Multisampling unterstützt; FALSE, wenn die Hardware keine Multisampling unterstützt oder die entsprechende Prüfung noch nicht durchgeführt wurde.

## public-func

### function CMultisampleHelper

### function HGLRC CreateMultisampleContext

Versucht, einen Multisampling-Kontext zur erzeugen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hWnd | (HWND) Fenster, für das der Kontext erzeugt werden soll. |
| hDC | (HDC) Ein dem Fester zugeordneter Device-Kontext. |
| bitsPerPixel | (int) Gewünschte Farbtiefe. |

#### return

(HGLRC) Enthält den Multisampling-Kontext, wenn dieser erfolgreich erzeugt werden konnte, sonst NULL.

#### remark

-

## private-func

### function BOOL CreateOpenGLContext

Versucht, einen Multisampling-Kontext zu erzeugen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hInstance | (HINSTANCE) Instanz des Prozesses (typischerweise ::AfxGetInstanceHandle()). |
| hTemporaryDC | (HDC) Temporärer Device-Context. Nötig, weil lt. Windows ein temporärer Render-Kontext erzeugt werden muß, um die Extension-DLLs zur laden. |
| hWnd | (HWND) empty Fenster, für den der Multisampling-Kontext erzeugt werden soll. |
| hDC | (HDC) Tatsächlicher Device-Context. Muß dem Fenster "hWnd" zugeordnet sein. |
| bitsPerPixel | (int) Farbtiefe. |
| hRC | (HGLRC&) Enthält den Multisampling-Kontext, wenn dieser erfolgreich erzeugt werden konnte, sonst NULL. |

#### return

(BOOL) TRUE, wenn der Multisampling-Kontext erzeugt werden konnte, sonst FALSE.

#### remark

-

### function HWND CreateTemporaryWindow

Erzeugt ein temporäres Fenster.

#### return

(HWND) Enthält das temporäre Fenster, wenn es erfolgreich erzeugt werden konnte, sonst NULL.

#### remark

Für das Löschen des Fensters mit DestroyWindow ist der Aufrufer zuständig.

### function bool InitMultisample

Versucht, Multisampling zu initialisieren.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hInstance | (HINSTANCE) Instanz des Prozesses (typischerweise ::AfxGetInstanceHandle()). |
| hWnd | (HWND) Fenster, für das der Deskriptor gesucht werden soll. |
| pfd | (PIXELFORMATDESCRIPTOR) Deskriptor. |

#### return

(bool) TRUE, falls ein geeigneter Deskriptor gefunden werden konnte, sonst FALSE.

#### remark

Es wird versucht, einen Deskriptor für den höchsten Sampling-Wert zu ermitteln, der von der Hardware unterstützt wird.

### function void ShowDebugMessage

Zeigt eine Messagebox mit eine Debug-Meldung an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| msg | (const CString&) Die anzuzeigende Debug-Meldung. |

#### return

(static) empty

#### remark

Die Meldung wird nur angezeigt, wenn die Definition MS_SHOW_DEBUG_MESSAGES auf TRUE gesetzt ist.

### function bool WglIsExtensionSupported

Ermittelt, ob die angegebene Erweiterung von der Grafikkarte unterstützt wird.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| extension | (const char*) Name der Erweiterung. |

#### return

(bool) TRUE, wenn die Erweiterung unterstützt wird, sonst FALSE.

#### remark

-

## private-static-func

### function CString LastErrorMessage

Gibt die Meldung zurück, die zum zuletzt aufgetretenen Windows-Fehler gehört.

#### return

(static CString) Meldung

#### remark

-

### function BOOL RegisterTemporaryWindowClass

Registriert eine Klasse für das während der Initialisierung nötige temporäre Fenster.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| className | (const CString&) Name der Klasse. |

#### return

(static BOOL) TRUE, wenn die Klasse erfolgreich registriert werden konnte, sonst FALSE.

#### remark

-

### function LRESULT CALLBACK WindowProc

Leere Fensterprozedur.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hWnd | (HWND) Ignoriert (wird an die Standardfensterprozedur weitergegeben). |
| uMsg | (UINT) Ignoriert (wird an die Standardfensterprozedur weitergegeben). |
| wParam | (WPARAM) Ignoriert (wird an die Standardfensterprozedur weitergegeben). |
| lParam | (LPARAM) Ignoriert (wird an die Standardfensterprozedur weitergegeben). |

#### return

(static LRESULT CALLBACK) Ignoriert (wird von der Standardfensterprozedur zurückgegeben).

#### remark

-

# class CMy3DEngineApp

## public-func

### function int ExitInstance

### function BOOL InitInstance

# class CObjectViewerApp

## public-func

### function int ExitInstance

### function BOOL InitInstance

# class CObjectViewerCtrl

## protected-type

### enum %type% @2

### enum %type% SetDeviceContext

## friend

### friend friend struct C3dEnvironment

### friend friend struct CRefreshImmediatelyEnsurer

### friend friend struct StandardValues

## protected-static-attrib

### variable int m_defaultOverride

### variable PALETTEENTRY m_defaultPalEntry

### variable unsigned char m_oneto8

### variable unsigned char m_threeto8

### variable unsigned char m_twoto8

### variable CMapPtrToPtr s_instances

## protected-attrib

### variable int m_AAQuality

### variable AdjustmentMode m_adjustmentMode

### variable double m_Aspect

### variable BOOL m_AutoAdjustView

### variable double m_autoAmbient

### variable double m_autoDiffuse

### variable double m_autoSpecular

### variable double m_Background

### variable COpenGLBallCtrl m_BallControl

### variable CMyBitmap m_bitmap

### variable IFontPool * m_bitmapFontPool

### variable bool m_bNeedEyePoint

### variable bool m_bNeedRebuild

### variable bool m_bOpaquePass

### variable double m_boxAspect

### variable float m_boxHeight

### variable double m_BoxRadius

### variable float m_boxWidth

### variable bool m_bRebuildNotNormalObjectsOnly

### variable bool m_bRebuildSceneryOnly

### variable bool m_bRebuildSelectedOnly

### variable BrightnessLevel m_brightness

### variable CatchDisplayMode m_CatchDisplayMode

### variable int m_CatchDistance

### variable bool m_CatchSubElements

### variable list< CString > m_complexObjects

### variable double m_contextMenusDebugItemsAdded

### variable int m_Current2DLineColor

### variable std::vector< COLORREF > m_currentPixels

### variable HDC m_currentRenderDC

### variable CColor m_DefaultColor

### variable BOOL m_doSetupOffscreenRendering

### variable double m_DownZoomFactor

### variable int m_DragElementBoxX

### variable int m_DragElementBoxY

### variable int m_DragElementBoxZ

### variable bool m_DrawPending

### variable double m_edgeEnhancementOffset

### variable double m_EyeDist

### variable IFontPool * m_FontPool

### variable COLORREF m_globalAlphaColor

### variable HGLRC m_hBitmapRC

### variable BOOL m_highResolutionRaytrace

Für die Darstellung wird Raytracing (d.h. Povray) anstelle von OpenGL verwendet. Ident mit "RenderMode == RENDER_RAYTRACED".

Nur relevant bei "m_inRaytracingMode == TRUE". Besagt, ob Raytracing in der aktuellen Fenstergröße oder größer (für Druckzwecke) durchzuführen ist.

### variable HINSTANCE m_hKernel

### variable CHoleTriangulator m_HoleTriangulator

### variable HPALETTE m_hPalOld

### variable HGLRC m_hRC

### variable IdentifyMode m_IdentifyMode

### variable ImageDefinitions m_imageDefinitions

### variable BOOL m_inRaytracingMode

### variable CMatrix m_InvWorkplane

### variable BOOL m_isDragging

### variable BOOL m_isFastCpu

### variable BOOL m_isHardwareAntialiasingEnabled

### variable bool m_isRenderingToControlEnabled

### variable double m_isSavingScenery

There's currently a "SaveSceneryToBitmap" or "SaveSceneryToMemory" active.

### variable OBJID m_LastMovedElement

### variable CMatrix m_LastMovedElementPosition

### variable CLayerManager m_LayerManager

### variable BOOL m_lightBrightnessGradient

### variable CLightArray m_Lights

### variable double m_lineFactor

### variable CSingleLock m_lock

### variable BOOL m_manualMeasuresModified

### variable CMaterialReloader m_materialsReloader

### variable CString m_mostRecentFontName

### variable CPoint m_MouseDownPos

### variable int m_MouseMode

### variable CComponent m_mouseOverPickPointColor

### variable CPoint m_MousePos

### variable BOOL m_nearLight

### variable OBJID m_objectToBeSelected

### variable bool m_oldUseWorkplane

### variable COnlineTexts m_OnlineTexts

### variable COpenGLHelper m_openGLHelper

### variable OpenGlType m_openGlType

### variable BOOL m_OriginAxisEnabled

### variable CVector2D m_Pan

### variable CPoint m_PanDown

### variable CDC * m_pDC

### variable CComponent m_PickPointColor

### variable CPickSet m_PickSet

### variable CxImage * m_pImage

### variable IG3DKernel * m_pKernelRef

### variable CDynamicPopUpMenu m_PopUpMenu

### variable CPalette * m_pPal

### variable int m_preAutoMouseMode

### variable int m_preSetMouseModeAddTextMode

### variable set< TCHAR > m_previousCharacters

### variable OBJID m_previousRootObject

### variable CPrintLayout m_printLayout

### variable int m_PrintQuality

### variable bool m_refreshImmediately

### variable DWORD m_refreshTimer

### variable BOOL m_renderEnhanced

Es soll in verbesserter Darstellung gerendert werden. Betrifft OpenGL und Raytracing, wenngleich die meisten Verbesserungen (z.B. mit Schatten rendern) nur für OpenGL Sinn ergeben (Raytracing erfolgt wird immer mit Schatten).

### variable int m_RenderMode

### variable bool m_RenderShadowBox

### variable bool m_RenderShadows

### variable OBJID m_Root

### variable BOOL m_RotationAxisEnabled

### variable bool m_saveOnStandardValueChanged

### variable double m_scaling

### variable CVector m_SceneBoxMax

### variable CVector m_SceneBoxMin

### variable GLuint m_SceneCallList

### variable CCatchSet m_SceneryCatchSet

### variable SelObList m_Selected

### variable GLuint m_SelectedCallList

### variable CString m_SelectedCatch

### variable int m_SelectedCatchId

### variable CCatchSet m_SelectedCatchSet

### variable GLfloat m_SelectedDepth

### variable double m_SelectedDist

### variable OBJID m_SelectedElement

### variable CComponent m_SelectedElementColor

### variable CMatrix m_SelectedMovePos

### variable CDoubleVector m_SelectedOffset

### variable CComponent m_SelectedPickPointColor

### variable GLfloat * m_SelectedPlaneDepth

### variable CMatrix m_SelectedPos

### variable CDoubleVector m_SelectedTextOffset

### variable SelectionMode m_SelMode

### variable BOOL m_setFocusOnMouseOver

### variable GLuint m_ShadowVolume

### variable int m_Shape

### variable CSimpleTriangulator m_SimpleTriangulator

### variable CString m_SnappedCatch

### variable int m_SnappedCatchId

### variable OBJID m_SnappedElement

### variable CMapStringToString m_texts

### variable OBJID m_TextureGroup

### variable CTexturePool * m_TexturePool

### variable TriangleData * m_TriangleData

### variable int m_TriangleNr

### variable CVector * m_TriangleVector

### variable int m_UseGroup

### variable bool m_useOldEdgeEnhancement

### variable bool m_UseWorkplane

### variable CDoubleVector m_vCenter

### variable double m_ViewAngleX

### variable double m_ViewAngleY

### variable double m_ViewAngleZ

### variable CViewer2DLineArray m_Viewer2DLines

### variable CViewer3DLines m_viewer3DLines

### variable int m_ViewMode

### variable CVector2D m_ViewportLeftTop

### variable CVector2D m_ViewportRightBottom

### variable CMatrix m_Workplane

### variable CVector2D m_ZoomCenter

### variable double m_ZoomFactor

### variable ZoomMode m_ZoomMode

### variable CRect m_ZoomRect

### variable BOOL m_ZoomRectExists

### variable CPoint m_ZoomRectStart

### variable CZoomStack m_ZoomStack

### variable bool mesaNiceRender

### variable CMyBitmap WindowData

## public-func

### function CObjectViewerCtrl

### function void Add2DLine

### function int Add3DLine

### function void ClearAll2DLines

### function void ClearAll3DLines

### function void DoRemoveFromTextureCache

### function CString GetDefaultMaterialPath

### function HGLRC GetHRC

### function HWND GetHwnd

### function BOOL GetIsFastCpu

### function short GetPrintQuality

### function int IsLayerVisible

### function void OnImageError

### function afx_msg void OnShowWindow

### function afx_msg void OnTimer

### function void PrintPage

### function void ReloadMaterials

### function void Remove2DLine

### function BOOL Remove3DLine

### function void RequestRefresh

### function void Reset

### function void Set2DLineColor

### function void SetLayerVisibility

### function void SetLineFactor

### function void SetPrintQuality

### function void SetStartPosition

### function void UseWorkplane

## public-static-func

### function void CleanupAllInstances

## protected-func

### function ~CObjectViewerCtrl

### function void AboutBox

### function void accFrustum

### function void accPerspective

### function BOOL AddContextMenuDebugItems

### function void AddFonts

### function afx_msg BOOL AddMenuItem

### function afx_msg BOOL AddMenuSeperator

### function bool AddModifiedMaterial

### function afx_msg BOOL AddSubMenuItem

### function BOOL AddText

Text an der angegebenen Position einsetzen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| CPoint_point | Punkt in Client-Koordinaten. |

#### return

boolean Wenn der Text erfolgreich eingesetzt werden konnte, wird "true" zurückgegeben, sonst "false".

### function void AdjustEyePoint

### function void AlphaImageTest

### function void ApplyView

### function afx_msg BOOL AreOriginAxisEnabled

### function afx_msg BOOL AreRotationAxisEnabled

### function afx_msg BOOL Beautify

### function afx_msg void BeginDragElement

### function void BeginDragMove

### function void CalcRsScaling

### function afx_msg void CatchSubElements

### function afx_msg BOOL ChangeSelectedText

### function void CheckGraficComplexity

Checks the grafic complexity.

<autogeneratedoc>

### function afx_msg BOOL CheckMenuItem

### function void Cleanup

### function void Cleanup3DLines

### function BOOL CleanupOffscreenRendering

### function afx_msg void ClearSelection

### function void CollectCatchSet

### function void CollectCatchSet

### function CString CollectedTexts

### function void CollectPickSet

### function unsigned char ComponentFromIndex

### function BOOL ConvertClientToWorld

### function BOOL CopyImage

### function afx_msg void CopySceneryToClipboard

### function afx_msg short CreateLight

### function CPalette * CreateRGBPalette

### function CString CurrentFontName

### function DECLARE_OLETYPELIB

### function BOOL DegroupMeasures

### function afx_msg BOOL DeleteImageEx

### function afx_msg BOOL DeleteLight

### function afx_msg BOOL DeleteMenuItem

### function afx_msg BOOL DeleteMenuSeperator

### function afx_msg BOOL DeleteSelectedElement

### function CVector DetermineXUpVect

### function CVector DetermineYUpVect

### function CVector DetermineZUpVect

### function CVector2D DeviceToLogical

### function afx_msg BOOL DisableMenuItem

### function void DoDragMove

### function void DoDraw2DLines

### function void DoDrawRubberLine

### function CString DoGetText

### function afx_msg long DoIdentifyElement

### function void DoPropExchange

### function int DoRealizePalette

### function void DoRefreshWindow

### function BOOL DoSaveSceneryToImage

### function afx_msg void DragElement

### function void Draw3DLines

### function void DrawAxisCross

### function void DrawCatchSet

### function BOOL DrawEdgeSelection

### function BOOL DrawFullBoxSelection

### function BOOL DrawImage

Zeichnet das Bild in "m_pImage", falls vorhanden, in den angegebenen Gerätekontext.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| dc | Getärtekontext. |
| targetRect | Bereich, in den das Bild hineingezeichnet werden soll. |
| drawIntoWindow | Wenn "wahr", soll in das Fenster des Object-Viewers hineingezeichnet werden, wenn "falsch", soll ausgedruckt werden. |

#### return

Erfolg?

### function BOOL DrawImageToFrameBuffer

### function void DrawPickSet

### function void DrawPixel

### function void DumpMaterials

### function CTexture * DuplicateTextureToLocalPool

### function afx_msg short ElementChanged

### function afx_msg void EnableAutoAdjustView

### function afx_msg void EnableAutoLighting

### function afx_msg void EnableDeveloperMode

### function afx_msg void EnableElementMove

### function afx_msg BOOL EnableMenuItem

### function afx_msg void EnableOriginAxis

### function afx_msg void EnablePickMode

### function afx_msg void EnableRefreshImmediately

### function afx_msg void EnableRenderingToControl

### function afx_msg void EnableRotation

### function afx_msg void EnableRotationAxis

### function afx_msg void EnableSetFocusOnMouseOver

### function afx_msg void EnableShadow

### function afx_msg void EnableShadowBox

### function afx_msg void EnableZoom

### function afx_msg void EndDragElement

### function void EndDragMove

### function BOOL EngroupMeasures

### function void EnlargeByMeasure

### function BOOL ExportPovrayFile

### function void FireOnElementMoved

### function void FireOnElementMoving

### function void FireOnElementSelect

### function void FireOnImageError

### function void FireOnInfoClick

### function void FireOnLButtonDown

### function void FireOnLButtonUp

### function void FireOnMenuItemClick

### function void FireOnMouseModeChanged

### function void FireOnMouseMove

### function void FireOnPickSelect

### function void FireOnRButtonDown

### function void FireOnRButtonUp

### function void ForceRedraw

### function BSTR GenerateViewId

### function OBJID GetActualRoot

### function afx_msg long GetAdjustmentMode

### function afx_msg short GetAntialiasingQuality

### function afx_msg int GetBitmapAntialiasingFactor

### function afx_msg short GetCatchDisplayMode

### function afx_msg short GetCatchDistance

### function afx_msg BOOL GetCatchSubElements

### function afx_msg void GetDragElementPosition

### function afx_msg double GetEdgeEnhancementOffset

### function afx_msg BSTR GetExtensions

### function OBJID GetGroupTopParent

### function OBJID GetHitObject

### function OBJID GetHitObject

### function afx_msg short GetIdentifyMode

### function _DObjectViewer * GetInterfacePtr

### function afx_msg void GetKernel

### function BOOL GetLicenseKey

### function afx_msg BOOL GetLightColor

### function afx_msg BOOL GetLightPosition

### function IMaterialPool & GetMaterialPool

### function afx_msg short GetMouseMode

### function CString GetOutputPath

### function afx_msg short GetPickMode

### function afx_msg void GetPickPointColor

### function afx_msg double GetRealBitmapHeight

### function afx_msg double GetRealBitmapWidth

### function afx_msg short GetRenderMode

### function afx_msg short GetSelectedCount

### function afx_msg long GetSelectedElement

### function afx_msg void GetSelectedPickPointColor

### function afx_msg void GetSelectionColor

### function afx_msg short GetSelectionMode

### function void GetStandardValues

### function afx_msg BSTR GetText

### function void GetTriangleExtrema

### function afx_msg void GetVersion

### function afx_msg void GetView

### function afx_msg short GetViewMode

### function afx_msg LONG_PTR GetWindowHandle

### function afx_msg void GetWorkplane

### function afx_msg short GetZoomMode

### function void GloballyEnableRenderingToControl

### function bool GloballyIsRenderingToControlEnabled

### function afx_msg BOOL HasGraphics

### function bool HasText

### function OBJID IdentifyClick

### function OBJID IdentifyClick

### function afx_msg long IdentifyElement

### function OBJID IdentifyGroupParent

### function OBJID IdentifyParent

### function long IdentifyPick

### function long IdentifyPickNoSelect

### function afx_msg long IdentifyPickPoint

### function BOOL InitializeGraphics

### function void InitRenderSettings

### function afx_msg BOOL IsAutoAdjustViewEnabled

### function afx_msg BOOL IsAutoLightingEnabled

### function afx_msg BOOL IsDeveloperModeEnabled

### function afx_msg BOOL IsElementMoveEnabled

### function afx_msg BOOL IsElementSelected

### function afx_msg BOOL IsHardwareAntialiasingEnabled

### function afx_msg BOOL IsMeasureSelected

### function afx_msg BOOL IsModified

### function afx_msg BOOL IsObjectDamaged

### function afx_msg BOOL IsRefreshImmediatelyEnabled

### function afx_msg BOOL IsRenderingToControlEnabled

### function BOOL IsRenderModeWithEnhancement

### function BOOL IsRenderModeWithoutEnhancement

### function afx_msg BOOL IsRotationEnabled

### function afx_msg BOOL IsSetFocusOnMouseOverEnabled

### function afx_msg BOOL IsShadowBoxEnabled

### function afx_msg BOOL IsShadowEnabled

### function BOOL IsSoftwareAntialiasingAllowed

### function afx_msg BOOL IsTextSelected

### function afx_msg BOOL IsZoomEnabled

### function BOOL Load3DKernel

### function BOOL LoadImportFilter

### function afx_msg void Log

### function BOOL MakeCurrent

### function afx_msg BOOL ManualMeasuresModified

### function bool MaterialExistsInDb

### function afx_msg void OnChar

### function afx_msg int OnCreate

### function afx_msg void OnDestroy

### function bool OnDeveloperModeChanged

### function void OnDraw

### function void OnDrawMetafile

### function afx_msg BOOL OnEraseBkgnd

### function void OnFinishRendering

### function afx_msg void OnHint

### function afx_msg void OnKeyDown

### function afx_msg void OnLButtonDblClk

### function afx_msg void OnLButtonDown

### function afx_msg void OnLButtonUp

### function void OnlineRenderText

### function void OnlineRenderTexts

### function void OnMenuCommand

### function bool OnModifiedElementMaterialSet

### function afx_msg void OnMouseMove

### function afx_msg BOOL OnMouseWheel

### function afx_msg void OnPaletteChanged

### function bool OnPostLoad

### function bool OnPreLoad

### function bool OnPreSave

### function afx_msg BOOL OnQueryNewPalette

### function afx_msg void OnRButtonDown

### function afx_msg void OnRButtonUp

### function void OnRender

### function void OnResetState

### function afx_msg BOOL OnSetCursor

### function afx_msg void OnSetFocus

### function void OnSetupView

### function afx_msg void OnSize

### function bool OnStandardValueChanged

### function void OnUpdateCommandUI

### function afx_msg short PickEnabled

### function afx_msg void PostLoad

### function BOOL PreCreateWindow

### function void PrepareDragWorkplane

### function C3dFilter * PrepareFilter

### function afx_msg void PreSave

### function BOOL Project

Projects the specified world position.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| worldPosition | The world position. |
| clientPosition | The client position. |
| safe | Get matrixes safely? |

#### return

Success?

### function BOOL ProjectRectangle

### function BOOL Read3DLines

### function void ReadBitmap

### function BOOL ReadStandardValues

### function void RebuildCallLists

### function void RecordZoomEntry

### function afx_msg void RefreshWindow

### function afx_msg void RemoveFromTextureCache

### function bool RemoveScenery

### function void RenderLine

### function void RenderMeasure

### function void RenderMesaTextObject

### function void RenderObject

### function void RenderObjectShadowVolume

### function void RenderPrimitive

### function void RenderPrimitive

### function void RenderPrimitiveShadowVolume

### function void RenderScene

### function void RenderSceneAntialiased

### function void RenderShadowVolume

### function void RenderText

### function void RenderToBitmap

### function void RenderToDC

### function void RenderTriangleVertex

### function void RenderWalls

### function afx_msg void ResetView

### function afx_msg void ResetZoom

### function void SafeGetProjection

### function BOOL SaveCurrentRoot

### function afx_msg BOOL SaveElementToFile

### function afx_msg BSTR SaveSceneryToBase64

### function afx_msg BOOL SaveSceneryToFile

### function BOOL SaveSceneryToImage

### function afx_msg VARIANT SaveSceneryToMemory

### function void ScaleTextBoxTo

### function afx_msg BOOL SelectElement

### function BOOL SelectItems

### function afx_msg BOOL SelectPickPoint

### function afx_msg void SetAdjustmentMode

### function afx_msg short SetAntialiasingQuality

### function afx_msg double SetAutoStretchFactor

### function afx_msg BOOL SetBackgroundColor

### function afx_msg void SetBitmapAntialiasingFactor

### function afx_msg void SetBrightness

### function afx_msg void SetCatchDisplayMode

### function afx_msg void SetCatchDistance

### function void SetDCPixelFormat

### function void SetDefaultColor

### function afx_msg void SetDragElementPosition

### function afx_msg void SetEdgeEnhancementOffset

### function afx_msg BOOL SetElementName

### function bool SetGlobalAlphaColorInAllCatalogs

### function afx_msg void SetGlobalTransparencyColor

### function afx_msg BOOL SetIdentifyMode

### function afx_msg BOOL SetImage

### function afx_msg long SetImageEx

### function afx_msg BOOL SetImageExLayer

### function bool SetLayerVisibilities

### function afx_msg void SetLayoutPath

### function afx_msg BOOL SetLightColor

### function afx_msg BOOL SetLightPosition

### function afx_msg void SetLogFile

### function BOOL SetMaterial

### function afx_msg BOOL SetMenuItemData

### function afx_msg BOOL SetMenuItemDataString

### function afx_msg BOOL SetMenuItemText

### function afx_msg void SetMesaNiceRender

### function afx_msg void SetMouseMode

### function afx_msg BOOL SetPickPointColor

### function afx_msg void SetRenderMode

### function afx_msg BOOL SetSelectedPickPointColor

### function afx_msg BOOL SetSelectionColor

### function afx_msg BOOL SetSelectionMode

### function afx_msg void SetSettingsDirectory

### function void SetStandardValues

### function afx_msg void SetText

### function void SetTranslationsFromAttributes

### function void SetupFontColor

### function BOOL SetupOffscreenRendering

### function afx_msg void SetView

### function afx_msg void SetViewMode

### function afx_msg void SetWorkplane

### function afx_msg BOOL SetZoomMode

### function afx_msg void ShowHelp

### function afx_msg BOOL StraightenTextures

### function afx_msg void Test

### function BOOL Transfer3DLines

### function BOOL TransferImageDescriptions

### function BOOL TransferStandardValues

### function afx_msg BOOL UnCheckAllMenuEntries

### function afx_msg void UndoLastElementMove

### function afx_msg void UndoLastZoom

### function afx_msg BOOL UnSelectElement

### function afx_msg BOOL UnSelectPickPoint

### function BOOL UpdateAutoLighting

### function void UpdateBox

### function BOOL UpdateContextMenuDebugItems

### function bool UpdateModifiedElementColors

### function afx_msg void UpdateNow

### function afx_msg BOOL UseKernel

### function afx_msg BOOL UseKernelObject

### function BOOL VerifyLicenseKey

### function BOOL VerifyUserLicense

### function BOOL Write3DLines

### function BOOL WriteStandardValues

### function void Zoom

### function void Zoom

### function afx_msg void ZoomToFit

# struct CObjectViewerHelpers

## public-static-func

### function double AngleTest

Die Funktion scheint, im Gegensatz zum Namen, den Winkel zwischen a und b zu berechnen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| a | Vektor a. |
| b | Vektor b. |

#### return

Winkel zwischen a und b.

### function HWND CreateTemporaryWindow

Erzeugt ein temporäres Fenster.

#### return

Wenn das temporäre Fenster erzeugt werden konnte, wird dessen Fensterhandle zurückgegeben, andernfalls NULL.
Der Aufrufer ist dafür verantwortlich, daß das Fenster wieder mit DestroyWindow freigegeben wird.

### function void DumpMaterialInfo

### function CString EncodeUrl

Kodiert die Sonderzeichen einer URL.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| url | URL, deren Sonderzeichen kodiert werden sollen. |

#### return

URL mit kodierten Sonderzeichen.

### function BOOL IsObliqueVector

Prüft, ob ein Vektor "windschief" ist, d.h. zu keiner der Hauptachsen parallel verläuft.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| vector | Vektor. |

#### return

Wenn der Vektor "windschief" ist, wird TRUE zurückgegeben, andernfalls FALSE.

### function BOOL ReadFrameBuffer

Framebuffer auslesen und in eine Bitmap schreiben.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| width | Bildbreite in Pixel. |
| height | Bildhöhe in Pixel. |
| bitmap | Bitmap, in die der Framebuffer geschrieben werden soll. |

#### return

Wenn die Bitmap erfolgreich geschrieben werden konnte, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function BOOL ReplaceMaterials

Ändert Materialien in Objekten, Primitiva und Flächen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| rootId | Das Objekt, ab dem die Materialien gändert werden sollen. |
| replacements | Hashtable mit den Änderungen. |

#### return

Wenn die Änderungen durchgeführt werden konnten, wird TRUE zurückgegeben, andernfalls FALSE.

### function BOOL ReviseBrightness

Ändert die Helligkeit der angegebenen Farbe.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| color | Farbe. |
| amount | Faktor, um den die Helligkeit vergrößert werden soll. |

#### return

Wenn die Farbe verändert werden konnte, wird TRUE zurückgegeben, andernfalls FALSE.

### function BOOL ReviseSaturation

Ändert die Sättigung der angegebenen Farbe.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| color | Farbe. |
| amount | Faktor, um den die Sättigung vergrößert werden soll. |

#### return

Wenn die Farbe verändert werden konnte, wird TRUE zurückgegeben, andernfalls FALSE.

### function void SaveFramebufferToFile

### function void SaveStencilBuffer

### function BOOL SetupRenderingToTexture

OpenGL für das Rendern eines Bildes in eine Textur aufsetzen.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| width | Bildbreite in Pixel. |
| height | Bildhöhe in Pixel |

#### return

Wenn die Initialisierung erfolgreich durchgeführt werden konnte, wird "TRUE" zurückgegeben, andernfalls "FALSE".

## private-static-func

### function char from_hex

Converts a hex character to its integer value.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| ch | Hexadecimal character. |

#### return

Integer-value.

### function BOOL RegisterTemporaryWindowClass

Registriert eine Fensterklasse.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| className | Name der Fensterklasse. |

#### return

Wenn die Fensterklasse registriert werden konnte, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function char to_hex

Converts an integer value to its hex character.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| code | Integer-Value |

#### return

Hexadecimal character.

### function char * url_encode

Url-encodes the specified string.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| str | The string to be encoded. |

#### return

The Url-encoded string.
IMPORTANT: be sure to free() the returned string after use.

### function LRESULT CALLBACK WindowProc

Generische Fensterprozedur

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| hWnd | Fensterhandle. |
| uMsg | Die zu verarbeitende Message. |
| wParam | Der WORD-Parameter. |
| lParam | Der LONG-Parameter. |

#### return

# class CObjectViewerIsVisibleFilter

## public-attrib

### variable IG3DKernel & m_kernel

### variable CLayerManager & m_layerManager

## public-func

### function CObjectViewerIsVisibleFilter

### function BOOL Accept

# class CObjectViewerPropPage

## public-type

### enum %type% @3

## public-func

### function CObjectViewerPropPage

## protected-func

### function void DoDataExchange

# class CPickDistance

## public-attrib

### variable CVector _v1

### variable CVector _v2

### variable double Angtxt

### variable int m_dist

### variable int m_xdist

### variable int m_ydist

### variable int m_zdist

### variable int ntype

### variable long PickDistanceId

## public-func

### function CPickDistance

### function CPickDistance

### function void operator=

# class CPickPoint

## public-attrib

### variable long m_HostObject

### variable bool m_MouseOver

### variable CString m_Name

### variable CVector2D m_ScreenPos

### variable bool m_Selected

### variable CMatrix m_WorldPos

## public-func

### function CPickPoint

### function CPickPoint

# class CPickSet

## public-attrib

### variable int m_mode

### variable std::list< CPickDistance > m_PickDistList

## public-func

### function void CheckDistance

### function void DeSelect

### function void Select

### function void SetMode

### function void UnSelect

# class CPolylineTurtle

## public-type

### typedef CTurtleVector CDirection

### typedef CTurtleVector CPosition

### typedef CArray< CTurtleVector, CTurtleVector & > CTurtlePath

## public-static-attrib

### variable const double DEF_ANGLE_INTERVAL

### variable const double DEF_DISTANCE_INTERVAL

## private-attrib

### variable CDirection m_currentDirection

Aktuelle Ausrichtung der Turtle in Radiant. 0° zeigt nach rechts.

### variable CPosition m_currentPosition

Aktuelle Position der Turtle.

### variable CTurtlePath m_path

## public-func

### function CPolylineTurtle

### function void ChangeDirectionBy

### function CTurtlePath & GetPath

### function void Initialize

### function void MoveForward

### function void MoveInAnLeftArc

### function void MoveInAnRightArc

### function void SetDirectionTo

### function void SetPosition

## private-func

### function void MoveInAnArc

# class CPolylineTurtle::CTurtleVector

## public-func

### function BOOL Rotate

## private-func

### function BOOL Rotate

# class CPovGenerator

## public-type

### typedef set< CColor * > Colors

## protected-attrib

### variable CRenderEnvironment & m_environment

### variable CTextureMapping * m_pCurTextureMapping

## public-func

### function CPovGenerator

### function ~CPovGenerator

### function bool Generate

## protected-func

### function bool CollectFaceColors

### function CColor * FaceColor

### function CColor * FirstFaceColor

### function bool GenerateObject

### function bool GeneratePrimitive

### function BOOL InitTextureMapping

### function CVector ObjectTextureRotation

### function CColor * PrimitiveColor

### function BOOL ReviseBrightness

### function BOOL ReviseSaturation

### function bool WriteColor

### function BOOL WriteMesh

# class CPrintProgressDlg

## public-type

### enum %type% @4

## public-attrib

### variable int m_Quality

### variable CString m_Status

### variable int m_Tile

### variable int m_TotalTiles

## public-func

### function CPrintProgressDlg

### function void SetQuality

### function void SetStatus

### function void SetTile

### function void SetTotalTiles

## protected-func

### function void DoDataExchange

### function void PostNcDestroy

# class CPrivilegeEnabler

## private-func

### function CPrivilegeEnabler

## public-func

### function ~CPrivilegeEnabler

## public-static-func

### function CPrivilegeEnabler & Instance

# struct CRefreshImmediatelyEnsurer

## public-attrib

### variable CObjectViewerCtrl & m_control

### variable bool m_oldRefreshImmediately

## public-func

### function CRefreshImmediatelyEnsurer

### function ~CRefreshImmediatelyEnsurer

# struct CRenderEnvironment

## private-attrib

### variable CLightSettings m_lightSettings

### variable CMapStringToString m_renderParameters

## public-func

### function CVector GetAmbient

### function double GetAmbientLuminance

### function CVector GetBackgroundLuminance

### function CVector GetBaseColor

### function CVector GetCameraLightLuminance

### function const CVector & GetCameraPosition

### function CVector GetDiffuse

### function double GetDiffuseLuminance

### function double GetFadePower

### function double GetFieldOfVision

### function double GetFilter

### function double GetGamma

### function bool GetGenerateCameraLight

### function CVector GetGlobalAmbientLuminance

### function double GetLightColorCorrectionFactor

### function CVector GetLightLuminance

### function CVector GetLightLuminance

### function CLightSettings & GetLightSettings

### function const CVector & GetLookAtPosition

### function double GetLuminance

### function IMaterialPool & GetMaterialPool

### function CString GetOutputPath

### function double GetReflection

### function double GetRefraction

### function CString GetRenderParametersPath

### function OBJID GetRoot

### function double GetRoughness

### function CVector GetSpecular

### function double GetSpecularLuminance

### function bool GetTerminationRequested

### function bool GetUseRadiosity

### function void ReadRenderParameters

### function double RenderParameterDouble

### function long RenderParameterLong

### function CString RenderParameterString

### function CVector RenderParameterVector

### function CVector RenderParameterVector

# struct CRenderOnlineText

## public-attrib

### variable double m_Blue

### variable CString m_Catalog

### variable bool m_CenterPosition

### variable CDoubleVector m_Direction

### variable CString m_FontName

### variable double m_Green

### variable OBJID m_idObj

### variable CDoubleVector m_Position

### variable CString m_Producer

### variable double m_Red

### variable CString m_Text

### variable double m_TextDist

### variable double m_TextHeight

### variable double m_TextThickness

### variable bool m_UseLight

## public-func

### function CRenderOnlineText

### function CRenderOnlineText

### function void operator=

# class CSafeGeometryProcessor

## private-attrib

### variable OBJID m_copyId

## public-func

### function CSafeGeometryProcessor

### function ~CSafeGeometryProcessor

## private-func

### function CVector ObjectCenter

### function CVector ObjectSize

# struct CSilhouetteEdge

## public-attrib

### variable bool Face1Flip

### variable bool Face1Set

### variable bool Face1Vis

### variable bool Face2Flip

### variable bool Face2Vis

## public-func

### function CSilhouetteEdge

# struct CStopWatch

## public-attrib

### variable CString m_caption

### variable DWORD m_startTickCount

## public-func

### function CStopWatch

### function ~CStopWatch

# struct CTempMeasure

## public-attrib

### variable double end

### variable OBJID idMeasure

### variable long nPosition

### variable long plane

### variable double start

## public-func

### function void Arange

# class CTempMeasureArray

## public-attrib

### variable _CTempMeasureArray m_Array

## public-func

### function CTempMeasureArray

### function ~CTempMeasureArray

### function void Add

### function void Arange

### function void DeleteContents

### function CTempMeasure * GetAt

### function int GetSize

### function void Sort

# class CTexture

## public-func

### function CTexture

### function ~CTexture

### function SECImage * DoLoadImage

### function SECImage * GetImage

### function void GetLimitedDimensions

### function bool IsEqual

### function unsigned int Load

### function unsigned int LoadLocal

### function unsigned int NeedToLoad

### function void ScaleImageToPow2

### function void UnLoad

## private-func

### function bool PrepareImage

# class CTextureDescription

## public-attrib

### variable CString m_LoadPath

### variable CTexture * m_pTexture

# class CTexturePool

## protected-attrib

### variable CString m_currentKeyAffix

### variable CObjectViewerCtrl * m_objectViewer

### variable CTypedPtrMap< CMapStringToPtr, CString, CTextureDescription * > m_Pool

## public-func

### function CTexturePool

### function ~CTexturePool

### function CTexture * AddDuplicate

### function CString GetCurrentKeyAffix

### function void LoadTextures

### function void RemoveAll

### function void RemoveTextureFile

### function void SetCurrentKeyAffix

### function void UnloadTextures

## private-func

### function CTexturePool

### function void OnLoadTextureWarning

### function CTexturePool & operator=

# struct CUnicodeChecker

## protected-attrib

### variable BOOL m_initialized

### variable LPGLYPHSET m_pGlyphSet

## public-func

### function CUnicodeChecker

### function ~CUnicodeChecker

### function BOOL HasGlyph

# struct CViewer2DLine

## public-attrib

### variable int m_nColor

### variable int x1

### variable int x2

### variable int y1

### variable int y2

# struct CViewer3DLine

## public-attrib

### variable int id

### variable int layer

### variable GLdouble m_blue

### variable GLdouble m_green

### variable GLushort m_pattern

### variable GLdouble m_red

### variable GLfloat m_width

### variable GLdouble x1

### variable GLdouble x2

### variable GLdouble y1

### variable GLdouble y2

### variable GLdouble z1

### variable GLdouble z2

# class CWindowIdManager

## protected-attrib

### variable WindowId m_Id

## public-func

### function CWindowIdManager

### function int AllocateId

### function bool RelaseId

# struct CZoomStackEntry

## public-attrib

### variable CVector2D m_ZoomCenter

### variable double m_ZoomFactor

## public-func

### function CZoomStackEntry

### function CZoomStackEntry

# struct FlexibleMessageBox

## public-static-func

### function void Show

# class FlexibleMessageBoxImplementation

## public-static-attrib

### variable Font FONT

### variable double MAX_HEIGHT_FACTOR

### variable double MAX_WIDTH_FACTOR

## public-static-func

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

### function DialogResult Show

# class FlexibleMessageBoxImplementation::FlexibleMessageBoxForm

## public-type

### enum %type% ButtonID

### enum %type% TwoLetterISOLanguageID

## public-static-attrib

### variable initonly array< String^> BUTTON_TEXTS_ENGLISH_EN

### variable initonly array< String^> BUTTON_TEXTS_GERMAN_DE

### variable initonly array< String^> BUTTON_TEXTS_ITALIAN_IT

### variable initonly array< String^> BUTTON_TEXTS_SPANISH_ES

### variable initonly String STANDARD_MESSAGEBOX_SEPARATOR_LINES

### variable initonly String STANDARD_MESSAGEBOX_SEPARATOR_SPACES

## public-attrib

### variable Button button1

### variable Button button2

### variable Button button3

### variable property String CaptionText

### variable IContainer components

### variable MessageBoxDefaultButton defaultButton

### variable BindingSource FlexibleMessageBoxFormBindingSource

### variable TwoLetterISOLanguageID languageID

### variable property String MessageText

### variable Panel panel1

### variable PictureBox pictureBoxForIcon

### variable RichTextBox richTextBoxMessage

### variable int visibleButtonsCount

## public-func

### function FlexibleMessageBoxForm

### function !FlexibleMessageBoxForm

### function ~FlexibleMessageBoxForm

### function void DisposeObject

### function void FlexibleMessageBoxForm_KeyUp

### function void FlexibleMessageBoxForm_Shown

### function String GetButtonText

### function void InitializeComponent

### function void richTextBoxMessage_LinkClicked

## public-static-func

### function double GetCorrectedWorkingAreaFactor

### function array< String^> GetStringRows

### function void SetDialogButtons

### function void SetDialogIcon

### function void SetDialogSizes

### function void SetDialogStartPosition

### function System::Windows::Forms::DialogResult Show

# class FtFont

## public-attrib

### variable CString path

### variable std::wstring unicodeValue

## private-attrib

### variable BOOL m_bCreated

### variable FTBufferFont * m_font

### variable CString m_FontName

### variable double m_FontSize

### variable GLFontType m_FontType

### variable CDoubleVector m_Offset

### variable CDoubleVector m_Rotate

### variable CDoubleVector m_Scale

### variable UINT m_uiListID

## public-func

### function FtFont

### function ~FtFont

### function void Allocate

### function void DeleteFont

### function FTBufferFont * GetFont

### function CString GetFontName

### function double GetFontSize

### function GLFontType GetFontType

### function CDoubleVector GetRotate

### function CDoubleVector GetScale

### function double GetTextGlyphLength

### function CDoubleVector GetYOffset

### function void RenderText

### function void SetFont

### function void SetFontName

### function void SetFontSize

### function void SetFontType

### function void SetOffset

### function void SetRotate

### function void SetScale

## private-func

### function void Delete

# class FtFontPool

## public-attrib

### variable BOOL m_fontsCreated

## protected-attrib

### variable CArray< FtFont, FtFont & > m_Fonts

### variable CDC * prevPDC

## public-func

### function IGLFont * Add

### function void CreateFonts

### function void CreateFonts

### function IGLFont * GetFont

### function void UnloadFonts

# class G3dKernelScriptingHost

## public-func

### function G3dKernelScriptingHost

### function ~G3dKernelScriptingHost

### function HRESULT GetClassID

### function void OnFinalRelease

## public-static-func

### function BOOL RunScript

# class G3dScriptingHost

## public-func

### function G3dScriptingHost

### function ~G3dScriptingHost

### function HRESULT GetClassID

### function void OnFinalRelease

## public-static-func

### function BOOL RunScript

# struct HRESULT_EXCEPTION

## public-func

### function HRESULT_EXCEPTION

### function HRESULT_EXCEPTION

### function HRESULT operator=

### function HRESULT operator=

## public-static-func

### function void CheckError

### function void CheckError

# class IDictionaryClass

## public-func

### function IDictionaryClass

### function IDictionaryClass

### function IDictionaryClass

### function void Add

### function BOOL Exists

### function long GetCompareMode

### function long GetCount

### function VARIANT GetItem

### function VARIANT Items

### function VARIANT Keys

### function void Remove

### function void RemoveAll

### function void SetCompareMode

### function void SetItem

### function void SetKey

### function void SetRefItem

# class IFontPool

## public-func

### function IGLFont * Add

### function void CreateFonts

### function void CreateFonts

### function IGLFont * GetFont

### function void UnloadFonts

# struct IG3DKernelVtbl

## public-attrib

### variable long double double double double double double long * AboveId

### variable long double double double double AboveX

### variable long double double double double double AboveY

### variable long double double double double double double AboveZ

### variable IDispatch double Amount

### variable long short double double double double Angle

### variable long double Angle

### variable IDispatch IDispatch IDispatch double double AngleEnd

### variable long double AngleInDegree4CollinearNormalVectors

### variable IDispatch IDispatch IDispatch double AngleStart

### variable long double * AngX

### variable long double AngX

### variable long double double * AngY

### variable long double double AngY

### variable long double double double * AngZ

### variable long double double double AngZ

### variable long int * AttribCount

### variable long long long * AttribHeadPosition

### variable long BSTR long long * AttribPosition

### variable long BSTR int * AttribType

### variable long BSTR AttributeName

### variable long BSTR BSTR AttributeValue

### variable long BSTR int AttributeValue

### variable long BSTR long AttributeValue

### variable long BSTR double AttributeValue

### variable long BSTR BSTR * AttributeValue

### variable long BSTR int * AttributeValue

### variable long BSTR double * AttributeValue

### variable long BSTR long * AttributeValue

### variable long long long BSTR * AttributLabel

### variable long short Axis

### variable BSTR BasePath

### variable long double double double double double double long long * BelowId

### variable long short short short Blue

### variable double double double Blue

### variable double double * Blue

### variable long long Box

### variable BSTR BSTR Catalog

### variable BSTR int * CatalogCount

### variable BSTR BSTR CatalogName

### variable long long BSTR BSTR CatalogName

### variable long long BSTR BSTR * CatalogName

### variable BSTR BSTR BSTR CatalogPath

### variable BSTR BSTR BSTR * CatalogPath

### variable long long BSTR CatchName

### variable long long ChildId

### variable REFIID LPOLESTR UINT cNames

### variable _In_ DISPID dispIdMember

### variable long double Distance

### variable long BSTR ElementName

### variable long Enable

### variable long double Epsilon

### variable long short short short short Exponent

### variable long FatherId

### variable BSTR BSTR BSTR FileLink

### variable BSTR FileName

### variable long BSTR FileName

### variable BSTR filterName

### variable BSTR BSTR long Flags

### variable BSTR BSTR FontName

### variable long BSTR FontName

### variable BSTR FontName

### variable BSTR fontName

### variable long long double From

### variable long BSTR BSTR double FromX

### variable long BSTR BSTR double double FromY

### variable long BSTR BSTR double double double FromZ

### variable long short short Green

### variable double double Green

### variable double double double * Green

### variable long long long * HeadPosition

### variable long long * HeadPosition

### variable BSTR long long * HeadPosition

### variable BSTR BSTR double Height

### variable long double Height

### variable IDispatch double height

### variable double double Height

### variable double double double Height

### variable long long idBox

### variable long long * idCopy

### variable long short long * idCopy

### variable long long BSTR short double double long * idJoint

### variable long idJoint

### variable double double double double double double long * idLineObjId

### variable double double double double double double BSTR long * idMeasureObjId

### variable long long double double BSTR BSTR long * idMeasureObjId

### variable double double double double double double BSTR BSTR long * idMeasureObjId

### variable double double double long * idNew

### variable double double int long * idNew

### variable double double double int long * idNew

### variable double int int long * idNew

### variable double double int int long * idNew

### variable IDispatch IDispatch IDispatch double double int long * idNew

### variable long idObj

### variable long idObj1

### variable long long idObj2

### variable long idOriginal

### variable long BSTR long idTarget

### variable long BOOL * IsObjectId

### variable UINT iTInfo

### variable long int Layer

### variable UINT LCID lcid

### variable REFIID LPOLESTR UINT LCID lcid

### variable _In_ DISPID _In_ REFIID _In_ LCID lcid

### variable BSTR LogPath

### variable long short MappingMode

### variable long BSTR BSTR Match

### variable BSTR BSTR BSTR Material

### variable BSTR BSTR BSTR long * MaterialId

### variable long MaterialId

### variable long BSTR MaterialName

### variable long BSTR BSTR MaterialName

### variable BSTR Materialpath

### variable long double long MaxSeconds

### variable double MeasureTextDist

### variable BSTR double MeasureTextHeight

### variable BSTR double measureTextHeight

### variable long short Mirror

### variable long BSTR BSTR Modifications

### variable BSTR Msg

### variable BSTR Name

### variable long BSTR Name

### variable BSTR BSTR Name

### variable IDispatch IDispatch IDispatch IDispatch long * NewObject

### variable IDispatch double long * NewObject

### variable long BOOL BOOL BOOL BSTR long * NewObject

### variable BSTR long * NewObjectId

### variable long long BSTR long long * NewPos

### variable long long BSTR BSTR BSTR long long * NewPosition

### variable long long BSTR long long * NewPositon

### variable long long BSTR BSTR long long * NewPositon

### variable long long long long long * NextObjectId

### variable long long long BSTR long long * NextPosition

### variable IDispatch IDispatch IDispatch double double int NrSegments

### variable long Obj

### variable long BSTR ObjCatch

### variable BSTR BSTR ObjectName

### variable long BSTR BSTR ObjectName

### variable long ObjId

### variable long ObjId1

### variable long long ObjId2

### variable long long OBjId2

### variable long long BSTR * ObjName

### variable BSTR * pBasePath

### variable long short short short * pBlue

### variable long long * pChildCount

### variable UINT * pctinfo

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS * pDispParams

### variable long BSTR * pElementName

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO * pExcepInfo

### variable long short short short short * pExponent

### variable long long * pFather

### variable long BSTR * pFontName

### variable long short short * pGreen

### variable long double * pHeight

### variable long long long * pIdNew

### variable IDispatch ** pInterface

### variable long int * pLayer

### variable long short * pMappingMode

### variable long long BSTR BSTR BSTR * pMaterialName

### variable BSTR * pMaterialpath

### variable long ** pMaterialPool

### variable long short * pMirror

### variable BSTR BSTR long * pObjectId

### variable BSTR BSTR long long * pObjectId

### variable BOOL BOOL * pOldState

### variable double double * pOldValue

### variable long long * Pos

### variable double PosFromX

### variable double double PosFromY

### variable double double double PosFromZ

### variable long long long * Position

### variable BSTR BSTR long long * Position

### variable long long * Position

### variable long long Position

### variable double PositionFromX

### variable double double PositionFromY

### variable double double double PositionFromZ

### variable double double double double PositionToX

### variable double double double double double PositionToY

### variable double double double double double double PositionToZ

### variable long double PositionX

### variable long double double PositionY

### variable long double double double PositionZ

### variable double double double double PosToX

### variable double double double double double PosToY

### variable double double double double double double PosToZ

### variable long double * PosX

### variable long BSTR BSTR double PosX

### variable long BSTR double PosX

### variable long double PosX

### variable long double double * PosY

### variable long BSTR BSTR double double PosY

### variable long BSTR double double PosY

### variable long double double PosY

### variable long double double double * PosZ

### variable long BSTR BSTR double double double PosZ

### variable long BSTR double double double PosZ

### variable long double double double PosZ

### variable long IDispatch ** ppObjects

### variable long BSTR double * pPosX

### variable long BSTR double double * pPosY

### variable long BSTR double double double * pPosZ

### variable long IDispatch ** ppPath

### variable long IDispatch ** ppPrimitives

### variable long short short * pProjection

### variable UINT LCID ITypeInfo ** ppTInfo

### variable BEGIN_INTERFACE REFIID _COM_Outptr_ void ** ppvObject

### variable long short * pRed

### variable long short short double * pRefractionIndex

### variable long * pResult

### variable long Primitive

### variable BSTR Producer

### variable int * ProducerCount

### variable BSTR ProducerName

### variable long long BSTR ProducerName

### variable long long BSTR * ProducerName

### variable long short short Projection

### variable long * pRootItem

### variable long short short double double short * pScaleToFit

### variable long short short double * pSizeU

### variable long short short double double * pSizeV

### variable long VARIANT_BOOL * pSuccess

### variable long BSTR VARIANT_BOOL * pSuccess

### variable long BSTR BSTR VARIANT_BOOL * pSuccess

### variable long double VARIANT_BOOL * pSuccess

### variable long double double double VARIANT_BOOL * pSuccess

### variable long short double double double double VARIANT_BOOL * pSuccess

### variable long double double double double double double long long VARIANT_BOOL * pSuccess

### variable long long VARIANT_BOOL * pSuccess

### variable IDispatch VARIANT_BOOL * pSuccess

### variable BSTR VARIANT_BOOL * pSuccess

### variable BSTR BSTR VARIANT_BOOL * pSuccess

### variable BSTR BSTR BSTR VARIANT_BOOL * pSuccess

### variable long BSTR int VARIANT_BOOL * pSuccess

### variable long BSTR long VARIANT_BOOL * pSuccess

### variable long BSTR double VARIANT_BOOL * pSuccess

### variable long BOOL VARIANT_BOOL * pSuccess

### variable long BSTR BSTR double double double VARIANT_BOOL * pSuccess

### variable long BSTR BSTR double double double double double double VARIANT_BOOL * pSuccess

### variable long BSTR BSTR double double double double double double double double double VARIANT_BOOL * pSuccess

### variable long int VARIANT_BOOL * pSuccess

### variable long BSTR BSTR double double double double double double double double double double double double VARIANT_BOOL * pSuccess

### variable long short short short VARIANT_BOOL * pSuccess

### variable long short short short short VARIANT_BOOL * pSuccess

### variable long short short double VARIANT_BOOL * pSuccess

### variable long short short double double short BSTR short VARIANT_BOOL * pSuccess

### variable long double long VARIANT_BOOL * pSuccess

### variable long BSTR long BSTR VARIANT_BOOL * pSuccess

### variable long BSTR double double double VARIANT_BOOL * pSuccess

### variable long double double double double double double double double double VARIANT_BOOL * pSuccess

### variable long double double VARIANT_BOOL * pSuccess

### variable VARIANT_BOOL * pSuccess

### variable double double double VARIANT_BOOL * pSuccess

### variable long BSTR * pText

### variable BSTR BSTR double double long * pTextObjId

### variable long short short double double short BSTR * pTextureFile

### variable long double * pThickness

### variable long short short * pTransparency

### variable long * pTurtle

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT _Out_opt_ EXCEPINFO _Out_opt_ UINT * puArgErr

### variable long short short double double short BSTR short * pUsePixelMask

### variable long * pVal

### variable long ** pVal

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD _In_ DISPPARAMS _Out_opt_ VARIANT * pVarResult

### variable IDispatch ** pViewer

### variable double Radius

### variable long double double Radius

### variable double RadiusBottom

### variable double RadiusLarge

### variable double double RadiusSmall

### variable double double RadiusTop

### variable long long BSTR short double RangeFrom

### variable long long BSTR short double double RangeTo

### variable BSTR RecordPath

### variable long short Red

### variable double Red

### variable double * Red

### variable long short short double RefractionIndex

### variable BSTR VARIANT * Result

### variable REFIID LPOLESTR UINT LCID DISPID * rgDispId

### variable REFIID LPOLESTR * rgszNames

### variable BEGIN_INTERFACE REFIID riid

### variable REFIID riid

### variable _In_ DISPID _In_ REFIID riid

### variable long Root

### variable long short double RotCenterX

### variable long short double double RotCenterY

### variable long short double double double RotCenterZ

### variable int int RoundTo

### variable BSTR double double int int roundTo

### variable long short short double double short ScaleToFit

### variable double double int Segments

### variable double double double int Segments

### variable double int Segments1

### variable double int int Segments2

### variable double double int SegmentsLarge

### variable double double int int SegmentsSmall

### variable long BSTR SelMaterialName

### variable long BOOL BOOL ShowDepth

### variable long BOOL BOOL BOOL ShowHeight

### variable long BOOL ShowWidth

### variable long long Side

### variable long short short double SizeU

### variable long short short double double SizeV

### variable long double * SizeX

### variable double SizeX

### variable long double double * SizeY

### variable double double SizeY

### variable long double double double * SizeZ

### variable double double double SizeZ

### variable long double SmoothAngle

### variable BSTR SnapshotsDirectory

### variable BOOL State

### variable BSTR BOOL State

### variable long BSTR long BSTR TargetCatch

### variable BSTR Text

### variable long BSTR Text

### variable double double double double double double BSTR Text

### variable long long double double BSTR Text

### variable BSTR double double textDist

### variable long short short double double short BSTR TextureFile

### variable BSTR BSTR double double Thickness

### variable long double Thickness

### variable long long double double To

### variable long BSTR BSTR double double double double ToX

### variable long BSTR BSTR double double double double double ToY

### variable long BSTR BSTR double double double double double double ToZ

### variable long short short Transparency

### variable long Turtle

### variable long long BSTR short Type

### variable int Unit

### variable BSTR double double int unit

### variable long short short double double short BSTR short UsePixelMask

### variable IDispatch IDispatch * V2D_AxisStart

### variable IDispatch IDispatch IDispatch * V2D_pAxisEnd

### variable IDispatch IDispatch * V2D_StartPointOutline

### variable IDispatch * V2DC_ObjectOutline

### variable IDispatch * V2DC_Outline

### variable IDispatch IDispatch IDispatch * V3D_XAxisRef

### variable IDispatch IDispatch IDispatch IDispatch * V3DC_Path

### variable IDispatch * V3DC_Polygon

### variable long double Value

### variable double Value

### variable BSTR * VersionString

### variable long View

### variable long BOOL BOOL BOOL BSTR ViewId

### variable long long double double BSTR BSTR ViewId

### variable double double double double double double BSTR BSTR ViewId

### variable long BOOL Visibility

### variable long BOOL * Visibility

### variable _In_ DISPID _In_ REFIID _In_ LCID _In_ WORD wFlags

### variable long double x

### variable long double X

### variable long BSTR BSTR double double double double XAxisX

### variable long BSTR BSTR double double double double double double double XAxisX

### variable long double double double double * XAxisX

### variable long double double double double XAxisX

### variable long BSTR BSTR double double double double double XAxisY

### variable long BSTR BSTR double double double double double double double double XAxisY

### variable long double double double double double * XAxisY

### variable long double double double double double XAxisY

### variable long BSTR BSTR double double double double double double XAxisZ

### variable long BSTR BSTR double double double double double double double double double XAxisZ

### variable long double double double double double double * XAxisZ

### variable long double double double double double double XAxisZ

### variable long double double y

### variable long double double Y

### variable long BSTR BSTR double double double double double double double YAxisX

### variable long BSTR BSTR double double double double double double double double double double YAxisX

### variable long double double double double double double double * YAxisX

### variable long double double double double double double double YAxisX

### variable long BSTR BSTR double double double double double double double double YAxisY

### variable long BSTR BSTR double double double double double double double double double double double YAxisY

### variable long double double double double double double double double * YAxisY

### variable long double double double double double double double double YAxisY

### variable long BSTR BSTR double double double double double double double double double YAxisZ

### variable long BSTR BSTR double double double double double double double double double double double double YAxisZ

### variable long double double double double double double double double double * YAxisZ

### variable long double double double double double double double double double YAxisZ

### variable long double double double z

### variable long double double double Z

### variable long BSTR BSTR double double double double ZAxisX

### variable long BSTR BSTR double double double double double double double ZAxisX

### variable long BSTR BSTR double double double double double ZAxisY

### variable long BSTR BSTR double double double double double double double double ZAxisY

### variable long BSTR BSTR double double double double double double ZAxisZ

### variable long BSTR BSTR double double double double double double double double double ZAxisZ

## public-func

### function BEGIN_INTERFACE HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function HRESULT

### function ULONG

### function ULONG

# class IGLFont

## public-func

### function double GetFontSize

### function GLFontType GetFontType

### function CDoubleVector GetRotate

### function CDoubleVector GetScale

### function double GetTextGlyphLength

### function CDoubleVector GetYOffset

### function void RenderText

### function void SetFontSize

### function void SetFontType

### function void SetOffset

### function void SetRotate

### function void SetScale

# struct ImageDefinition

## public-attrib

### variable int layer

### variable double m_angle

### variable double m_height

### variable CString m_path

### variable CxImage * m_pImage

### variable double m_width

### variable double m_x

### variable double m_y

## public-func

### function ImageDefinition

# class ImageDefinitions

## public-func

### function void Cleanup

### function BOOL Read

### function BOOL Write

# class IObjectViewerCtl

## private-func

### function void DoPostHint

### function void DoPostLoad

### function void DoPreSave

### function void DoRefreshWindow

### function void DoRemoveFromTextureCache

### function void DoResetView

## public-static-func

### function void PostHint

### function void PostLoad

### function void PreSave

### function void RefreshWindow

### function void Register

### function void RemoveFromTextureCache

### function void ResetView

# class KernelLib::G3DKernel

%sectiondef%

# interface KernelLib::IG3DKernel

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

#### return

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

#### return

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

#### return

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

#### return

boolean Wenn die "Turtle" bewegt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT Beautify

Sorgt dafür, dass bestimmte Kanten in der Grafik nicht dargestellt werden.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Angle | Winkel |

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

long Wenn der Aufruf erfolgreich war, wird die ID des erzeugten Objekts zurückgegeben, sonst 0.

### function HRESULT CreateProducer

### function HRESULT CreateStringAttribute

Legt ein Attribut vom Type "BSTR" an.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### return

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

#### return

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

#### return

Type Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT DeleteAttribute

### function HRESULT DeletePickPoint

### function HRESULT DeleteTextureCoordinates

Löscht die Texturkoordinaten in den Geometrien des angegebenen Objekts.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_idObj | Objekt-ID |

#### return

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT Difference

Bildet die Differenz zweier Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId1 | ID des ersten Objekts |
| long_ObjId2 | ID des zweiten Objekts |

#### return

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

#### return

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

#### return

long Falls das Material gefunden werden konnte, wird dessen Id zurückgegeben, andernfalls 0.

### function HRESULT ForceIntoBox

Limitiert ein Grafikobjekt auf den Bereich einer angegebenen Box.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Obj | Grafikobjekt. |
| long_Box | Box. |

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

boolean Wenn das Attribut existiert, wird "true" zurückgegeben, andernfalls "false".

### function HRESULT GetProducerCount

### function HRESULT GetProducerHeadPosition

### function HRESULT GetRootItem

Ermittelt das Root-Objekt der Grafik.

#### return

long Root-Objekt.

### function HRESULT GetSpecularColor

### function HRESULT GetStringAttributeValue

Ermittelt den Wert einen Attributs vom Typ "BSTR".

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |
| BSTR_AttributeName | Attributname |

#### return

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

#### return

BOOL ID des Objektes mit der Geometrie, die sich aus ObjId1 * ObjId2 ergibt.

### function HRESULT IsDeveloperModeEnabled

Ermittelt, ob der Entwicklermodus ein oder ausgeschaltet ist.

#### return

long Wird ein Wert ungleich 0 zurückgegeben, dann ist der Entwicklermodus eingeschaltet. Wird 0 zurückgegeben, dann ist der Entwicklermodus ausgeschaltet.

### function HRESULT IsModified

Ermittelt, ob es seit dem letzten Aufruf von "IsModified" Änderungen im Grafikkernel gegeben hat.

#### return

boolean Wenn es Änderungen im Grafikkernel gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function HRESULT IsObjectId

Ermittelt, ob eine Objekt-ID gültig ist.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt-ID |

#### return

BOOL Wenn die Objekt-ID gültig ist, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT KillObject

Entfernt ein Objekt aus der Grafik.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | ID des Objektes, das entfernt werden soll. |

#### return

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

#### return

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

#### return

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

#### return

boolean Wenn die "Turtle" bewegt werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT NewTurtle

Gibt eine neue "Turtle" zurück.

#### par

Turtle

#### return

long Die neue "Turtle".

### function HRESULT Objects

Liefert ein Dictionary aller Objekte im Baum, der vom angegebenen Objekt ausgeht.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_Root | Objekt. |

#### return

Dictionary Dictionary aus Objekten.

### function HRESULT Primitives

Liefert ein Dictionary aller Primitiva im Baum, der vom angegebenen Objekt ausgeht.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Objekt. |

#### return

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

#### return

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

#### return

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

#### return

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT ScaleTo

Ändert die Größe eines Objekts um die angegebenen Werte.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_x | Wert in X-Richtung. |
| double_y | Wert in Y-Richtung. |
| double_x | Wert in Z-Richtung. |

#### return

BOOL Wenn der Aufruf erfolgreich war, wird TRUE zurückgegeben, sonst FALSE.

### function HRESULT SeparatePrimitives

Verschiebt alle Primitiva, die im angegebenen Objekt enthalten sind, in separate Subobjekte. Nach der Operation enthält das ursprüngliche Objekt keine Primitive mehr. Es wird je Primitiv ein eigenes Subobjekt angelegt. Die Operation wird nur durchgeführt, wenn das Objekt mehr als ein Primitiv enthält.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId" | Das Objekt, dessen Primitiva verschoben werden sollen. |

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

boolean Wenn die Ausrichtung geändert werden konnte, wird TRUE zurückgegeben; wenn ein Fehler aufgetreten ist, wird FALSE zurückgegeben.

### function HRESULT Union

Bildet die Vereinigungsmenge zweier Geometrien.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId1 | ID des ersten Objekts |
| long_ObjId2 | ID des zweiten Objekts |

#### return

BOOL ID des Objektes mit der Geometrie, die sich aus ObjId1 + ObjId2 ergibt.

### function HRESULT UnRegisterViewer

### function HRESULT UnSmoothElement

# struct less_than_layer

## public-func

### function bool operator()

# class logfilParser

## protected-static-attrib

### variable unsigned short int SymSet

## public-func

### function logfilParser

### function void LexName

### function void LexString

### function void LookAheadName

### function void LookAheadString

### function void Parse

### function int Successful

## protected-func

### function void ExpectWeak

### function void Get

### function int WeakSeparator

## private-func

### function void AddMeasureElementLine

### function void AddObjectMeasureElementLine

### function void AddTextElementLine

### function void CopyLine

### function void CreateCatalogLine

### function void CreateDoubleAttributeLine

### function void CreateIntAttributeLine

### function void CreateLongAttributeLine

### function void CreateNewObjectLine

### function void CreateProducerLine

### function void CreateRootLine

### function void CreateStringAttributeLine

### function void CutLine

### function void DeGroupLine

### function void DeleteAttributeLine

### function void DifferenceLine

### function void Double

### function void EnGroupLine

### function void ExtrudeLine

### function void ExtrudePathLine

### function void FindAttributeLine

### function void get_m_DefaultRootLine

### function void get_m_hInstanceLine

### function void GetAttributeCountLine

### function void GetAttributeHeadPositionLine

### function void GetAttributeTypeLine

### function void GetCatalogCountLine

### function void GetCatalogHeadPositionLine

### function void GetCatalogPathLine

### function void GetDefaultMaterialPathLine

### function void GetDoubleAttributeValueLine

### function void GetElementChildCountLine

### function void GetElementHeadPositionLine

### function void GetElementNameLine

### function void GetElementPositionLine

### function void GetElementSizeLine

### function void GetFatherLine

### function void GetIntAttributeValueLine

### function void GetLongAttributeValueLine

### function void GetMaterialHeadPositionLine

### function void GetMaterialPoolLine

### function void GetNextAttributeLine

### function void GetNextCatalogLine

### function void GetNextElementLine

### function void GetNextMaterialLine

### function void GetNextProducerLine

### function void GetProducerCountLine

### function void GetProducerHeadPositionLine

### function void GetRootItemLine

### function void GetStringAttributeValueLine

### function void GetTextElementFontLine

### function void GetTextElementHeightLine

### function void GetTextElementTextLine

### function void GetTextElementThicknessLine

### function void Int

### function void Int

### function void IntersectionLine

### function void IsObjectIdLine

### function void KillObjectLine

### function void LoadObjectLine

### function void LogFile

### function void LogLine

### function void MirrorLine

### function void Number

### function void RotateByLine

### function void RotateToLine

### function void SaveElementToFileLine

### function void ScaleByLine

### function void ScaleToLine

### function void SetCatalogPathLine

### function void SetDefaultMaterialPathLine

### function void SetDoubleAttributeValueLine

### function void SetElementMaterialLine

### function void SetElementNameLine

### function void SetElementSelMaterialLine

### function void SetElementVisibilityLine

### function void SetIntAttributeValueLine

### function void SetLongAttributeValueLine

### function void SetMeasureDefaultFontLine

### function void SetMeasureDefaultObjectDistLine

### function void SetMeasureDefaultTextDistLine

### function void SetMeasureDefaultUnitLine

### function void SetRedrawLine

### function void SetStringAttributeValueLine

### function void SetTextElementFontLine

### function void SetTextElementHeightLine

### function void SetTextElementTextLine

### function void SetTextElementThicknessLine

### function void Short

### function void SmoothElementLine

### function void String

### function void TranslateByLine

### function void TranslateToLine

### function void UnionLine

### function void UnSmoothElementLine

# class logfilScanner

## protected-static-attrib

### variable int STATE0

## public-func

### function logfilScanner

### function logfilScanner

## protected-func

### function int CheckLiteral

### function int Comment

### function int Get

# struct MenuEntry

## protected-attrib

### variable BOOL m_checked

### variable BOOL m_Enabled

### variable DWORD m_ItemData

### variable CString m_MenuStr

### variable CDynamicPopUpMenu * m_pSubMenu

### variable CString m_Text

## public-func

### function MenuEntry

### function ~MenuEntry

### function void Check

### function CDynamicPopUpMenu * CreateSubMenu

### function void Enable

### function DWORD GetItemData

### function CString GetString

### function CDynamicPopUpMenu * GetSubMenu

### function CString GetText

### function BOOL IsChecked

### function BOOL IsEnabled

### function void SetItemData

### function void SetString

### function void SetSubMenu

### function void SetText

# struct MenuItem

## protected-attrib

### variable int m_MessageId

### variable CDynamicPopUpMenu * m_pContainedIn

### variable UINT m_Position

### variable int m_WindowId

## public-func

### function MenuItem

### function ~MenuItem

### function CDynamicPopUpMenu * ContainedIn

### function void Enable

### function DWORD GetItemData

### function int GetMessageId

### function int GetPosition

### function CDynamicPopUpMenu * GetSubMenu

### function CString GetText

### function int GetWindowId

### function BOOL IsEnabled

### function void SetItemData

### function void SetMessageId

### function void SetPosition

### function void SetSubMenu

### function void SetText

### function void SetWindowId

# interface OBJECTVIEWERLib::_DObjectViewer

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

#### return

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
* Die Breite der Linie entspricht derDefinition der Linienbreite in OpenGLhttps://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glLineWidth.xhtml.
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

#### return

BOOL Wenn die Anzeige der Kugel zur Drehung der Grafik eingeschaltet ist, wird TRUE zurückgegeben, sonst FALSE.

### function BOOL Beautify

Versucht, die Darstellung eines Grafikobjektes zur verbessern,.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Grafikobjekt, dessen Darstellung verbessert werden soll. |

#### return

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

#### return

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

#### return

BOOL Wenn die Funktion erfolgreich durchgeführt werden konnte, wird TRUE zurückgegeben, andernfalls FALSE.

### function BOOL DeleteLight

### function BOOL DeleteMenuItem

### function BOOL DeleteMenuSeperator

### function BOOL DeleteSelectedText

Löscht das zur Zeit markierte Textelement.

#### par

FreeText

#### return

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

#### return

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

Schaltet das sofortige Neuzeichnen der Grafik nach bestimmten Befehlen ein oder aus.

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

#### return

short Antialiasing-Qualität.

#### attention

Die Antialiasing-Qualität wird ignoriert, wenn Hardware-Antialiasing aktiviert ist.

### function int GetBitmapAntialiasingFactor

Ermittelt den Antialiasing-Faktor für den Bitmap-Export.

#### return

int Antialiasing-Faktor.

### function short GetCatchDisplayMode

### function short GetCatchDistance

### function BOOL GetCatchSubElements

### function void GetDragElementPosition

### function double GetEdgeEnhancementOffset

Aufruf wird an den Kernel weitergereicht. Beschreibung siehe dort.

#### return

double Beschreibung des Rückgabewertes siehe Kernel.

### function BSTR GetExtensions

Liefert die Liste der OpenGL-Extensions, so wie sie vom Grafikkartentreiber gemeldet wird.

#### return

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

#### return

double Bitmaphöhe in mm. Im Fehlerfall wird -1 zurückgegeben

### function double GetRealBitmapWidth

Ermittelt die Breite einer Bitmap in mm. Dazu müssen in der Bitmap die DPI (z.B. durch Editieren mit IrfanView) definiert sein.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| string_Path | Der Pfad zur Bitmap. |

#### return

double Bitmapbreite in mm. Im Fehlerfall wird -1 zurückgegeben

### function short GetRenderMode

Gibt den aktuell eingestellten Rendermodus zurück.

#### return

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

#### return

BOOL Wenn in der Szenerie eine Grafik existiert, wird TRUE zurückgegeben, sonst FALSE.

### function long IdentifyElement

Identifiziert das Element an der Cursor-Position.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| short_MousePosX | X-Koordinate der Cursor-Position. |
| short_MousePosY | Y-Koordinate der Cursor-Position. |

#### return

Typ Gültige Object-ID, wenn ein Element identifiziert werden konnte, sonst 0.

### function long IdentifyPickPoint

### function BOOL IsAutoAdjustViewEnabled

### function BOOL IsAutoLightingEnabled

Ermittelt, ob die automatische Beleuchtung eingeschaltet ist.

#### return

boolean Automatische Beleuchtung eingeschaltet?

### function HRESULT IsDeveloperModeEnabled

Ermittelt, ob der Entwicklermodus ein oder ausgeschaltet ist.

#### return

long Wird ein Wert ungleich 0 zurückgegeben, dann ist der Entwicklermodus eingeschaltet. Wird 0 zurückgegeben, dann ist der Entwicklermodus ausgeschaltet.

### function BOOL IsElementMoveEnabled

### function BOOL IsElementSelected

### function VARIANT IsHardwareAntialiasingEnabled

Ermittelt, ob das Hardware-Antialiasing eingeschaltet ist.

#### return

long Wenn das Hardware-Antialiasing eingeschaltet ist, wird der Wert 1 zurückgegeben, sonst der Wert 0.

### function BOOL IsLayerVisible

### function BOOL IsModified

Ermittelt, ob es seit dem letzten Aufruf von "IsModified" Änderungen im Grafikkernel gegeben hat.

#### return

boolean Wenn es Änderungen im Grafikkernel gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function BOOL IsObjectDamaged

Ermittelt, ob eine Grafikobjekt "beschädigt" ist.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| long_ObjId | Grafikobjekt, das auf Beschädigungen überprüft werden soll. |

#### return

boolean Wenn das Grafikobjekt beschädigt ist, wird der Wert 1 zurückgegeben, sonst der Wert 0.

#### remark

Ab und zu können Grafikobjekte durch Bearbeitungen (z.B. Schneidevorgänge) in ihrer internen Datenstruktur beschädigt werden. Das ist im allgemeinen Fall kaum mit absoluter Sicherheit zu vermeiden. Diese Funktion versucht, solche Beschädigungen zu erkennen. Wenn ein Objekt beschädigt ist, könnten folgende Maßnahmen helfen:

* Die Funktion "Beautify" aufrufen. Diese Funktion versucht unter anderem, Probleme innerhalb der internen Datenstruktur zu beheben.
* Wenn das nicht hilft, könnte die Bearbeitungsfunktion, die zur Beschädigung geführt hat, mit leicht variierten Parametern (z.B. mit einer leicht verschobenen Schnittebene) wiederholt werden.

### function BOOL IsRefreshImmediatelyEnabled

Ermittelt, ob das sofortige Neuzeichnen der Grafik ein- oder ausgeschaltet ist.

#### return

BOOL Wenn 0 zurückgegeben wird, ist das sofortige Neuzeichen der Grafik ausgeschaltet, sonst eingeschaltet.

### function BOOL IsRenderingToControlEnabled

### function BOOL IsRotationEnabled

@ brief Ermittelt, ob die Rotation eingeschaltet ist.

#### return

BOOL Wenn die Rotation eingeschaltet ist, wird TRUE zurückgegeben, sonst FALSE.

### function BOOL IsSetFocusOnMouseOverEnabled

Ermittelt, ob das Control den Fokus erhält, wenn sich der Mauszeiger darüber befindet.

#### return

boolean Wenn das Control automatisch den Fokus erhält, wird der Wert 1 zurückgegeben, sonst der Wert 0.

### function BOOL IsShadowBoxEnabled

### function BOOL IsShadowEnabled

### function BOOL IsTextSelected

Ermittelt, ob zur Zeit ein Textelement markiert ist.

#### par

FreeText

#### return

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

#### return

boolean Wenn es Änderungen gegeben hat, wird "TRUE" zurückgegeben, andernfalls "FALSE".

### function void OnHint

### function short PickEnabled

Ermittelt, ob Pickpunkte definiert sind.

#### return

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

#### return

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

#### return

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

#### return

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

#### return

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

#### return

short Im Fehlerfall wird der Wert -1 zurückgegeben, sonst die tatsächlich gesetzte Antialiasing-Qualität. Im letzteren Fall ist der Rückgabewert gleich dem Wert des Parameters "Quality".

#### attention

Wenn Hardware-Antialiasing aktiviert ist, bleibt diese Einstellung, je nach Grafikkarte und Treiber, eventuell ohne Auswirkung. In diesem Fall wird immer mit Antialiasing gerendert, wobei die höchste Qualitätsstufe verwendet wird, den die Grafikkarte unterstützt.

### function double SetAutoStretchFactor

Setzt den Wert, der bei Grafikoperationen (z.B. Union) verwendet wird, um die betroffenen Objekte temporär zu vergrößern.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| double_Value | Wert in mm, um den die Objekte vergrößert werden sollen. |

#### return

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

#### return

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

#### return

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

# interface OBJECTVIEWERLib::_DObjectViewerEvents

## public-func

### function void OnElementMoved

### function void OnElementMoving

### function void OnElementSelect

### function void OnImageError

### function void OnInfoClick

### function void OnLButtonDown

### function void OnLButtonUp

### function void OnMenuItemClick

### function void OnMouseModeChanged

### function void OnMouseMove

### function void OnPickSelect

### function void OnRButtonDown

### function void OnRButtonUp

# class OBJECTVIEWERLib::ObjectViewer

%sectiondef%

# struct Seperator

## public-func

### function Seperator

### function void Enable

### function DWORD GetItemData

### function CDynamicPopUpMenu * GetSubMenu

### function CString GetText

### function BOOL IsEnabled

### function void SetItemData

### function void SetSubMenu

### function void SetText

# struct StandardValues

## public-attrib

### variable BOOL m_areOriginAxisEnabled

### variable BOOL m_areRotationAxisEnabled

### variable int m_defaultTextHeightType

### variable CString m_measureFont

### variable int m_measureRoundTo

### variable double m_measureTextDist

### variable double m_measureTextHeight

### variable int m_measureUnit

### variable int m_mouseMode

### variable int m_printQuality

### variable int m_zoomMode

# struct TriangleData

## public-attrib

### variable CVector m_Normal

### variable double m_TextureS

### variable double m_TextureT

### variable BOOL m_UseNormal

### variable BOOL m_UseTexture

# struct UpdateMsg

## public-attrib

### variable int HintCode

### variable LPARAM lparam

### variable WPARAM wparam

# struct WindowId

## public-attrib

### variable bool m_Free

### variable int m_WindowId

# namespace ClipperLib

## enum

### enum %type% ClipType

### enum %type% Direction

### enum %type% EdgeSide

### enum %type% EndType

### enum %type% InitOptions

### enum %type% JoinType

### enum %type% NodeType

### enum %type% PolyFillType

### enum %type% PolyType

## typedef

### typedef signed long long cInt

### typedef unsigned long long cUInt

### typedef std::vector< TEdge * > EdgeList

### typedef std::vector< Join * > JoinList

### typedef signed long long long64

### typedef std::vector< IntPoint > Path

### typedef std::vector< Path > Paths

### typedef Path Polygon

### typedef Paths Polygons

### typedef std::vector< PolyNode * > PolyNodes

### typedef std::vector< OutRec * > PolyOutList

### typedef unsigned long long ulong64

## var

### variable cInt const hiRange

### variable cInt const loRange

### variable double const pi

### variable int const Skip

### variable int const Unassigned

## func

### function cInt Abs

### function void AddPolyNodeToPolygons

### function bool AllHorizontal

### function double Area

### function double Area

### function void CleanPolygon

### function void CleanPolygon

### function void CleanPolygons

### function void CleanPolygons

### function void ClosedPathsFromPolyTree

### function DoublePoint ClosestPointOnLine

### function void DisposeOutPts

### function double DistanceSqrd

### function OutPt * DupOutPt

### function bool E2InsertsBeforeE1

### function bool EdgesAdjacent

### function bool FindSegment

### function bool FirstIsBottomPt

### function OutPt * GetBottomPt

### function double GetDx

### function void GetHorzDirection

### function TEdge * GetLastHorz

### function OutRec * GetLowermostRec

### function TEdge * GetMaximaPair

### function TEdge * GetNextInAEL

### function bool GetOverlap

### function bool GetOverlapSegment

### function DoublePoint GetUnitNormal

### function bool HorzSegmentsOverlap

### function void InitEdge

### function void InitEdge2

### function OutPt * InsertPolyPtBetween

### function Int128 Int128Mul

### function bool IntersectPoint

### function bool IsHorizontal

### function bool IsIntermediate

### function bool IsMaxima

### function bool IsMinima

### function bool JoinHorz

### function bool JustBeforeLocMin

### function void Minkowki

### function void MinkowkiDiff

### function void MinkowkiSum

### function bool MoreAbove

### function bool MoreBelow

### function void OffsetPaths

### function void OffsetPolygons

### function void OpenPathsFromPolyTree

### function Path & operator<<

### function Paths & operator<<

### function std::ostream & operator<<

### function std::ostream & operator<<

### function std::ostream & operator<<

### function bool Orientation

### function bool Param1RightOfParam2

### function int PointCount

### function bool PointInPolygon

### function bool PointIsVertex

### function bool PointOnLineSegment

### function bool PointOnPolygon

### function bool PointsAreClose

### function bool Poly2ContainsPoly1

### function void PolyTreeToPaths

### function void PolyTreeToPolygons

### function bool Pt2IsBetweenPt1AndPt3

### function void RangeTest

### function TEdge * RemoveEdge

### function void ReverseHorizontal

### function void ReversePath

### function void ReversePaths

### function void ReversePolygon

### function void ReversePolygons

### function void ReversePolyPtLinks

### function cInt Round

### function void SetDx

### function bool SharedVertWithNextIsBot

### function bool SharedVertWithPrevAtTop

### function void SimplifyPolygon

### function void SimplifyPolygons

### function void SimplifyPolygons

### function bool SlopesEqual

### function bool SlopesEqual

### function bool SlopesEqual

### function bool SlopesNearCollinear

### function void StripDupsAndGetBotPt

### function void SwapIntersectNodes

### function void SwapPoints

### function void SwapPolyIndexes

### function void SwapSides

### function cInt TopX

### function void UpdateOutPtIdxs

# namespace KernelLib

## func

### function importlib

### function importlib

# namespace Microsoft::VisualBasic

%sectiondef%

# namespace OBJECTVIEWERLib

## func

### function importlib

### function importlib

# namespace std

%sectiondef%

# namespace System

%sectiondef%

# namespace System::ComponentModel

%sectiondef%

# namespace System::Diagnostics

%sectiondef%

# namespace System::Diagnostics::CodeAnalysis

%sectiondef%

# namespace System::Drawing

%sectiondef%

# namespace System::Globalization

%sectiondef%

# namespace System::IO

%sectiondef%

# namespace System::Linq

%sectiondef%

# namespace System::Reflection

%sectiondef%

# namespace System::Runtime::InteropServices

%sectiondef%

# namespace System::Windows::Forms

%sectiondef%

# file 3DEngine.cpp

## define

### define %type% EXTERN_C

## var

### variable CComModule _Module

### variable CMy3DEngineApp theApp

## func

### function STDAPI DllCanUnloadNow

### function STDAPI DllGetClassObject

### function STDAPI DllRegisterServer

### function STDAPI DllUnregisterServer

# file 3DEngine.h

## define

### define %type% __G3DKernel_FWD_DEFINED__

### define %type% __IG3DKernel_FWD_DEFINED__

### define %type% __IG3DKernel_INTERFACE_DEFINED__

### define %type% __KernelLib_LIBRARY_DEFINED__

### define %type% __REQUIRED_RPCNDR_H_VERSION__

## typedef

### typedef struct G3DKernel G3DKernel

### typedef interface IG3DKernel IG3DKernel

### typedef struct IG3DKernelVtbl IG3DKernelVtbl

## var

### variable RPC_IF_HANDLE __MIDL_itf__3DEngine_0000_0000_v0_0_c_ifspec

### variable RPC_IF_HANDLE __MIDL_itf__3DEngine_0000_0000_v0_0_s_ifspec

### variable EXTERN_C const CLSID CLSID_G3DKernel

### variable EXTERN_C const IID IID_IG3DKernel

### variable EXTERN_C const IID LIBID_KernelLib

## func

### function HRESULT STDMETHODCALLTYPE IG3DKernel_AddAutoalignMeasureElement_Proxy

### function void __RPC_STUB IG3DKernel_AddAutoalignMeasureElement_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_AddDefaultPos_Proxy

### function void __RPC_STUB IG3DKernel_AddDefaultPos_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_AddMeasureElementToView_Proxy

### function void __RPC_STUB IG3DKernel_AddMeasureElementToView_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_AddPickPoint_Proxy

### function void __RPC_STUB IG3DKernel_AddPickPoint_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_ArcLeft_Proxy

### function void __RPC_STUB IG3DKernel_ArcLeft_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_ArcRight_Proxy

### function void __RPC_STUB IG3DKernel_ArcRight_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CatchAlign_Proxy

### function void __RPC_STUB IG3DKernel_CatchAlign_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CatchAlignAny_Proxy

### function void __RPC_STUB IG3DKernel_CatchAlignAny_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CompressEdges_Proxy

### function void __RPC_STUB IG3DKernel_CompressEdges_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CompressFaces_Proxy

### function void __RPC_STUB IG3DKernel_CompressFaces_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CompressPoints_Proxy

### function void __RPC_STUB IG3DKernel_CompressPoints_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_CreateNewJoint_Proxy

### function void __RPC_STUB IG3DKernel_CreateNewJoint_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_DeletePickPoint_Proxy

### function void __RPC_STUB IG3DKernel_DeletePickPoint_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_EnableDeveloperMode_Proxy

### function void __RPC_STUB IG3DKernel_EnableDeveloperMode_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_FindMaterial_Proxy

### function void __RPC_STUB IG3DKernel_FindMaterial_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_ForceIntoBox_Proxy

### function void __RPC_STUB IG3DKernel_ForceIntoBox_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetBasePath_Proxy

### function void __RPC_STUB IG3DKernel_GetBasePath_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetElementOrientation_Proxy

### function void __RPC_STUB IG3DKernel_GetElementOrientation_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetInterface_Proxy

### function void __RPC_STUB IG3DKernel_GetInterface_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetMeasureDefaultColor_Proxy

### function void __RPC_STUB IG3DKernel_GetMeasureDefaultColor_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetPath_Proxy

### function void __RPC_STUB IG3DKernel_GetPath_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetPickPoint_Proxy

### function void __RPC_STUB IG3DKernel_GetPickPoint_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetPrimitiveStringAttributeValue_Proxy

### function void __RPC_STUB IG3DKernel_GetPrimitiveStringAttributeValue_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetTexture_Proxy

### function void __RPC_STUB IG3DKernel_GetTexture_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetValue_Proxy

### function void __RPC_STUB IG3DKernel_GetValue_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_GetVersion_Proxy

### function void __RPC_STUB IG3DKernel_GetVersion_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_IsDeveloperModeEnabled_Proxy

### function void __RPC_STUB IG3DKernel_IsDeveloperModeEnabled_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_IsModified_Proxy

### function void __RPC_STUB IG3DKernel_IsModified_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_LoadFilter_Proxy

### function void __RPC_STUB IG3DKernel_LoadFilter_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_LoadObjectEx_Proxy

### function void __RPC_STUB IG3DKernel_LoadObjectEx_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_Log_Proxy

### function void __RPC_STUB IG3DKernel_Log_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_MirrorEx_Proxy

### function void __RPC_STUB IG3DKernel_MirrorEx_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_MoveForward_Proxy

### function void __RPC_STUB IG3DKernel_MoveForward_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_NewTurtle_Proxy

### function void __RPC_STUB IG3DKernel_NewTurtle_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_Objects_Proxy

### function void __RPC_STUB IG3DKernel_Objects_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_Primitives_Proxy

### function void __RPC_STUB IG3DKernel_Primitives_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_RotationalSweep_Proxy

### function void __RPC_STUB IG3DKernel_RotationalSweep_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SaveFileLink_Proxy

### function void __RPC_STUB IG3DKernel_SaveFileLink_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SeparatePrimitives_Proxy

### function void __RPC_STUB IG3DKernel_SeparatePrimitives_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetAutoStretchFactor_Proxy

### function void __RPC_STUB IG3DKernel_SetAutoStretchFactor_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetBasePath_Proxy

### function void __RPC_STUB IG3DKernel_SetBasePath_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetElementOrientation_Proxy

### function void __RPC_STUB IG3DKernel_SetElementOrientation_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetFlag_Proxy

### function void __RPC_STUB IG3DKernel_SetFlag_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetHeading_Proxy

### function void __RPC_STUB IG3DKernel_SetHeading_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetJointTo_Proxy

### function void __RPC_STUB IG3DKernel_SetJointTo_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetLogFile_Proxy

### function void __RPC_STUB IG3DKernel_SetLogFile_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetMeasureDefaultColor_Proxy

### function void __RPC_STUB IG3DKernel_SetMeasureDefaultColor_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetMeasureFont_Proxy

### function void __RPC_STUB IG3DKernel_SetMeasureFont_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetModifiedElementMaterial_Proxy

### function void __RPC_STUB IG3DKernel_SetModifiedElementMaterial_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetObjectRenderOffset_Proxy

### function void __RPC_STUB IG3DKernel_SetObjectRenderOffset_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetPosition_Proxy

### function void __RPC_STUB IG3DKernel_SetPosition_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetRecordPath_Proxy

### function void __RPC_STUB IG3DKernel_SetRecordPath_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SetSnapshotsDirectory_Proxy

### function void __RPC_STUB IG3DKernel_SetSnapshotsDirectory_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_ShrinkPolygon3D_Proxy

### function void __RPC_STUB IG3DKernel_ShrinkPolygon3D_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_SqueezeIntoBox_Proxy

### function void __RPC_STUB IG3DKernel_SqueezeIntoBox_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_TurnLeft_Proxy

### function void __RPC_STUB IG3DKernel_TurnLeft_Stub

### function HRESULT STDMETHODCALLTYPE IG3DKernel_TurnRight_Proxy

### function void __RPC_STUB IG3DKernel_TurnRight_Stub

# file 3DEngine.idl

%sectiondef%

# file 3DEngine_i.c

## define

### define %type% __IID_DEFINED__

### define %type% CLSID_DEFINED

### define %type% MIDL_DEFINE_GUID

## typedef

### typedef IID CLSID

### typedef struct _IID IID

## func

### function MIDL_DEFINE_GUID

### function MIDL_DEFINE_GUID

### function MIDL_DEFINE_GUID

# file Catalog.cpp

## define

### define %type% CATALOG_SECT

### define %type% max3

# file Catalog.h

## define

### define %type% CCatalogDescription

## typedef

### typedef CColor CMaterial

### typedef CSelectionColor CSelectionMaterial

# file CatalogDlg.cpp

%sectiondef%

# file CatalogDlg.h

%sectiondef%

# file clipper.cpp

## define

### define %type% HORIZONTAL

### define %type% NEAR_ZERO

### define %type% TOLERANCE

# file clipper.h

## define

### define %type% CLIPPER_VERSION

### define %type% use_deprecated

# file ContentDlg.cpp

## var

### variable const UINT_PTR g_checkTimerId

### variable const UINT_PTR g_refreshTimerId

# file ContentDlg.h

%sectiondef%

# file DisableLogNumbers.h

## func

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

### function LogsDisableList AddTail

# file DllDlg.cpp

%sectiondef%

# file DllDlg.h

%sectiondef%

# file G3DKernel.cpp

## define

### define %type% _countof

### define %type% ENABLE_LOG

### define %type% G3D_DEF_LOG_PATH

### define %type% G3D_DEF_RECORD_PATH

### define %type% G3D_DEF_SNAPSHOT_DIRECTORY

### define %type% G3D_FILE_NAME_SNAPSHOT

### define %type% G3D_OBJECT_NAME_SNAPSHOT

### define %type% GENERATE_DEBUG_OUTPUT

### define %type% MAJOR_NUMBER

### define %type% MINOR_NUMBER

## var

### variable const CString G3D_CATALOG_DESCRIPTION_EMPTY_NAME

### variable const CString G3D_CATALOG_DESCRIPTION_FORMAT_STRING

### variable const char G3D_CATALOG_DESCRIPTION_SEPARATOR

### variable const char G3D_CATALOGS_DESCRIPTIONS_SEPARATOR

### variable const double G3D_DEF_AUTO_STRETCH_FACTOR

### variable CString g_BasePath

### variable bool g_caseSensitiveMaterialNames

### variable int g_currentA3dTraceIndex

### variable bool g_inDeveloperMode

### variable CString g_logPath

### variable CG3DKernel * g_pKernel

### variable CString g_recordPath

### variable bool g_SingleStep

### variable CString g_snapshotDirectory

### variable int g_snapshotNr

### variable bool g_useSqueezeIntoBoxInsteadOfBooleanOperations

### variable const GUID IID_DObjectViewer

## func

### function BOOL AddLogMsg

### function BOOL Check

### function void DeleteFaceMaterials

### function void DetermineBasePath

### function void DumpSaveInfo

### function BOOL GenerateTestOutline

### function BOOL ShrinkPolygon

### function BOOL ShrinkPolygonWithClipper

### function BOOL TryGetRelativeDirectory

# file G3DKernel.h

## define

### define %type% FLAG_USE_CLIPPER_LIBRARY

## var

### variable const int CYLINDRICAL

### variable const int LINEAR

### variable CString LogPath

### variable const int PROJECTION_X

### variable const int PROJECTION_Y

### variable const int PROJECTION_Z

### variable const int SPHERICAL

## func

### function __declspec

# file G3DKernelGlobal.h

## var

### variable CString g_BasePath

# file G3dKernelScriptingHost.cpp

## var

### variable const GUID CDECL BASED_CODE _tlid

### variable const WORD _wVerMajor

### variable const WORD _wVerMinor

### variable const IID IID_IG3dScriptingHost

## func

### function const CString G3D_SCRIPT_TEMPLATE

# file G3dKernelScriptingHost.h

%sectiondef%

# file KernelLicense.cpp

%sectiondef%

# file KernelLicense.h

%sectiondef%

# file LOGFILC.HPP

## define

### define %type% AddMeasureElementSym

### define %type% AddObjectMeasureElementSym

### define %type% AddTextElementSym

### define %type% CopySym

### define %type% CreateCatalogSym

### define %type% CreateDoubleAttributeSym

### define %type% CreateIntAttributeSym

### define %type% CreateLongAttributeSym

### define %type% CreateNewObjectSym

### define %type% CreateProducerSym

### define %type% CreateRootSym

### define %type% CreateStringAttributeSym

### define %type% CutSym

### define %type% DeGroupSym

### define %type% DeleteAttributeSym

### define %type% DifferenceSym

### define %type% EnGroupSym

### define %type% EOFSym

### define %type% ExtrudePathSym

### define %type% ExtrudeSym

### define %type% FindAttributeSym

### define %type% GetAttributeCountSym

### define %type% GetAttributeHeadPositionSym

### define %type% GetAttributeTypeSym

### define %type% GetCatalogCountSym

### define %type% GetCatalogHeadPositionSym

### define %type% GetCatalogPathSym

### define %type% GetDefaultMaterialPathSym

### define %type% GetDoubleAttributeValueSym

### define %type% GetElementChildCountSym

### define %type% GetElementHeadPositionSym

### define %type% GetElementNameSym

### define %type% GetElementPositionSym

### define %type% GetElementSizeSym

### define %type% GetFatherSym

### define %type% GetIntAttributeValueSym

### define %type% GetLongAttributeValueSym

### define %type% GetMaterialHeadPositionSym

### define %type% GetMaterialPoolSym

### define %type% GetNextAttributeSym

### define %type% GetNextCatalogSym

### define %type% GetNextElementSym

### define %type% GetNextMaterialSym

### define %type% GetNextProducerSym

### define %type% GetProducerCountSym

### define %type% GetProducerHeadPositionSym

### define %type% GetRootItemSym

### define %type% GetStringAttributeValueSym

### define %type% GetTextElementFontSym

### define %type% GetTextElementHeightSym

### define %type% GetTextElementTextSym

### define %type% GetTextElementThicknessSym

### define %type% getUnderscoremUnderscoreDefaSym

### define %type% getUnderscoremUnderscorehInsSym

### define %type% identSym

### define %type% integerSym

### define %type% IntersectionSym

### define %type% IsObjectIdSym

### define %type% KillObjectSym

### define %type% LbraceSym

### define %type% LoadFilterSym

### define %type% LoadObjectSym

### define %type% MAXT

### define %type% MirrorSym

### define %type% NoSym

### define %type% RbraceSym

### define %type% realSym

### define %type% RotateBySym

### define %type% RotateToSym

### define %type% SaveElementToFileSym

### define %type% ScaleBySym

### define %type% ScaleToSym

### define %type% SetCatalogPathSym

### define %type% SetDefaultMaterialPathSym

### define %type% SetDoubleAttributeValueSym

### define %type% SetElementMaterialSym

### define %type% SetElementNameSym

### define %type% SetElementSelMaterialSym

### define %type% SetElementVisibilitySym

### define %type% SetIntAttributeValueSym

### define %type% SetLongAttributeValueSym

### define %type% SetMeasureDefaultFontSym

### define %type% SetMeasureDefaultObjectDistSym

### define %type% SetMeasureDefaultTextDistSym

### define %type% SetMeasureDefaultUnitSym

### define %type% SetRedrawSym

### define %type% SetStringAttributeValueSym

### define %type% SetTextElementFontSym

### define %type% SetTextElementHeightSym

### define %type% SetTextElementTextSym

### define %type% SetTextElementThicknessSym

### define %type% SmoothElementSym

### define %type% stringSym

### define %type% TranslateBySym

### define %type% TranslateToSym

### define %type% UnionSym

### define %type% UnSmoothElementSym

# file LOGFILE.HPP

## var

### variable EOF expected

### variable EOF ident integer real string get_m_hInstance get_m_DefaultRoot CreateRoot LoadObject GetRootItem GetElementHeadPosition GetNextElement GetElementChildCount KillObject GetElementName Union Intersection Difference SaveElementToFile SmoothElement UnSmoothElement TranslateTo TranslateBy ScaleBy ScaleTo RotateBy RotateTo GetElementPosition SetElementVisibility IsObjectId GetElementSize GetMaterialHeadPosition GetNextMaterial SetElementMaterial SetElementSelMaterial Cut EnGroup DeGroup GetFather CreateNewObject SetElementName GetMaterialPool AddTextElement SetTextElementText SetTextElementFont GetTextElementFont GetTextElementText SetDefaultMaterialPath GetDefaultMaterialPath SetTextElementHeight GetTextElementHeight SetTextElementThickness GetTextElementThickness CreateProducer CreateCatalog SetCatalogPath GetCatalogPath GetProducerHeadPosition GetNextProducer GetCatalogHeadPosition GetNextCatalog GetProducerCount GetCatalogCount CreateStringAttribute CreateIntAttribute CreateLongAttribute CreateDoubleAttribute SetStringAttributeValue SetIntAttributeValue SetLongAttributeValue SetDoubleAttributeValue GetStringAttributeValue GetIntAttributeValue GetDoubleAttributeValue GetLongAttributeValue GetAttributeCount GetAttributeHeadPosition GetNextAttribute GetAttributeType DeleteAttribute FindAttribute ExtrudePath Extrude SetRedraw Copy Mirror AddMeasureElement SetMeasureDefaultFont SetMeasureDefaultTextDist SetMeasureDefaultUnit AddObjectMeasureElement LoadFilter expected SetMeasureDefaultObjectDist No unexpected symbol in LogLine

# file LOGFILP.CPP

## var

### variable CG3DKernel * g_pKernel

### variable bool g_SingleStep

### variable CMap< long, long, long, long > ObjMap

### variable CMap< long, long, long, long > PosMap

## func

### function bool CheckObjMap

# file LOGFILP.HPP

## var

### variable const int MAXERROR

### variable const int MAXSYM

# file LOGFILS.CPP

## define

### define %type% Scan_BuffPos

### define %type% Scan_Ch

### define %type% Scan_ComEols

### define %type% Scan_CurrCol

### define %type% Scan_CurrLine

### define %type% Scan_LineStart

### define %type% Scan_NextCh

### define %type% Scan_NextLen

# file LOGFILS.HPP

%sectiondef%

# file measure.cpp

%sectiondef%

# file measure.h

## enum

### enum %type% MeasureUnit

# file scrrun.cpp

%sectiondef%

# file scrrun.h

%sectiondef%

# file Text.cpp

%sectiondef%

# file Text.h

%sectiondef%

# file Turtle.cpp

%sectiondef%

# file Turtle.h

%sectiondef%

# file ViewUpdate.h

## var

### variable const int HintInvalidate

# file 3DOCX.md

%sectiondef%

# file ActiveScriptHost.cpp

## func

### function HRESULT LoadTypeInfoFromModule

### function STDMETHODIMP_

# file ActiveScriptHost.cpp

## func

### function HRESULT LoadTypeInfoFromModule

### function STDMETHODIMP_

# file ActiveScriptHost.h

## define

### define %type% ACTIVS_HOST

### define %type% LANG_ENGLISH_NEUTRAL

### define %type% LOCALE_SCRIPT_DEFAULT

### define %type% SCRIPTITEM_NAMEDITEM

# file ActiveScriptHost.h

## define

### define %type% ACTIVS_HOST

### define %type% LANG_ENGLISH_NEUTRAL

### define %type% LOCALE_SCRIPT_DEFAULT

### define %type% SCRIPTITEM_NAMEDITEM

# file CatchSet.cpp

%sectiondef%

# file CatchSet.h

## typedef

### typedef CArray< CCatchPoint, CCatchPoint & > _CCatchSet

## var

### variable const int SnapLine

### variable const int SnapLineMatrix

### variable const int SnapPoint

### variable const int SnapPointMatrix

# file CLight.cpp

%sectiondef%

# file CLight.h

## typedef

### typedef CArray< CLight, CLight > LightArray

# file DelayedDirectoryChangeHandler.cpp

## define

### define %type% _TESTING_WILDCMP_ONLY_

### define %type% UWM_DELAYED_DIRECTORY_NOTIFICATION

## func

### function LRESULT CALLBACK DelayedNotificationWndProc

### function HINSTANCE GetInstanceHandle

### function DWORD GetPathOffsetBasedOnFilterFlags

### function bool HasTrailingBackslash

### function bool IsEmptyString

### function bool IsNonFilterableEvent

### function BOOL STDAPICALLTYPE wildcmp

# file DelayedDirectoryChangeHandler.h

## typedef

### typedef BOOL(STDAPICALLTYPE * FUNC_PatternMatchSpec

# file DeveloperTools.cpp

%sectiondef%

# file DeveloperTools.h

%sectiondef%

# file Dimension.cpp

%sectiondef%

# file Dimension.h

%sectiondef%

# file DirectoryChanges.cpp

## func

### function BOOL EnablePrivilege

### function bool HasTrailingBackslash

### function bool IsDirectory

# file DirectoryChanges.h

## define

### define %type% READ_DIR_CHANGE_BUFFER_SIZE

# file DotnetHelpers.cpp

%sectiondef%

# file DotnetHelpers.h

%sectiondef%

# file DynamicMenu.cpp

%sectiondef%

# file DynamicMenu.h

## define

### define %type% ITEM_ADDED

### define %type% ITEM_DELETED

## typedef

### typedef CArray< MenuItem *, MenuItem * > MenuItemArray

## var

### variable const int maxItems

### variable const UINT maxRange

### variable const UINT minRange

# file FlexibleMessageBox.cpp

%sectiondef%

# file FlexibleMessageBox.h

%sectiondef%

# file FontPool.cpp

## func

### function CString MappedFontName

# file FontPool.h

%sectiondef%

# file G3dScriptingHost.cpp

## var

### variable const IID IID_IG3dScriptingHost

## func

### function const CString G3D_SCRIPT_TEMPLATE

# file G3dScriptingHost.h

%sectiondef%

# file GLFont.cpp

## define

### define %type% GLF_THICKNESS

### define %type% MESA_SIZE_CORRECTION

## var

### variable BOOL g_createOnTheFly

## func

### function UINT CreateFont

### function int FontListSize

# file GLFont.h

## define

### define %type% FIRST_CHARACTER_CODE

### define %type% FONTLIST

### define %type% UNICODEFONTSIZE

## enum

### enum %type% GLFontType

# file ImageDefinition.cpp

## var

### variable const char * IDS_FORMAT_STRING

### variable const char IDS_SEPARATOR

### variable const char IDS_VALUES_SEPARATOR

# file ImageDefinition.h

## define

### define %type% IDS_ATTRIBUTE

# file InputDialog.cpp

%sectiondef%

# file InputDialog.h

%sectiondef%

# file IObjectViewerCtl.cpp

%sectiondef%

# file IObjectViewerCtl.h

## define

### define %type% IObjectViewerCtlMajorVersion

### define %type% IObjectViewerCtlMinorVersion

# file LayerManager.cpp

%sectiondef%

# file LayerManager.h

## var

### variable const int NrOfLayers

# file MaterialsReloader.cpp

%sectiondef%

# file MaterialsReloader.h

%sectiondef%

# file MeasureSorter.cpp

%sectiondef%

# file MeasureSorter.h

## typedef

### typedef CArray< CTempMeasure *, CTempMeasure * > _CTempMeasureArray

# file Multisample.cpp

## define

### define %type% MS_SHOW_DEBUG_MESSAGES

### define %type% WGL_SAMPLE_BUFFERS_ARB

### define %type% WGL_SAMPLES_ARB

## typedef

### typedef map< string, bool > ExtensionSupports

## var

### variable ExtensionSupports g_extensionSupports

# file Multisample.h

%sectiondef%

# file ObjectViewer.cpp

## var

### variable const GUID CDECL BASED_CODE _tlid

### variable const WORD _wVerMajor

### variable const WORD _wVerMinor

### variable CObjectViewerApp NEAR theApp

## func

### function STDAPI DllRegisterServer

### function STDAPI DllUnregisterServer

# file ObjectViewer.h

## var

### variable const GUID CDECL _tlid

### variable const WORD _wVerMajor

### variable const WORD _wVerMinor

# file ObjectViewer.odl

%sectiondef%

# file ObjectViewer_h.h

## define

### define %type% ___DObjectViewer_DISPINTERFACE_DEFINED__

### define %type% ___DObjectViewer_FWD_DEFINED__

### define %type% ___DObjectViewerEvents_DISPINTERFACE_DEFINED__

### define %type% ___DObjectViewerEvents_FWD_DEFINED__

### define %type% __ObjectViewer_FWD_DEFINED__

### define %type% __OBJECTVIEWERLib_LIBRARY_DEFINED__

### define %type% __REQUIRED_RPCNDR_H_VERSION__

## typedef

### typedef interface _DObjectViewer _DObjectViewer

### typedef interface _DObjectViewerEvents _DObjectViewerEvents

### typedef struct _DObjectViewerEventsVtbl _DObjectViewerEventsVtbl

### typedef struct _DObjectViewerVtbl _DObjectViewerVtbl

### typedef struct ObjectViewer ObjectViewer

## var

### variable RPC_IF_HANDLE __MIDL_itf_ObjectViewer_0000_0000_v0_0_c_ifspec

### variable RPC_IF_HANDLE __MIDL_itf_ObjectViewer_0000_0000_v0_0_s_ifspec

### variable EXTERN_C const CLSID CLSID_ObjectViewer

### variable EXTERN_C const IID DIID__DObjectViewer

### variable EXTERN_C const IID DIID__DObjectViewerEvents

### variable EXTERN_C const IID LIBID_OBJECTVIEWERLib

# file ObjectViewer_i.c

## define

### define %type% __IID_DEFINED__

### define %type% CLSID_DEFINED

### define %type% MIDL_DEFINE_GUID

## typedef

### typedef IID CLSID

### typedef struct _IID IID

## func

### function MIDL_DEFINE_GUID

### function MIDL_DEFINE_GUID

### function MIDL_DEFINE_GUID

### function MIDL_DEFINE_GUID

# file ObjectViewerCtl.cpp

## define

### define %type% _countof

### define %type% _countof

### define %type% FROM_MENU

### define %type% GL_GLEXT_PROTOTYPES

### define %type% GL_GLEXT_PROTOTYPES

### define %type% LOWER_BOUND_QUALITY

### define %type% NO_LICENSE

### define %type% OV_PVRENDER_DIRECTORY

### define %type% OV_PVRENDER_FILENAME

### define %type% REGISTER_VIEWER_AUTO

### define %type% SQR

### define %type% UPPER_BOUND_QUALITY

## typedef

### typedef long * IMaterialCatalogSet

## var

### variable const DWORD BASED_CODE _dwObjectViewerOleMisc

### variable const BOOL AccurateShadows

### variable const int BitmapResampleQuality

### variable const int BUFFER_LENGTH

### variable const double DefaultAutoAmbient

### variable const double DefaultAutoDiffuse

### variable const double DefaultAutoSpecular

### variable const BOOL DefaultEnableOriginAxis

### variable const BOOL DefaultEnableRotationAxis

### variable const int DefaultFastBitmapRendering

### variable const int DefaultForceSoftwareRendering

### variable const int DefaultIsRenderingToControlEnabled

### variable const int DefaultMouseMode

### variable const int DefaultPrintQuality

### variable const int DefaultZoomMode

### variable const char * EntryFastBitmapRendering

### variable const char * EntryForceSoftwareRendering

### variable const char * EntryIsRenderingToControlEnabled

### variable const double EyePointScaling

### variable const double FieldOfView

### variable CString g_extensions

### variable BOOL g_glewExtensionsLoaded

### variable const bool g_isTradeFairVersion

### variable CString g_mostRecentSaveSceneryToFilePath

### variable CSemaphore g_openGlSynchronizationObject

### variable CString g_openGlVersion

### variable double g_pickDimension

### variable IG3DKernel * g_pKernelRef

Zeiger auf den zuletzt mit "UseKernel" gesetzten Grafikkernel. Es kann im Allgemeinen damit gerechnet werden, dass nur 1 Grafikkernel zum Einsatz kommt.

### variable CString g_settingsDirectory

### variable BOOL g_supportUnicode

### variable bool g_useDotnetForRealBitmapDimensions

### variable DWORD g_writeDirectoryListTimer

### variable HDC hPreviousTemporaryDC

### variable HGLRC hPreviousTemporaryRC

### variable HDC hPreviousTemporaryRenderDC

### variable HWND hPreviousTemporaryWindow

### variable const short IdBackgroundGrey

### variable const short IdBackgroundWhite

### variable const short IdBrightnessBrighter

### variable const short IdBrightnessDarker

### variable const short IdBrightnessNormal

### variable const short IdChangeSelectedText

### variable const short IdClearLayoutPath

Pfad der Layout-Datei löschen.

### variable const short IdCreateBox

Box erzeugen.

### variable const short IdDeleteSelectedText

### variable const short IdDeveloperMode

### variable const short IdDisableRotation

Rotation deaktivieren.

### variable const short IdDisableShadows

Schatten deaktivieren.

### variable const short IdDumpInformation

Informationen über die 3D-Grafik ins Ausgabefenster des Debuggers dumpen.

### variable const short IdEnableOrthogonal

Orthogonal aktivieren.

### variable const short IdEnablePerspective

Perspektive aktivieren.

### variable const short IdEnableRotation

Rotation aktivieren.

### variable const short IdEnableShadows

Schatten aktivieren.

### variable const short IdImprovedRenderingWithoutSpecularLighting

Verbesserte Darstellung (perspektivisch ohne Glanzlichter)

### variable const short IdImprovedRenderingWithSpecularLighting

Verbesserte Darstellung (perspektivisch mit Glanzlichtern)

### variable const short IdImprovedRenderingWithSpecularLightingAndShadows

Verbesserte Darstellung (perspektivisch mit Glanzlichtern und Schatten)

### variable const short IdIsMeasureModified

Manuelle Maße geändert?

### variable const short IdIsModified

### variable const short IdLoadImage

(Hintergrund-)Bild laden

### variable const short IdPhotorealismBest

Pov-Datei exportieren (bestmöglich)

### variable const short IdPhotorealismFast

Pov-Datei exportieren (schnell)

### variable const short IdProvokeGraphicsError

Grafikfehler simulieren.

### variable const short IdReloadMaterials

Materialien neu laden.

### variable const short IdRemoveTextureCoordinates

Texturen nachrechnen.

### variable const short IdSaveA3d

A3d-Datei speichern.

### variable const short IdSaveMaterials

### variable const short IdSetLayoutPath

Pfad der Layout-Datei setzen.

### variable const short IdSetMouseModeAddText

### variable const short IdSetMouseModeIdentify

### variable const short IdSetMouseModeMove

### variable const short IdSetMouseModeNone

### variable const short IdShowApiHelp

Hilfe zum API anzeigen.

### variable const short IdShowDebugDialog

### variable const short IdShowOpenGlVersion

OpenGL-Version anzeigen.

### variable const short IdStandardRendering

Standarddarstellung (orthogonal ohne Glanzlichter)

### variable const short IdTest

### variable const short IdToggleAdjustmentMode

Zwischen amStandard und amNormalPrimitives wechseln.

### variable const short IdToggleCross

Koordinatenkreuz ein- und ausschalten.

### variable const short IdToggleEnhancementMode

Zwischen altem und neuem Kantenverstärkungsmodus wechseln.

### variable const short IdToggleFastBitmapRendering

Zwischen normalem Rendering und erzwungenem Software-Rendering wechseln.

Zwischen normalem und schnellem Rendering in eine Bitmap wechseln.

### variable const short IdToggleForceSoftwareRendering

### variable const short IdToggleRenderingToControl

Darstellung im Control ein- bzw. ausschalten.

### variable const IID BASED_CODE IID_DObjectViewer

### variable const IID BASED_CODE IID_DObjectViewerEvents

### variable bool initializeKernel

### variable CMatrix InvModelViewMat

### variable double JitterX

### variable double JitterY

### variable const int MinimalSoftwareAntialiasingQuality

### variable CMatrix ModelViewMat

### variable const char * ov3DLinesAttribute

### variable const char * ov3DLinesFormatString

### variable const char ovItemsSeparator

### variable const char ovValuesSeparator

### variable const int PreSetAutoModeResetTimerId

### variable int previousHeight

### variable int previousWidth

### variable const UINT RefreshInterval

### variable const int RefreshTimerId

### variable int Samples

### variable const char * SectionSettings

### variable const char * SettingsFilename

### variable const int StencilBits

### variable CObjectViewerApp NEAR theApp

### variable const double ViewOffset

## func

### function BOOL Check

Schreibt eine Meldung in die Log-Datei, wenn eine Bedingung den Wert FALSE hat.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| condition | Bedingung. |
| FormatStr | Formatierstring (wie "printf"). |

#### return

Es wird der Wert der Bedingung unverändert zurückgegeben.

### function void DisplayMatrix4x4

### function void DisplayMatrix4x4

### function void DrawLine

### function void DumpDevice

### function int GetBitmapAntialiasingFactorDenominator

### function int GetBitmapAntialiasingFactorNumerator

### function int GetJitterDivisor

### function int GetSettingsInt

### function BOOL IsBitmapOk

### function bool IsFastBitmapRenderingEnabled

### function bool IsForceSoftwareRenderingEnabled

### function bool IsRenderModeFaces

### function void PerformSpecialSaveSceneryToFileTasks

Führt Operationen am Ende von "SaveSceneryToFile" für Spezialzwecke (z.B. als Hilfe beim Debuggen) durch.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| path | Pfad zur Datei, die in "SaveSceneryToMemory" geschrieben wird. |

### function bool PixelHasColor

### function void SetFastBitmapRendering

### function void SetForceSoftwareRendering

### function void SetOrtho

### function CString SettingsPath

### function void TransformToScreen

### function CVector TriangleSize

### function VOID CALLBACK WriteDirectoryListByPathTimerProcedure

### function BOOL WriteFileEx

### function void WriteLogMsg

Schreibt eine Meldung in die Log-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| FormatStr | Formatierstring (wie "printf"). |

### function void WriteSettingsInt

# file ObjectViewerCtl.h

## define

### define %type% IF_BMP

### define %type% IF_GIF

### define %type% IF_JPEG

### define %type% IF_PNG

### define %type% IF_TIFF

### define %type% OV_TEXT_TEXT_INPUT_CANCEL_BUTTON_LABEL

### define %type% OV_TEXT_TEXT_INPUT_OK_BUTTON_LABEL

### define %type% OV_TEXT_TEXT_INPUT_TITLE

## enum

### enum %type% AdjustmentMode

### enum %type% BrightnessLevel

### enum %type% CatchDisplayMode

### enum %type% CViewer3dLineStyles

### enum %type% IdentifyMode

### enum %type% MouseMode

### enum %type% OpenGlType

### enum %type% RenderMode

### enum %type% SelectionMode

### enum %type% ViewMode

### enum %type% ZoomMode

## typedef

### typedef CArray< CRenderOnlineText, CRenderOnlineText & > COnlineTexts

### typedef CArray< CViewer2DLine, CViewer2DLine & > CViewer2DLineArray

### typedef std::list< CViewer3DLine > CViewer3DLines

### typedef CArray< CZoomStackEntry, CZoomStackEntry & > CZoomStack

### typedef CList< OBJID, OBJID > SelObList

## var

### variable CSemaphore g_openGlSynchronizationObject

### variable BOOL g_supportUnicode

## func

### function BOOL Check

Schreibt eine Meldung in die Log-Datei, wenn eine Bedingung den Wert FALSE hat.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| condition | Bedingung. |
| FormatStr | Formatierstring (wie "printf"). |

#### return

Es wird der Wert der Bedingung unverändert zurückgegeben.

### function void WriteLogMsg

Schreibt eine Meldung in die Log-Datei.

#### Parameters

| Typ | Beschreibung |
| --- | --- |
| FormatStr | Formatierstring (wie "printf"). |

# file ObjectViewerHelpers.cpp

%sectiondef%

# file ObjectViewerHelpers.h

%sectiondef%

# file ObjectViewerPpg.cpp

## func

### function IMPLEMENT_OLECREATE_EX

# file ObjectViewerPpg.h

%sectiondef%

# file OpenGLRenderer.cpp

%sectiondef%

# file OpenGLSphere.cpp

## func

### function void OpenGLSphere

# file OpenGLSphere.h

## func

### function void OpenGLSphere

# file PickSet.cpp

%sectiondef%

# file PickSet.h

## typedef

### typedef CArray< CPickPoint, CPickPoint & > _CPickSet

# file PovGenerator.cpp

## define

### define %type% _countof

## var

### variable const char AMBIENT_LIGHT

### variable const char AREA_LIGHT

### variable const char BACKGROUND

### variable const char CAMERA

### variable const char CAMERA_LIGHT

### variable const char * FILE_EXT_TEXTURE

### variable bool g_isFirstCall

### variable ofstream g_oStream

### variable const char GLOBAL_SETTINGS

### variable const char LIGHT

### variable const char RADIOSITY

### variable const char RGB_COLOR

### variable const char SHADOW_AREA_LIGHT

### variable const char SHADOW_LIGHT

### variable const char TEXTURE_COLOR

### variable const char UV_MACROS

## func

### function void CleanText

### function void CleanVector

### function BOOL GenerateTextureBitmap

### function BOOL GenerateTextureBitmap

### function CString GetLightFormatString

### function bool IsChromiumLikeMaterialName

### function BOOL IsSpecialChar

### function CString LocationString

### function CVector NormalizeColor

### function CString NumberString

### function CString RgbfString

### function CString RgbString

### function CString RgbtString

### function BOOL UVCoordinatesValid

### function CString VectorString

### function void WritePoint

### function void WritePoint

### function void WriteString

### function void WriteTriangle

### function void WriteTriangle

### function void WriteVector

# file PovGenerator.h

## typedef

### typedef vector< CLightSetting > CLightSettings

## var

### variable const double DefaultAmbientLuminance

### variable const double DefaultBackgroundLuminance

### variable const double DefaultCameraLightLuminance

### variable const double DefaultFadePower

### variable const double DefaultFieldOfVision

### variable const double DefaultGamma

### variable const bool DefaultGenerateCameraLight

### variable const double DefaultLightColorCorrectionFactor

### variable const double DefaultLightLuminance

### variable const double DefaultMinimalRgbAmbientLuminance

### variable const double DefaultMinimalRgbDiffuseLuminance

### variable const double DefaultMinimalRgbSpecularLuminance

### variable const double DefaultMinimalTextureAmbientLuminance

### variable const double DefaultMinimalTextureDiffuseLuminance

### variable const double DefaultMinimalTextureSpecularLuminance

### variable const bool DefaultTerminationRequested

### variable const bool DefaultUseRadiosity

## func

### function const CVector DefaultCameraPosition

### function const CVector DefaultLookAtPosition

# file PrintProgressDlg.cpp

%sectiondef%

# file PrintProgressDlg.h

%sectiondef%

# file resource.h

## define

### define %type% IDB_BITMAP1

### define %type% IDB_OBJECTVIEWER

### define %type% IDC_AUTOZOOM_CURSOR

### define %type% IDC_AUTOZOOM_CURSOR_PAN

### define %type% IDC_AUTOZOOM_CURSOR_ZOOM

### define %type% IDC_EDIT1

### define %type% IDC_INPUT_TEXT_EDIT

### define %type% IDC_INPUT_TEXT_LABEL_STATIC

### define %type% IDC_MOVE_CURSOR

### define %type% IDC_QUALITY

### define %type% IDC_STATUS

### define %type% IDC_TILE

### define %type% IDC_TOTAL_TILES

### define %type% IDD_ABOUTBOX_OBJECTVIEWER

### define %type% IDD_DIALOG1

### define %type% IDD_DIALOG2

### define %type% IDD_DIALOG3

### define %type% IDD_INPUT_DIALOG

### define %type% IDD_PRINT_PROGRESS

### define %type% IDD_PROPPAGE_OBJECTVIEWER

### define %type% IDI_ABOUTDLL

### define %type% IDI_ICON1

### define %type% IDR_HTML1

### define %type% IDR_HTML2

### define %type% IDS_BACKGROUND_GREY

### define %type% IDS_BACKGROUND_WHITE

### define %type% IDS_BEST_PHOTOREALISM

### define %type% IDS_BRIGHTNESS_BRIGHTER

### define %type% IDS_BRIGHTNESS_DARKER

### define %type% IDS_BRIGHTNESS_NORMAL

### define %type% IDS_CREATING_FONTS

### define %type% IDS_DISABLE_ROTATION

### define %type% IDS_DISABLE_SHADOWS

### define %type% IDS_ENABLE_ROTATION

### define %type% IDS_ENABLE_SHADOWS

### define %type% IDS_ENHANCED_LIGHTING_WITH_SPECULAR_LIGHTING

### define %type% IDS_ENHANCED_LIGHTING_WITH_SPECULAR_LIGHTING_AND_SHADOWS

### define %type% IDS_ENHANCED_LIGHTING_WITHOUT_SPECULAR_LIGHTING

### define %type% IDS_FAST_PHOTOREALISM

### define %type% IDS_HEAVY_BRIGHTNESS_DISTANT_LIGHT

### define %type% IDS_HEAVY_BRIGHTNESS_NEAR_LIGHT

### define %type% IDS_INPUT_BOX_CANCEL_BUTTON_LABEL

### define %type% IDS_INPUT_BOX_OK_BUTTON_LABEL

### define %type% IDS_INPUT_BOX_TITLE

### define %type% IDS_LIGHT_BRIGHTNESS_DISTANT_LIGHT

### define %type% IDS_LIGHT_BRIGHTNESS_NEAR_LIGHT

### define %type% IDS_OBJECTVIEWER

### define %type% IDS_OBJECTVIEWER_PPG

### define %type% IDS_OBJECTVIEWER_PPG_CAPTION

### define %type% IDS_SAVE_MATERIALS

### define %type% IDS_SHOW_API_HELP

### define %type% IDS_STANDARD_LIGHTING

### define %type% IDS_STRING1

### define %type% IDS_STRING5

# file resource.h

## define

### define %type% IDC_BOX

### define %type% IDC_CATALOG

### define %type% IDC_CATALOGS

### define %type% IDC_CONTENTS

### define %type% IDC_DLL

### define %type% IDC_EDGES

### define %type% IDC_FACE_NORMALS

### define %type% IDC_FACE_TEXT

### define %type% IDC_IMPORT

### define %type% IDC_INFO

### define %type% IDC_LOOPS

### define %type% IDC_MATRIX

### define %type% IDC_MUSTER_LINIEN

### define %type% IDC_OBJ_ATTRIBS

### define %type% IDC_OBJECTS

### define %type% IDC_PATH

### define %type% IDC_PLUGINS

### define %type% IDC_POINTS

### define %type% IDC_PRIM_ATTRIBS

### define %type% IDC_PRIMITIVES

### define %type% IDC_PRODUCER

### define %type% IDC_RDL_SINGLESTEP

### define %type% IDC_REDOLOG

### define %type% IDC_UPDATE

### define %type% IDD_CATALOGS

### define %type% IDD_CONTENT

### define %type% IDD_DLL

### define %type% IDR_G3DKERNEL

### define %type% IDS_PROJNAME

# file StdAfx.cpp

%sectiondef%

# file StdAfx.cpp

%sectiondef%

# file StdAfx.h

## define

### define %type% VC_EXTRALEAN

# file StdAfx.h

## define

### define %type% _ATL_APARTMENT_THREADED

### define %type% _CRT_SECURE_NO_WARNINGS

### define %type% _WIN32_WINNT

### define %type% IDictionary

### define %type% STRICT

## var

### variable CComModule _Module

# file texture.cpp

## var

### variable CxImage g_helperImage

### variable COpenGLHelper g_openGLHelper

## func

### function RGBQUAD Blend1L2HS

### function RGBQUAD BlendBackgroundWithForeground

### function bool BlendImageAndColor

### function bool BlendImages

### function bool FileExists

### function int GetMapping

### function unsigned int NextPower2

### function void ResizeImage

### function bool TryGetRealDimensions

# file Texture.h

%sectiondef%

# file TexturePool.cpp

%sectiondef%

# file TexturePool.h

%sectiondef%

# file UserDocumentation.md

%sectiondef%

# page md_C:_Entwicklung_branches_B5010_P4_Source_chiemsee_Components_ObjectViewer_3DOCX

%sectiondef%

# page md_C:_Entwicklung_branches_B5010_P4_Source_chiemsee_Components_ObjectViewer_UserDocumentation

%sectiondef%

# dir C:/Entwicklung/branches/B5010/P4/Source/chiemsee/Components/3DEngine

%sectiondef%