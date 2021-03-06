; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "TextCorrect"
#define MyAppVersion "1.0"
#define MyAppExeName "TextCorrect.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E55CE4E4-13D0-405D-9FF4-444F456336C6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
; The [Icons] "quicklaunchicon" entry uses {userappdata} but its [Tasks] entry has a proper IsAdminInstallMode Check.
UsedUserAreasWarning=no
InfoBeforeFile=C:\MyProjects\TextCorrect\TextCorrect\bin\Release\README.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\Stefan\Desktop
OutputBaseFilename=TextCorrect Setup
SetupIconFile=C:\MyProjects\TextCorrect\TextCorrect\Resources\analytics.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\TextCorrect.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\Test - English.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\Test - Latin.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\Test -Cyrillic.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\TextCorrect.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\TextCorrect.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\TextCorrect.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MyProjects\TextCorrect\TextCorrect\bin\Release\README.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

