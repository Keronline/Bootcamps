#include <stdio.h>
#define INDICE 13 

int Soma(){
  int SOMA = 0, K = 0;
  while( K < INDICE){
      K = K + 1;
      SOMA = SOMA + K;
  }
  return(SOMA);
}

int main(void) {
  printf("O valor da soma e: %d\n", Soma());
  return 0;
}

//Seria possível utilizar a fórmula K(K+1)/2 para carcular a soma da sequência que vai de 1 até 13
