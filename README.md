# TinyEvil
TinyEvil 1.0.1 - Full Source Code
# Requirements
- Visual Studio
- .NET Framework 4
<pre>

    $$$$$$\     $$$$$$$\                                          $$\                         
  $$$ ___$$$\   $$  __$$\                                         \__|                        
 $$ _/   \_$$\  $$ |  $$ |$$\   $$\ $$$$$$$\   $$$$$$$\  $$$$$$\  $$\ $$$$$$\$$$$\   $$$$$$\  
$$ / $$$$$\ $$\ $$$$$$$  |$$ |  $$ |$$  __$$\ $$  _____|$$  __$$\ $$ |$$  _$$  _$$\ $$  __$$\ 
$$ |$$  $$ |$$ |$$  __$$< $$ |  $$ |$$ |  $$ |$$ /      $$ |  \__|$$ |$$ / $$ / $$ |$$$$$$$$ |
$$ |$$ /$$ |$$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |      $$ |      $$ |$$ | $$ | $$ |$$   ____|
$$ |\$$$$$$$$  |$$ |  $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$\ $$ |      $$ |$$ | $$ | $$ |\$$$$$$$\ 
\$$\ \________/ \__|  \__| \______/ \__|  \__| \_______|\__|      \__|\__| \__| \__| \_______|
 \$$$\   $$$\                                                                                 
  \_$$$$$$  _|                                                                                
    \______/                                                                                  

        Analysis by: bfalk escobark
                For: <redacted>
                     30.03.23

Target Info
{
	|- Name			  : "Tiny Evil Ransomware"
	|- Runtime		  : .NET/CIL (JIT)
	  |- Version	  : .NET Framework 4.5
	  |- Language	  : C#
	  |- Architecture : AnyCPU (x86 preferred)
	  |- Timestamp	  : 5E9566BF (04/14/2020 8:31:11 AM)
	
	|- Protectors:
	  |- .NET Reactor (4.8 - 4.9)
}

