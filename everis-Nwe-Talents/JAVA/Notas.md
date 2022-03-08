# Desenvolvimento básico em Java

## Conceitos

* Java: é uma linguagem de programação que é compilada para um bytecode que será interpretado por uma máquina virtual.
* Compilador: é um programa que, a partir do código fonte, cria um programa semanticamente equivalente, porém escrito em outra linguagem, o código objeto. Um compilador traduz um programa de uma linguagem textual para linguagem de máquina, específica para um processador e sistema operacional. Utilizado principalmente para os programas que traduzem o código fonte de uma linguagem de programação de alto nível para uma linguagem de programação de baixo nível.
* Bytecode: é o código originado da compilação de programas Java. É interpretado e executado pela Máquina Virtual Java (JVM).
* Máquina Virtual: é um software que simula uma máquina física e consegue executar vários programas gerenciar processos, memória e arquivos.
* JVM: máquina virtual do java, que executa  programas em código bytecode. Possui a portabilidade como vantagem.
* JRE (Java Runtime Environment): é o ambiente de execução java, composto pela JVM, bibliotecas e APIs da linguagem java. Responsável pela execução do software java.
* JDK (Java Develoment Kit): kit de desenvolvimento java é o conjunto de utilitarios que permitem criar software para a plataforma java. Composto pelo compilador java, bibliotecas, ferramentas e JRE.

## Linguagem

* Todo programa java roda em cima de uma **classe**. Seu nome deve iniciar com letras maiúsculas para cada palavra contida nele.
* o **package **é onde a nossa classe está localizada.
* Os **modificadores de acesso** serve para delimitar ou não o acesso aos métodos e atributos de uma determinada classe.
  * public - qualquer classe, método ou atributo pode usar.
  * private - apenas método ou atributo daquela classe pode usar daquela classe pode utilizar.
  * protected - acessível para classes dentro do mesmo pacote ou por meio de herança. Contudo, a herança só é possível para classes do mesmo pacote. 
  * default (sem modificador) - acessível e público para classes dentro do mesmo pacote.
  * abstract - utilizada apenas em classes e métodos. Para um método ser abstract,  sua classe também deve ser. Uma classe abstrata não pode ser instanciada. Contudo, pode ser uma classe Pai e deixar seus métodos e atributos para seus filhos. Na classe filha, os métodos e atributos abstratos devem ser sobrescritas na classe filho.
  * static -  Atributos ou propriedades declaradas como Static possuem o mesmo endereço de memória, sendo comum para todos os objetos da classe. Não há necessidade de instanciar a classe para chamar um para chamar um método ou atributo que possua este tipo de modificador.
  * final - não é possível sobrescrever informações quando são declaradas com este modificador. Serve para atributos métodos e variáveis.
* **Métodos** são as funções da classe. Dividi-se em public, de maneira que pode acessado fora da classe em que foi criado, e private, que pode ser acessado apenas dentro da classe.

Herança - tudo que esta presente na classe pai é herdado na classe filho. Quando há um construtos na classe pai, é necessário chamar na classe filho por meio do "super".

public class ClasseFilho  extends ClassePai{

​		atributos ClasseFilho;

​		public ClasseFilho(Tipo variável_pai, Tipo variável){

​				super(variável_pai);

​				super.metodos_pai

​		}	

}

- **Interfaces** 
