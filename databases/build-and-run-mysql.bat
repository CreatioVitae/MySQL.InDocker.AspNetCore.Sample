@echo build mysql...image name is localmysql
docker build -t localmysql MySql

@echo run mysql... @port: 11101 
docker run -p 11101:3306 --name localmysql -d localmysql

pause