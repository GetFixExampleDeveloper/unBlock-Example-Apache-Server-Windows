
***
## httpd.conf Virtual Host
***
```httpd.conf

Listen 80

<VirtualHost *:80>
	ServerName localhost

	ServerAlias localhost
    ServerAdmin admin@localhost

    #localhost
	
    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/"	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/">
 
	#SSLOptions +StdEnvVars	
    #Options Indexes FollowSymLinks MultiViews
	
	
    AllowOverride All
    
	
	

</Directory>

<IfModule dir_module>
    
	DirectoryIndex index.php index.html index.shtml
    DirectoryIndex HomeServer.html	
  # DirectoryIndex
  # DirectoryIndex
  # DirectoryIndex public install installer

</IfModule>

ErrorDocument 500 /500.html
ErrorDocument 404 /404.html
ErrorDocument 403 /403.html


</VirtualHost>


#<VirtualHost *:8000>

#	ServerName HomePremiumSampleTube.server.tv
#	ServerAlias HomePremiumSampleTube.server.tv
#   ServerAdmin admin@HomePremiumSampleTube.server.tv

		
#    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSampleTube/"	
#	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSampleTube/">
        
#	SSLOptions +StdEnvVars
	
#    Options Indexes FollowSymLinks MultiViews
#    AllowOverride All


#</Directory>
#</VirtualHost>

<VirtualHost *:80>
	ServerName SampleMTDBNew.com

	ServerAlias SampleMTDBNew.com
    ServerAdmin admin@localhost

    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/mtdb"	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/mtdb">
        
	#SSLOptions +StdEnvVars	
    #Options Indexes FollowSymLinks MultiViews
	
    AllowOverride All


</Directory>
</VirtualHost>

<VirtualHost *:80>
	
	ServerName HomePremiumSample.com

	ServerAlias HomePremiumSample.com
    ServerAdmin admin@HomePremiumSample.com
	
    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSample"	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSample">
        
	#SSLOptions +StdEnvVars	
    #Options Indexes FollowSymLinks MultiViews
	
    AllowOverride All

</Directory>
</VirtualHost>


<VirtualHost *:80>
	ServerName HomePremiumSampleTube.server.tv

	ServerAlias HomePremiumSampleTube.server.tv
    ServerAdmin admin@HomePremiumSampleTube.server.tv

		
    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSampleTube"	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/HomePremiumSampleTube">
        
	#SSLOptions +StdEnvVars	
    #Options Indexes FollowSymLinks MultiViews
	
    AllowOverride All


</Directory>
</VirtualHost>


<VirtualHost *:80>
    ServerAdmin root@localhost
    ServerAlias SamplePhpMyAdmin.com

	ServerName SamplePhpMyAdmin.com
    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin"

    
	#UseCanonicalName Off
  	
   	 # SSLCertificateFile "C:/Users/Credit/Documents/#Server(htdocs)(www)/SSL/crt/SamplePhpMyAdmin.com.crt"
	 # SSLCertificateKeyFile "C:/Users/Credit/Documents/#Server(htdocs)(www)/SSL/key/SamplePhpMyAdmin.com.key"
	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin">
    	
	#SSLOptions +StdEnvVars	
    #Options Indexes FollowSymLinks MultiViews
	
    AllowOverride All
	
	
</Directory>
</VirtualHost>

```
***
#### C:\Windows\System32\drivers\etc\hosts
***
```hosts
# Copyright (c) 1993-2009 Microsoft Corp.
#
# This is a sample HOSTS file used by Microsoft TCP/IP for Windows provided by MajorGeeks.Com
#
# This file contains the mappings of IP addresses to host names. Each
# entry should be kept on an individual line. The IP address should
# be placed in the first column followed by the corresponding host name.
# The IP address and the host name should be separated by at least one
# space.
#
# Additionally, comments (such as these) may be inserted on individual
# lines or following the machine name denoted by a '#' symbol.
#
# For example:
#
#      102.54.94.97     rhino.acme.com          # source server
#       38.25.63.10     x.acme.com              # x client host

# localhost name resolution is handled within DNS itself.
#	127.0.0.1       localhost
#	::1             localhost

# FTP Manager Server
# Manager Server

127.0.0.1       SamplePhpMyAdmin.com
127.0.0.1       Directoryserverpages.com

# Home Servers Sample

127.0.0.1       HomePremiumSample.com
127.0.0.1       HomePremiumSampleTube.server.tv

# Sample Manager Server

127.0.0.1       www.SampleEmailAddresses.net
127.0.0.1       www.Sample-MTDB.Ultimate.com


# www Manager Server

127.0.0.1       www.ManagerServer.com
127.0.0.1       www.ExampleServerRoot.com
127.0.0.1       www.DomainHosting.Manager.com
127.0.0.1       www.ServerSourceAddress.com

```
