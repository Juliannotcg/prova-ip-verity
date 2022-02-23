# prova-ip-verity
Api para Prova da IP

DOCUMENTAÇÃO TÉCNICA

Tecnologias utilizadas.

• .Net Core e AspNet Core 6.0
• IMediator
• FluentVlidation
• XUnit


Padrões, template e práticas utilizadas.

• Minimal Api.
• Padrão Mediador.
• Validação Fluente.


APLICAÇÃO
Busquei demonstrar meu conhecimento em desenvolvimento em camadas e desacoplado, 
busquei utilizar alguns recursos novos da linguagem e do framework, fiz a segregação máxima 
dos objetos, evitando utilizar tipos primitivos e buscando mais tipos complexos.
Como o serviço é muito simples implementei o novo recurso do .net core 6 chamado “Minimal 
Apis” que te fornece um template mais enxuto para desenvolvimento de apis simples, o que é 
exatamente nosso caso.


TESTES
No projeto de testes tentei demonstrar meus conhecimentos com a ferramenta XUnit,
implementei testes de integração e testes unitários.
Utilizei as fixtures do XUnit para compartilhamento de instâncias de objetos.
Implementei também a classe para fabricação de um Host web para testes de integração.
Não vi a necessidade de utilização de Moqs de objetos uma vez que não precisei simular 
nenhum comportamento da aplicação.
Consegui testar as classes de validação, serviço e a api