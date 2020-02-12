dim PLMShare, PLM_ShortCut, PLM_Bin, PLM_Icon 

'____________________________
' PLMShare
Set oShell = CreateObject( "WScript.Shell" )
'PLMShare = oShell.ExpandEnvironmentStrings("%PLMSHARE%")
'PLMShare = "\\TC-TST02\PLMShare"
PLMShare = "\\TC-PROD02\PLMShare"
PLM_ShortCut = PLMShare & "\" & "PLM_Startup\Startups"
PLM_Bin      = PLMShare & "\" & "PLM_Startup\Startups\bin"
PLM_Icon     = PLMShare & "\" & "PLM_Startup\Startups\icons"


'____________________________
' TC NX Launch
dim NX_Select(3)
NX_Select(0) = PLM_ShortCut & "\" & "KMWE - Teamcenter.lnk"
NX_Select(1) = PLM_Bin & "\" & "TC_NX_Launch.exe"
NX_Select(2) = ""
NX_Select(3) = PLM_Icon & "\" & "TC_core.ico,0"

CreateShortCut(NX_Select)

'____________________________
' Native NX Launch
dim NX_Native(3)
NX_Native(0) = PLM_ShortCut & "\" & "KMWE - Native NX.lnk"
NX_Native(1) = PLM_Bin & "\" & "Native_NX_Launch.exe"
NX_Native(2) = ""
NX_Native(3) = PLM_Icon & "\" & "siemens_nx.ico,0"

CreateShortCut(NX_Native)

function CreateShortCut (Data())
	Set objShell = WScript.CreateObject("WScript.Shell")
	Set lnk = objShell.CreateShortcut(Data(0))
	
	lnk.TargetPath = Data(1)
	lnk.Arguments = Data(2)
	lnk.IconLocation = Data(3)
	lnk.WindowStyle = "1"
	lnk.WorkingDirectory = "%TEMP%"
	lnk.Save
	
	'Clean up 
	Set lnk = Nothing
end function

