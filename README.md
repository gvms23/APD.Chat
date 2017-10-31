# APD.Chat
Projeto de Chat para a disciplina de APD (Arquiteturas Paralelas e Distribuídas da FAT).

Duas soluções, uma representando clientes e outra o servidor.
Rode a solução do servidor e depois abra várias instâncias do cliente, aponte
para o IP onde o servidor está.

>A solução requer o .NET Framework 4.6.1 devido ao pacote da MaterialSkin.
>Algumas versões do Visual Studio anteriores à 2015 podem não comportar partes da escrita do código, como por ex:

**MessageBox.show($"Name = {name}, hours = {hours:hh}");**

Mas nesses casos, troque para String.Format, funcionará da mesma maneira.
**String.Format("Name = {0}, hours = {1:hh}", name, hours);**
