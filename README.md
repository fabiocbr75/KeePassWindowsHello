# KeePassWindowsHello

- Keepass v2.48 x86 windows hello plugin.

# Technology used:

  - Using Windows Hello with new Windows Runtimer library (No UWP Desktop Bride needed)
  - DPAPI to crypt\encrypt encrypt sensitive data

# Compile & Install:

In order to compile you have to use Visual Studio 2019 Comunity Edition.
The binary produced works only with the Keepass version used as reference and present on "ext" folder.

To install on Keepass, you have to copy the following files into "KeePass Password Safe 2\Plugins" folder:
  - FingerprintPlugin.dll
  - Newtonsoft.Json.dll

# Use:

The first time open the keepass database with MasterPassword. 
Now on Tools Menù is present a new item "Fingerprint".
After you select fingerprint a new window is opened.
Set the MasterPassword on the textbox.
The password is saved locally crypted with DPAPI in AppData\Roaming\KeePassWindowsHelloPlugin\DbMasterKey.dat.

Now when you open Keepass you have to deselect MasterPassword checkbox and select "Key File" with "Fingerprint Key Provider" as provider.
