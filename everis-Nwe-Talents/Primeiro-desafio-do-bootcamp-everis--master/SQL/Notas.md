# SQL SERVER

Banco de dados relacional, sistema que necessita de uma confiabilidade grande em seus dados.

Possui a característica de atomicidade, garantindo que todos os dados estão corretos antes de os armazenar no banco.

Os dados são consistentes, uma vez que espelha as informações de um banco nos outros também pertencentes ao sistema. Operações só são efetivamente persistidas quando estiverem persistidas em tosos os bancos relacionados as operações daquele sistema. 

## Estruturação de uma tabelo no banco de dados

- As linhas são registros
- As colunas são as informações do registro

## Tipos de parâmetros

- int - inteiros
- bigint
- float - ponto flutuante
- varchar - alfanuméricos
- char - alfanuméricos que indica tamanho fixo 
- bit - 0 ou 1

## Tabelas

### Criação: 

create table NomeTabela

(

​	Nome_coluna tipo_de_parâmetro,

​	Nome_coluna tipo_de_parâmetro,

​	Nome_coluna tipo_de_parâmetro,

)

### Manipulação

* Inserir elementos: 

  select * from nome_tabela

   insert nome_tabela (nomes_colunas) values (parâmetros);

* Selecionar elementos:

  select *

  from nome_tabela

  where  nome_coluna = especificação_parâmetro

* Modificar elemento:

  update nome_tabela

  set 		nome_coluna = parametro_para_inclur,

  ​			  nome_coluna = parametro_para_incluir

  where   nome_coluna = especifiação_parametro

- Deletar elemento:

  delete 
  from      nome_tabela 
  where   nome_coluna in (especificação_parâmetro)

- Operadores:

​				

