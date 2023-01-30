# Duck-Protocol

## O que é o Duck Protocol?
O Duck Protocol é um protocolo didatico criado no [CEDEN](https://www.etefmc.com.br/ceden) para ensinar conceitos de Redes Industriais na [ETE FMC](https://www.etefmc.com.br). Pensado para ser utilizado com a infraestrutura RS458, se trata de um protocolo serial de 5 bytes.

## Nesse repositório você encontrara:
- [Apostila RS485 utilizando Duck  Protocol](Apostila) (Comece sua leitura por aqui) -> Aqui há uma apostila introdutoria sobre a infraestrutura RS485, como trafegar dados usando o Duck Protocol e como utilizar o [Dashboard](Dashboard).

- [Tabela Guia](Tabela_Guia.xlsx) -> Para a construção de um frame usando o Duck Protocol.

- [DebugPy](DebugPy) -> Para analizar o barramento e entender o que está sendo trafegado. O debuger tras uma interface que monitora os pacotes e ajuda na interpretação do que cada byte do frame representa e os comandos da linha industrial. Se comporta como um Slave na sua rede conectada ao barramento por um adaptador USB-RS485.

- [SlaveDuino](SlaveDuino) -> É um código simples que demonstra como utilizar o arduino como um Slave em um barramento serial Duck Protocol. 

- [Dashboard](Dashboard) -> O Dashboard é uma interface desenvolvida para ser Master em uma rede RS485 Duck Protocol e conectada ao barramento por um adaptador USB-RS485. Aqui você pode automatizar o envio de pacotes, ler o bararmento, buscar dados e enviar comados para Slaves.
