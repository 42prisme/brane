Docker:
sudo docker run --name mysql_brane -p 3306:3306 -e MYSQL_DATABASE=brane -e MYSQL_USER=brane_admin -e MYSQL_PASSWORD=password -e MYSQL_RANDOM_ROOT_PASSWORD=yes -d mysql
sudo docker start mysql_brane 