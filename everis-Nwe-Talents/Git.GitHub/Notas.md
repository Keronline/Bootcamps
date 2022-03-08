# :page_facing_up:Introdução ao Git e Github :cat:

## Comandos básicos para um bom desempenho no terminal

- dir - mostra todos os diretórios presentes nas pastas em que você ativa o comando

- cd + parta - entra em uma pasta

- cd .. - retorna uma pasta 

- cls - limpa terminal

- tab - completa ou altera nome de pastas dentro de uma pasta

- mkdir - cria pasta dentro do diretório no qual você se encontra

- del nome_diretório - apaga os arquivos que estão contidos no diretório

- rmdir nome_arquivo /S /Q - exclui arquivo e pasta


É possível criar documentos através do terminal, basta escrever: nome_arquivo.extensão

## Ciclo de vida de arquivos no Git

- Antes de ser inicializado o arquivo é enquadrado como Untracked, sendo então não rastreável pelo git. 
- Quando o comando "git add nome_arquivo" é utilizado, o arquivo fica em espera no Staged.
- Após a utilização do comando "git commit -m "comentário pertinente"", o arquivo passa para o estágio Unmodified.
- Quando o arquivo Unmodifief é modificado, muda para o modo Modified. 
- Um arquivo quando é modificado deve retornar para a região Staged e dar seguimento no ciclo.