License
{
	|- Domain: "http://cr4ckz.coolpage.biz/"
	
	|- Key
	  |- Generation: Randomly-Generated ("ABCDEFKLMNOPQRSTUVWXYZ1234567890")
	  |- Pattern   : XXXX-XXXX-XXXX-XXXX-XXXX
	  |- Length	   : 20
	  
	|- ID
	  |- Generation: SHA256 Hash of 'Key + "VIN_IS_THE_BEST"' as string (hex/"X2" formating)
	  |- Length	   : 47
	
	|- Checking Methods
	  |- "LicenseCheker" (Core.dll)
	    |- RID  : 8
	    |- RVA  : 0x000024A8
	    |- Token: 0x06000008
	    
	    |- Return Type: System.String
	    
	    |- Process:
	    {
	    	|- Download response of
	    	  |- domain + "realtime_check.php?id=" + id + "&hwid=" + hwid
	    	  |- "http://cr4ckz.coolpage.biz/realtime_check.php?id=%id%&hwid=%hwid%"
	    	  
	    	|- Return response
	    	
	    	|- Known responses:
	    	  |- "YES"
	    	  |- "NO"
	    }
	    
	  |- "IsLicenseValid" (Core.dll)
	    |- RID  : 5
	    |- RVA  : 0x000023AC
	    |- Token: 0x06000005
	    
	    |- Return Type: System.Boolean
	    
	    |- Process:
	    {
	    	|- Call "IsHashValid"   (Core.dll, RID: 9)
	    	|- Call "VerifyLicense" (Core.dll, RID: 6)
	    	
	    	|- Return value depending
	    	  |- on call response (if 1 false, return false)
	    }
	    
	  |- "VerifyLicense" (Core.dll)
	    |- RID  : 6
	    |- RVA  : 0x000023E0
	    |- Token: 0x06000006
	    
	    |- Return Type: System.Boolean
	    
	    |- Process:
	    {
	    	|- Download response of
	    	  |- domain + "verify.php?id=" + id + "&username=" + Environment.Username + "&computer=" + Environment.MachineName + "&os=" + Environment.OSVersion + "&hwid=" + hwid
	    	  |- "http://cr4ckz.coolpage.biz/verify.php?id=%id%&username=%loggedInUser%&computer=%computerName%&os=%OSVersion%&hwid=%hwid%"
	    	  
	    	|- If response
	    	  |- is "Yes"
	    	    |- return true
	    }
	    
	  |- "IsHashValid" (Core.dll)
		|- RID  : 9
		|- RVA  : 0x00002514
		|- Token: 0x06000009
		
		|- Return Type: System.Boolean
		
		|- Process
		{
			|- If id
		      |- is 'GenerateID(key)' (SHA256 Hash of 'Key + "VIN_IS_THE_BEST"' as string (hex/"X2" formating)
		        |- return true
		}
		
	  |- "button1_Click" (Builder.exe)
	    |- RID  :   2
	    |- RVA  : 0x000023E4
	    |- Token: 0x06000002
	    
	    |- Process
	    {
	    	|- Call "IsLicenseValid" (Core.dll, RID:5, see line 71)
	    	  |- Arguments
	    	    |- "ID":  textbox1.Text
	    	    |- "Key": textbox2.Text
	    	    
	    	|- if call
	    	  |- returns true
	    	    |- Write 'textbox1.Text' 
	    	    |- to registry
	    	      |- at "HKLM\SOFTWARE\lolihunter" 
	    	      |- as"ID"
	    	|- else
	    	  |- Display Message Box "Your license is not valid!"
	    }
}

Cryptography
{
	|- "privkey.dat" (File)
	  |- Type: RSA (Private Key)
	  |- Process
	  {
	    |- Base64 Encode 'new RSA().ToXml(includePrivateParameters=true)'
	  }
	  
	|- "pubkey.dat" (File)
	  |- Type: RSA (Public Key)
      |- Process
	  {
	    |- Base64 Encode 'new RSA().ToXml(includePrivateParameters=false)'
	  }
	
	|- "DecryptFile" (Builder.exe)
	  |- RID:   16
	  |- RVA:   0x00002DC0
	  |- Token: 0x06000010
	  
	  |- Return Type: System.Byte[]
	  
	  |- Type: Rijndael (Rfc2898, CBC)
	  |- Size
	    |- Key  : 256
	    |- Block: 128
	  
	  |- Key: 'privkey.dat'
	  |- Salt: { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
	  |- Iteration Count: 1000
	
	|- "EncryptFile" (stub.dat)
	  |- RID:   1
	  |- RVA:   0x00002360
	  |- Token: 0x06000001
	  
	  |- Return Type: System.Byte[]
	  
	  |- Type: Rijndael (Rfc2898, CBC)
	  |- Size
	    |- Key  : 256
	    |- Block: 128
	  
	  |- Key: 'privkey.dat'
	  |- Salt: { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
	  |- Iteration Count: 1000
}

Identifiable Information
{
	|- HWID: (Registry)
	  |- Value of "MachineGuid" at "HKLM\Software\Microsoft\Cryptography"
	|- Environment
	  |- OS Version
	  |- 'Current user' Name
	  |- Machine Name
}

Ransomware
{
    |- "_README.txt"
    {
    	============================ ALL YOUR FILES ARE ENCRYPTED ============================
		
		Don't worry, you can return all your files!
		
		All your files document, photos, databases and other important are encrypted with strongest encryption and unique key.
		
		The only method of recovering files is to purchase unique key for you.
		That will decrypt all your encrypted files
		Price of private key is $%price%
		
		What guarantees do we give to you?
		
		You can send one of your encrypted file from your pc and we decrypt it for free.
		But we can decrypt only 1 file for free. File must not contain valuable information
		Don't try to use third-party decrypt tools because it will destroy your files.
		--------------------------------------------------------------------------------------
		
		To get this private key you need write on our email :
		Email address to contact us : %email%
		Your personal ID : %id%
    }
	|- Targets:
	{
		"1cd", ".3dm", ".3ds", ".3fr", ".3g2", ".3gp", ".3pr", ".7z", ".7zip", ".aac",
		".ab4", ".abd", ".acc", ".accdb", ".accde", ".accdr", ".accdt", ".ach", ".acr", ".act",
		".adb", ".adp", ".ads", ".agdl", ".ai", ".aiff", ".ait", ".al", ".aoi", ".apj",
		".apk", ".arw", ".ascx", ".asf", ".asm", ".asp", ".aspx", ".asset", ".asx", ".atb",
		".avi", ".awg", ".back", ".backup", ".backupdb", ".bak", ".bank", ".bay", ".bdb", ".bgt",
		".bik", ".bin", ".bkp", ".blend", ".bmp", ".bpw", ".bsa", ".c", ".cash", ".cdb",
		".cdf", ".cdr", ".cdr3", ".cdr4", ".cdr5", ".cdr6", ".cdrw", ".cdx", ".ce1", ".ce2",
		".cer", ".cfg", ".cfn", ".cgm", ".cib", ".class", ".cls", ".cmt", ".config", ".contact",
		".cpi", ".cpp", ".cr2", ".craw", ".crt", ".crw", ".cry", ".cs", ".csh", ".csl",
		".css", ".csv", ".d3dbsp", ".dac", ".das", ".dat", ".db", ".db_journal", ".db3", ".dbf",
		".dbx", ".dc2", ".dcr", ".dcs", ".ddd", ".ddoc", ".ddrw", ".dds", ".def", ".der",
		".des", ".design", ".dgc", ".dgn", ".dit", ".djvu", ".dng", ".doc", ".docm", ".docx",
		".dot", ".dotm", ".dotx", ".drf", ".drw", ".dtd", ".dwg", ".dxb", ".dxf", ".dxg",
		".edb", ".eml", ".eps", ".erbsql", ".erf", ".exf", ".fdb", ".ffd", ".fff", ".fh",
		".fhd", ".fla", ".flac", ".flb", ".flf", ".flv", ".flvv", ".forge", ".fpx", ".fxg",
		".gbr", ".gho", ".gif", ".gray", ".grey", ".groups", ".gry", ".h", ".hbk", ".hdd",
		".hpp", ".html", ".ibank", ".ibd", ".ibz", ".idx", ".iif", ".iiq", ".incpas", ".indd",
		".info", ".info_", ".ini", ".iwi", ".jar", ".java", ".jnt", ".jpe", ".jpeg", ".jpg",
		".js", ".json", ".k2p", ".kc2", ".kdbx", ".kdc", ".key", ".kpdx", ".kwm", ".laccdb",
		".lbf", ".lck", ".ldf", ".lit", ".litemod", ".litesql", ".lock", ".log", ".ltx", ".lua",
		".m", ".m2ts", ".m3u", ".m4a", ".m4p", ".m4v", ".ma", ".mab", ".mapimail", ".max",
		".mbx", ".md", ".mdb", ".mdc", ".mdf", ".mef", ".mfw", ".mid", ".mkv", ".mlb",
		".mmw", ".mny", ".money", ".moneywell", ".mos", ".mov", ".mp3", ".mp4", ".mpeg", ".mpg",
		".mrw", ".msf", ".msg", ".myd", ".nd", ".ndd", ".ndf", ".nef", ".nk2", ".nop",
		".nrw", ".ns2", ".ns3", ".ns4", ".nsd", ".nsf", ".nsg", ".nsh", ".nvram", ".nwb",
		".nx2", ".nxl", ".nyf", ".oab", ".obj", ".odb", ".odc", ".odf", ".odg", ".odm",
		".odp", ".ods", ".odt", ".ogg", ".oil", ".omg", ".one", ".orf", ".ost", ".otg",
		".oth", ".otp", ".ots", ".ott", ".p12", ".p7b", ".p7c", ".pab", ".pages", ".pas",
		".pat", ".pbf", ".pcd", ".pct", ".pdb", ".pdd", ".pdf", ".pef", ".pem", ".pfx",
		".php", ".pif", ".pl", ".plc", ".plus_muhd", ".pm!", ".pm", ".pmi", ".pmj", ".pml",
		".pmm", ".pmo", ".pmr", ".pnc", ".pnd", ".png", ".pnx", ".pot", ".potm", ".potx",
		".ppam", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prf", ".private", ".ps",
		".psafe3", ".psd", ".pspimage", ".pst", ".ptx", ".pub", ".pwm", ".py", ".qba", ".qbb",
		".qbm", ".qbr", ".qbw", ".qbx", ".qby", ".qcow", ".qcow2", ".qed", ".qtb", ".r3d",
		".raf", ".rar", ".rat", ".raw", ".rdb", ".re4", ".rm", ".rtf", ".rvt", ".rw2",
		".rwl", ".rwz", ".s3db", ".safe", ".sas7bdat", ".sav", ".save", ".say", ".sd0", ".sda",
		".sdb", ".sdf", ".sh", ".sldm", ".sldx", ".slm", ".sql", ".sqlite", ".sqlite3", ".sqlitedb",
		".sqlite-shm", ".sqlite-wal", ".sr2", ".srb", ".srf", ".srs", ".srt", ".srw", ".st4", ".st5",
		".st6", ".st7", ".st8", ".stc", ".std", ".sti", ".stl", ".stm", ".stw", ".stx",
		".svg", ".swf", ".sxc", ".sxd", ".sxg", ".sxi", ".sxm", ".sxw", ".tax", ".tbb",
		".tbk", ".tbn", ".tex", ".tga", ".thm", ".tif", ".tiff", ".tlg", ".tlx", ".txt",
		".upk", ".usr", ".vbox", ".vdi", ".vhd", ".vhdx", ".vmdk", ".vmsd", ".vmx", ".vmxf",
		".vob", ".vpd", ".vsd", ".wab", ".wad", ".wallet", ".war", ".wav", ".wb2", ".wma",
		".wmf", ".wmv", ".wpd", ".wps", ".x11", ".x3f", ".xis", ".xla", ".xlam", ".xlk",
		".xlm", ".xlr", ".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".xltm", ".xltx", ".xlw",
		".xml", ".xps", ".xxx", ".ycbcra", ".yuv", ".zip"
	}
	|- Process
	{
		|- For each file in currentPath
		  |- if file matches targetted extensions (see 'Targets', line 181)
		    |- Encrypt file
		      |- Using "EncryptFile" (RID: 1, see line 168)
		        |- Arguments
		          |- Key: Randomly-Generated set of characters (length: 10, pattern: "abcdefghijklmnopKLMNOPQRSTUVWXYZ1234567890")
		    |- adds "." + email
		      |- at the end of the file      
		    |- Rename file to "tinyEvil.dat"
		    
		  |- Creates '_README.txt' to every directory (see line 200)
		  |- If currentPath 
		    |- has folders
			  |- Repeat Process
	}
}
</pre>
