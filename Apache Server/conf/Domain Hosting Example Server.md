***
# Domain Hosting Example Server
***
***


### Apache24 New Add Good PHP 7.3

```httpd.conf
LoadModule php7_module "E:/ComposerDirectory/ComposerDirectory/PHP 7.3.5 (64-bit)/php7apache2_4.dll"

PHPIniDir "E:/ComposerDirectory/ComposerDirectory/PHP 7.3.5 (64-bit)/"
```


# phpMyAdmin - Error - The mysqli extension & php v7.4
```httpd.conf
#PHPIniDir "C:/Apache24/PHP/" #PHP v7.4
#LoadModule php7_module "C:/Apache24/PHP/php7apache2_4.dll"

```

***
## New Good httpd.conf
***

```httpd.conf


<VirtualHost *:80>
    ServerAdmin admin@localhost
    ServerAlias SamplePhpMyAdmin.com

	ServerName SamplePhpMyAdmin.com
    DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin"

    
	#UseCanonicalName Off
  	
   	 # SSLCertificateFile "C:/Users/Credit/Documents/#Server(htdocs)(www)/SSL/crt/SamplePhpMyAdmin.com.crt"
	 # SSLCertificateKeyFile "C:/Users/Credit/Documents/#Server(htdocs)(www)/SSL/key/SamplePhpMyAdmin.com.key"
	
	<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin">
    
    
	SSLOptions +StdEnvVars
	
    Options Indexes FollowSymLinks MultiViews
    AllowOverride All
	
    #Order Deny,Allow
    #Deny from all
    #Allow from 127.0.0.1 localhost ::1
	
</Directory>
</VirtualHost>

```
***
# Old httpd.conf Error
***

```httpd.conf
#<VirtualHost *:8080>
    #ServerAdmin admin@localhost
    #ServerName SamplePhpMyAdmin.com 
    #ServerAlias SamplePhpMyAdmin.com
    #DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin"
   
    #SSLCertificateFile "C:/wamp/bin/apache/apache2.4.9/conf/key/certificate.crt"
	#SSLCertificateKeyFile "C:/wamp/bin/apache/apache2.4.9/conf/key/private.key"
#</VirtualHost>


#<VirtualHost *:8080>
    #ServerAdmin admin@localhost
    #ServerName SamplePhpMyAdmin.com 
    #ServerAlias SamplePhpMyAdmin.com
    #DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)/phpMyAdmin"

    #UseCanonicalName Off
	
    #ErrorLog "C:/Apache24/logs/ssl_error.log"
	#TransferLog "C:/Apache24/logs/ssl_access.log"


	#SSLCertificateFile "C:/Apache24/conf/key/certificate.crt"
	#SSLCertificateKeyFile "C:/Apache24/conf/key/private.key"
	
	
#<Directory "/phpMyAdmin">

#Options -Indexes FollowSymLinks ExecCGI
#AllowOverride None
#Order allow,deny

#Allow from all

#</Directory>
#</VirtualHost>




#openssl genrsa -out SamplePhpMyAdmin.com.key 2048
#openssl req -new -sha256 -key SamplePhpMyAdmin.com.key -out SamplePhpMyAdmin.com.csr
#openssl req -text -in SamplePhpMyAdmin.com.csr -noout


#openssl.exe genrsa 2048 > SamplePhpMyAdmin.com.key

# Default openssl.cnf
#openssl.exe req -new -key SamplePhpMyAdmin.com.key > SamplePhpMyAdmin.com.csr

#openssl rsa -in SamplePhpMyAdmin.com.pem -out SamplePhpMyAdmin.com.key
#openssl x509 -in SamplePhpMyAdmin.com.csr -out SamplePhpMyAdmin.com.crt -req -signkey SamplePhpMyAdmin.com.key -days 365



################################################################################

#openssl.cnf

################################################################################

#openssl.exe req -new -key SamplePhpMyAdmin.com.key -config "openssl.cnf" -out SamplePhpMyAdmin.com.csr

################################################################################

#openssl req -config "C:\openssl.cnf" -new -out SamplePhpMyAdmin.com.csr -keyout SamplePhpMyAdmin.com.pem

################################################################################


```
***
