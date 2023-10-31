#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <fcntl.h>
#include <netinet/in.h>
#include <stdio.h>

int Nombre_Palindro(char Nombre[20]){
	int PrimeraLetra = 0;
	int UltimaLetra =strlen(Nombre)-1;
	int i;
	for(i=0;i<strlen(Nombre);i++){
		if (tolower(Nombre[PrimeraLetra])!=tolower(Nombre[UltimaLetra]))
			return 0;
	    else{
		PrimeraLetra++;
		UltimaLetra--;
		return 1;
		}
		
	}
}

void convertirMayusculas(char Nombre[20]){
		int i = 0;
		while (Nombre[i]) {
			Nombre[i] = toupper(Nombre[i]);
			i++;
		}
	}


int main(int argc, char *argv[]) {
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta [512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		error("Error creant socket");
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); /* El fica IP local */
	//me conecto al puerto 9050
	serv_adr.sin_port = htons(9051);
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
		
		
	
	if (codigo==1)// Te determina si tu nombre es Palindro y si es asi te lo devuelve en mayusculas
	{
		char respuesta[20];
		p=strtok(NULL, "/");
		char nombre[20];
		strcpy(nombre, p);
		printf("Codigo: %d Nombre: %s\n", codigo, nombre);
	
	if(Nombre_Palindro(nombre)==0){
		printf("El nombre no es Palindro \n");
		strcpy(respuesta,"NO");
	}
	else{
		convertirMayusculas(nombre);//Al ser el nombre Palindro te lo devuelve en mayusculas
		printf("El nombre %s es palindro \n", nombre);
		strcpy(respuesta, nombre);
	}
	write( sock_conn, respuesta, strlen(respuesta));
	}
	close(sock_conn); // Necessari per a que el client detecti EOF 
	
	}

	
    
}

