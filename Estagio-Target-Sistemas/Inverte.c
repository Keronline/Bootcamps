#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void inverte(char * v, int n){
  if(n == 1){ 
    char a[] = "A persistencia e o caminho do exito.";
    v = a;
    printf("\n");
    for(int i = 0; i < 40; i++){
      printf("%c", v[i]);    
    }
  } 
  else{
    printf("Digite a frase a ser invertida (máximo de 45 caracteres):\n\n");
    getchar();
    fgets(v, 45, stdin);
  } 
  printf("\n");

  for(int i = strlen(v); i > -1; i--){
      printf("%c", v[i]);
  }
}

int main(void) {
  char v[46];
  int n = 0;
  do{

    printf("Voce deseja: \n\nEscrever o que será invertido: aperte 0\n\nInverter frase previamente definida: aperte 1\n\n");
    scanf("%d", &n);

  }while(n != 1 && n != 0);
  
  inverte(v, n);

  return 0;
}
