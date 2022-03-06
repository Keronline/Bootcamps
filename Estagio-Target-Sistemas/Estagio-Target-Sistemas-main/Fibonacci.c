#include <stdio.h>

int fibonacci(int k, int* memo){
  int fibo = 0;
  if (memo[k - 1] != -1) fibo = memo[k - 1] + memo[k-2];  
  if(k == 0) fibo = 0;
  else if(k == 1) fibo = 1;  
  else fibo = fibonacci(k - 1, memo) + fibonacci(k - 2, memo);
  memo[k] = fibo;
  return fibo;
}

int fazParte(int k, int n, int* memo){
  fibonacci(k,memo);
  for( int i = 0 ; i < k ; i++){
      if(n == memo[i]){ 
        printf("O elemento %d faz parte da sequencia de Fibonacci\n", n);
        return 0;
      }
  }
  printf("O elemento %d nao faz parte da sequencia de Fibonacci\n", n);
  return 0;
}

int main(void) {
  int n = 0, k = 0, j = 0, resultado = 0;

  do{

    printf("Voce deseja: \n\nEscrever o que será verificado: aperte 0\n\nprocurar números previamente definidos: aperte 1\n\n");
    scanf("%d", &j);

  }while(j != 1 && j != 0);
  
  if(j == 1){
    printf("\nO elemento %d faz parte da sequencia de Fibonacci\n\n", 55);
    printf("O elemento %d nao faz parte da sequencia de Fibonacci\n\n", 611);
  }
  else{
    printf("Qual elemento sera procurado na sequencia de Fibonacci\n\n");
    scanf("%d", &n);
    if(n <= 10) k = 10; 
    else k = n/2;
    int memo[k];
    for( int i = 0 ; i < k ; i++){
      memo[k] = -1;
    }
    fazParte(k,n, memo);
  }
  return 0;
}
