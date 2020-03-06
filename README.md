## WordPress subdomain port 80 .htaccess
```.htaccess
# Custom subdomain .htaccess port 80 WordPress

RewriteEngine on
RewriteCond %{HTTP_HOST} ^www.wordpress.wp.com$ [NC,OR]
RewriteCond %{HTTP_HOST} ^www.wordpress.wp.com$ 
RewriteCond %{REQUEST_URI} !wordpress/
RewriteRule (.*) /wordpress/$1 [L]

# End custom subdomain .htaccess port 80 WordPress
```
## WordPress subdomain port 8080 .htaccess
```.htaccess
# Custom subdomain .htaccess port 8080 WordPress

RewriteEngine On
RewriteCond %{SERVER_PORT} 8080
RewriteCond %{REQUEST_URI} !wordpress/
RewriteRule ^(.*)$ http://www.wordpress.wp.com:%{SERVER_PORT}/wordpress/$1 [R,L]

# End custom subdomain .htaccess port 8080 WordPress
```
***
## WordPress SSL + subdomain .htaccess
```.htaccess
# BEGIN HTTPS
<IfModule mod_rewrite.c>
RewriteEngine On
RewriteCond %{HTTPS} off
RewriteRule ^(.*)$ https://%{HTTP_HOST}%{REQUEST_URI} [L,R=301]
</IfModule>
# END HTTPS
```
***
## WordPress SSL + subdomain + maindomain .htaccess
```.htaccess
# Custom subdomain .htaccess SSL + WordPress
RewriteEngine On
RewriteCond %{HTTP_HOST} ^subdomain.maindomain.com$
RewriteCond %{REQUEST_URI} !^/subfolder/
RewriteRule ^(.*)$ /subfolder/$1
RewriteCond %{HTTP_HOST} ^subdomain.maindomain.com$
RewriteRule ^(/)?$ subfolder/index.php [L]
# End custom subdomain .htaccess

# Custom maindomain .htaccess WordPress
RewriteEngine On
RewriteBase /
RewriteCond %{HTTP_HOST} ^(www.)?maindomain.com$
RewriteRule ^index\.php$ - [L]
RewriteCond %{HTTP_HOST} ^(www.)?maindomain.com$
RewriteCond %{REQUEST_FILENAME} !-f
RewriteCond %{REQUEST_FILENAME} !-d
RewriteRule . /index.php [L]
# End custom maindomain .htaccess
```
***



***
## unBlock Windows Problem Fix Apache Server
### How to Solve Port 80 Problems When Running Apache 
#### ``How to fix Apache server error (Windows) | How to fix "Apache is not running" ``

<!-- ###### Fix unblock port:[80] on windows run Apache -->
***
## Windows Command Processor

```cmd
C:\Windows\System32\cmd.exe
```


## Fix unBlock Port:[80] on Windows Run Apache

``net stop was /y``

``net start was /y``

[Fix unblock port:[80] on windows run Apache](https://www.sitepoint.com/unblock-port-80-on-windows-run-apache/)
