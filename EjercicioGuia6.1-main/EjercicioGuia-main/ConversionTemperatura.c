#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <fcntl.h>
#include <netinet/in.h>
#include <stdio.h>
float ConvertirCelsiusAFahrenheit(float temperatura){
	float resultado=(temperatura*9/5)+32;
	return resultado;
	
}
float ConventirFahrenheitACelcius(float temperatura){
	float resultado=(temperatura-32)*5/9;
	return resultado;
}
int main(int argc, char *argv[]) {
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];

	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		error("Error creant socket");
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); /* El fica IP local */
	//me conecto al puerto 9050
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		error("Error al bind");
	// Limitem el nombre de connexions pendents
	if (listen(sock_listen, 10) < 0)
		error("listen");
	int i;
	for (i=0;i<10;i++){
		printf("Escuchando \n");
		// acepto la conexion de un cliente
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("he recibido conexion \n");
		
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido \n");
		
		//Poner la marcar de fin de string
		peticion[ret]='\0';
		
		//Escribimos la peticion
		printf("Peticion: %s \n", peticion);
		
		char *p= strtok(peticion, "/");
		int codigo = atoi(p);
		if(codigo==1) {
			p=strtok(NULL, "/");
			float temperatura=atof(p);
			printf("Codigo: %d Temperatura: %f\n", codigo, temperatura);
			float resultado = ConvertirCelsiusAFahrenheit(temperatura);
			char respuesta[20];
			printf("Tempetatura en Fahrenheit: %f\n", resultado);
			sprintf(respuesta, "%f", resultado);
			write(sock_conn, respuesta, strlen(respuesta));
		}
		
		if(codigo==2){
			p=strtok(NULL, "/");
			float temperatura=atof(p);
			printf("Codigo: %d Temperatura: %f \n", codigo, temperatura);
			float resultado= ConventirFahrenheitACelcius(temperatura);
			char respuesta[20];
			printf("Temperatura en Celcius: %f\n", resultado);
			sprintf(respuesta, "%f", resultado);
			write(sock_conn, respuesta, strlen(respuesta));
		}
	}	close(sock_conn); // Necessari per a que el client detecti EOF 
}

