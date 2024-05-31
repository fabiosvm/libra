<h1 align=center>Libra 🇧🇷</h1>
<p align=center><strong>A linguagem brasileira</strong></p>
<br>

> **Aviso:** Libra ainda está em desenvolvimento e não há nenhuma versão disponível publicamente. É possível criar apenas programas extremamentes simples por enquanto.

<hr>

Libra é uma linguagem de programação simples, criada exclusivamente para ser um projeto acadêmico. Este projeto tem como objetivo principal o aprendizado e a experimentação no desenvolvimento de linguagens de programação. O código fonte da linguagem estará disponível publicamente para consulta, uso e contribuição.

## Visão Geral

Libra foi projetada para ser fácil de entender e utilizar, especialmente para iniciantes. A sintaxe da linguagem é inspirada em linguagens populares, mas com um diferencial: as palavras-chave e comandos estão em português, facilitando ainda mais o aprendizado para falantes da língua portuguesa.

## Características

- **Sintaxe Simples:** A linguagem possui uma sintaxe intuitiva e limpa.
- **Palavras-Chave em Português:** Todas as palavras-chave e comandos estão em português.
- **Código Aberto:** O código fonte da Libra está disponível publicamente.

## Exemplo de Código

Aqui está um exemplo simples de um programa em Libra:

```js
#def MACRO_EXEMPLO exibir("Macro de exemplo!");

// declarando variáveis
var a = 10;
var b = 5;
var c = a + b * 2;

exibir("Olá, Mundo!"); // exibe 'Olá, Mundo!' no console
exibir(2+2); // exibe 4 no console
exibir(c); // exibe 20 no console (c = a + (b*2))

exibir(verdadeiro); // exibe "Verdadeiro" no console (valor booleano)

MACRO_EXEMPLO // executa a macro exemplo (exibe ("Macro de Exemplo"))

sair(0); // encerra o programa com código 0
```

## Como contribuir?

Se você deseja contribuir para o projeto, pode fazer um *fork* do repositório, depois cloná-lo para sua máquina local com o seguinte comando:
`git clone https://github.com/<SEU_USUARIO>/libra.git`

Contribua para o código, depois crie um *Pull Request*. Caso for uma contribuição válida, a aceitaremos ao projeto.

## Planos

Seria interessante criar uma IDE simples pra Libra, onde fosse possível escrever e analisar código Libra de forma mais conveniente, com syntax highligthing e IntelliSense.
Isso fica pra uma outra hora, ou até o momento que alguém tenha a boa vontade de fazer.


## FAQ

- **Por que C#?** R: O objetivo era criar uma linguagem simples, eu não vi necessidade de usar C ou C++.
- **A linguagem é compilada ou interpretada?** R: Os dois, ela possui um interpretador, mas também compila pra C.
- **Por quê compilar pra C?** R: Compilar diretamente pra assembly seria uma tarefa complicada, e eu não tinha muito tempo pra fazer isso. Quem sabe no futuro.
- **O código não está um pouco bagunçado?** R: Sim, está... Por isso eu deixei ele open-source! Assim você pode me ajudar a melhorá-lo. Eu queria ter escrito um código mais limpo,
porém com pouco tempo, pressa para acabar, e a falta de experiência na criação de um parser contribuíram para o estado atual do código (Mas no final ele ficou Ok)

**Dúvidas?**
Me mande um e-mail: <a href="mailto:lucas.campos44@fatec.sp.gov.br">lucas.campos44@fatec.sp.gov.br</a>
