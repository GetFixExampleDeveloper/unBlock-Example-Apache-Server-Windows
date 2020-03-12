***
# Domain Hosting Example Server
***



# Apache24 New Add Good PHP 7.3
***
```httpd.conf
LoadModule php7_module "E:/ComposerDirectory/ComposerDirectory/PHP 7.3.5 (64-bit)/php7apache2_4.dll"

PHPIniDir "E:/ComposerDirectory/ComposerDirectory/PHP 7.3.5 (64-bit)/"
```

***
## phpMyAdmin - Error - The mysqli extension & php v7.4
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


```
DocumentRoot "C:/Users/Credit/Documents/#Server(htdocs)(www)"
<Directory "C:/Users/Credit/Documents/#Server(htdocs)(www)">

    #
    # Possible values for the Options directive are "None", "All",
    # or any combination of:
    #   Indexes Includes FollowSymLinks SymLinksifOwnerMatch ExecCGI MultiViews
    #
    # Note that "MultiViews" must be named *explicitly* --- "Options All"
    # doesn't give it to you.
    #
    # The Options directive is both complicated and important.  Please see
    # http://httpd.apache.org/docs/2.4/mod/core.html#options
    # for more information.
    #
    # Options Indexes FollowSymLinks
	
    Options All Indexes FollowSymLinks ExecCGI

    #
    # AllowOverride controls what directives may be placed in .htaccess files.
    # It can be "All", "None", or any combination of the keywords:
    #   AllowOverride FileInfo AuthConfig Limit
    #

    # AllowOverride None
     
     AllowOverride All


    #
    # Controls who can get stuff from this server.
    #
    Require all granted
</Directory>

```

***

```

<IfModule mime_module>
    #
    # TypesConfig points to the file containing the list of mappings from
    # filename extension to MIME-type.
    #
    TypesConfig conf/mime.types

    #
    # AddType allows you to add to or override the MIME configuration
    # file specified in TypesConfig for specific file types.
    #
    AddType application/x-gzip .tgz
    #
    # AddEncoding allows you to have certain browsers uncompress
    # information on the fly. Note: Not all browsers support this.
    #
    AddEncoding x-compress .Z
    AddEncoding x-gzip .gz .tgz
    #
    # If the AddEncoding directives above are commented-out, then you
    # probably should define those extensions to indicate media types:
    #
    AddType application/x-compress .Z
    AddType application/x-gzip .gz .tgz

    #
    # AddHandler allows you to map certain file extensions to "handlers":
    # actions unrelated to filetype. These can be either built into the server
    # or added with the Action directive (see below)
    #
    # To use CGI scripts outside of ScriptAliased directories:
    # (You will also need to add "ExecCGI" to the "Options" directive.)
    #
    AddHandler cgi-script .cgi

    AddHandler cgi-script .pl

    # For type maps (negotiated resources):
    AddHandler type-map var

    #
    # Filters allow you to process content before it is sent to the client.
    #
    # To parse .shtml files for server-side includes (SSI):
    # (You will also need to add "Includes" to the "Options" directive.)
    #
    #AddType text/html .shtml
    #AddOutputFilter INCLUDES .shtml
	
	AddType application/x-httpd-php .php 
</IfModule>

```

