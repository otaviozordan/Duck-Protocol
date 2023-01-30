# Dashboard
Consulte a [apostila](Apostila) para aprendrender a utilizar o dashboard.


## Código fonte
- [Aqui](Dashboard\DuckProtocol-Dashboard.exe) você baixa o executavel do dashboard.

- [Aqui](Dashboard\DuckProtocol-Dashboard.rar) você encontra o código fonte compactado.

## Tutorial do Desenvolvedor:
### Sobre o ambiente de desenvolvimento:
Versão do SDK .Net -> v7.0.102
Versão do .Net Framework -> v4.0.30319
Biblioteca System.IO.Ports instalada por padrão do System.

### Editar o código fonte no Visual Studio:
- Primeiro passo é baixar a pasta com [código fonte compactado](Dashboard\Dashboard-DuckProtocol-main.rar).
- Copie a pasta baixada e extraia no caminho:

    <code>C:\Users\SeuUsuario\source\repos</code>
- Navegue e clique com o botão direito sobre:

    <Code>C:\Users\otavi\source\repos\Dashboard-DuckProtocol-main\Dashboard.sln</code>

- Clique em "Abrir com Visual Studio".


### Detalhes importantes:
Ao trabalhar com as requisições há 2 variaveis que devem ser ajustadas de acordo com a infraestrutura da rede e do tempo de resposta dos escravos.

```c#
const int timeResponse = 10; //Ciclos de espera para resposta. Aumentar se o slave não estiver respondendo em tempo (Recomendado 10 para evitar perda de pacotes) 
const int noBugTime = 7; //Quanto maior, menor será a frequencia de verificação dos 4 slaves (50 padrão, minimo 5 para evitar OverFlow no buffer)
```

Presentes nas linhas 266 e 267 respectivamente do código de <code>ProtocoloMaster.cs</code>
A variavel timeResponse define quantos ciclos de espera o Master deve fazer após enviar uma solicitação de dado a um dos Slaves. Caso o tempo de rsposta do Slave esteja sendo maior que o valor aqui definido, o retorno não será lido e no dashboard haverá o retorno "Sem Resposta".
A variavel noBugTime define em ms o tempo que o software deverá esperar após ser respondido por um Slave para disparar no barramento outra requisição. 
