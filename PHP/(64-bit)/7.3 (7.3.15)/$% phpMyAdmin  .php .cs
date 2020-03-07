

E:\ComposerDirectory\ComposerDirectory\Directory\mysql-8.0\bin\mysqld --initialize-insecure --user=root
E:\ComposerDirectory\ComposerDirectory\Directory\mysql-8.0\bin\mysqld --install
net start mysql

MySQL's my.ini
bind-address = 127.0.0.1


# Configure phpMyAdmin
# http://docs.phpmyadmin.net/en/latest/config.html



$cfg['Servers'][$i]['host'] = 'localhost';
$cfg['Servers'][$i]['user'] = 'root';
$cfg['DefaultLang'] = 'ar';


########################################


$cfg['TempDir'] = 'C:/WampDeveloper/Temp';
$cfg['Servers'][$i]['auth_type'] = 'http';
$cfg['Servers'][$i]['host'] = '127.0.0.1';


# $cfg['Servers'][$i]['AllowNoPassword'] = true;
# $cfg['NavigationTreeEnableGrouping'] = false;






my.ini file



C:\Server\bin\mysql-8.0\bin\mysqld --initialize-insecure --user=root
C:\Server\bin\mysql-8.0\bin\mysqld --install
net start mysql
c:\Server\bin\mysql-8.0\bin\mysqld --remove


phpmyadmin

