# Organizador De Geladeira
Este projeto implementa um sistema de controle de itens dentro de uma geladeira com três andares. Cada andar possui dois containers com quatro posições cada para organizar itens. O projeto foi desenvolvido em C# com orientação a objetos, incluindo funcionalidades para adicionar e remover itens, além de validações para garantir que as posições e containers estejam corretamente ocupados ou livres.

 ## Estrutura da Geladeira

- **Andar 1 (Inferior):** Containers para hortifrutis (frutas e vegetais).
- **Andar 2:** Containers para laticínios e enlatados.
- **Andar 3 (Superior):** Containers para charcutaria, carnes e ovos.

Cada andar possui:

- 2 Containers
- 4 Posições por Container

## REQUISITOS

- **Organização por Andares:** Divida a geladeira em três andares, contados de baixo para cima.
- **Containers:** Cada andar possui dois containers.
- **Posições:** Cada container tem quatro posições para itens.
- **Impressão dos Itens:** Mostra todos os produtos na geladeira, indicando o andar e o container onde estão localizados.


![image](https://github.com/user-attachments/assets/9f3fcef9-9ea3-4a75-a454-be519493cdc5)

## RESULTADO

![image](https://github.com/user-attachments/assets/295eef78-4ebf-431e-817d-9fad7a72e393)

## NOVAS FUNCIONALIDADES

![image](https://github.com/user-attachments/assets/f5f15b7a-2fec-4607-a489-fde378718c80)

## REQUISITOS
Esta é a segunda versão do sistema, agora atualizada e aprimorada!

O sistema conta com as seguintes funcionalidades adicionais:

**Remoção de Itens Específicos**

**Adição de Itens em Posições Específicas**

**Remoção de Todos os Itens de um Container**

**Adição de Itens em um Container**

*SEMPRE VALIDAR SE A POSICAO ESTA OCUPADA OU VAZIA E EXIBIR MENSAGEM SE VAZIA OU OCUPADA *

## RESULTADO
![image](https://github.com/user-attachments/assets/35e99d57-fb40-4f07-bcd3-aa38cb2539ec)
![image](https://github.com/user-attachments/assets/ace94229-a861-4019-b475-23ded4e21453)


## API de Gestão de Geladeira


![image](https://github.com/user-attachments/assets/0bf61e62-cde0-4d7f-a523-73e698f68efc)


### Endpoints da API
#### GET /api/geladeira
**Retorna todos os itens armazenados na geladeira, organizados por andar e container.**

![image](https://github.com/user-attachments/assets/2b7ce258-b196-4246-90fe-6a49b68d3105)

#### GET /api/geladeira/{id}
**Retorna um item específico da geladeira pelo ID.**

![image](https://github.com/user-attachments/assets/e76105ed-d2c7-48e0-b2ba-4aaa273970f4)

#### POST /api/geladeira/{andar}/{container}
**Adiciona um novo item à geladeira no andar e container especificados.**

![image](https://github.com/user-attachments/assets/5f9caca1-ea92-469f-8a77-b406de1727c3)
![image](https://github.com/user-attachments/assets/8fefcaa1-51b5-4f80-af87-81e0ab13bb0a)


#### PUT /api/geladeira/{id}
**Atualiza um item existente na geladeira pelo ID**

![image](https://github.com/user-attachments/assets/15c5a41b-058f-4cde-9a03-10107b99195b)
![image](https://github.com/user-attachments/assets/c0f040e4-9a79-482c-a3bf-a58caac0987e)

 #### DELETE /api/geladeira/{id}
**Remove um item da geladeira pelo ID.**

![image](https://github.com/user-attachments/assets/da6c2549-fae3-4eb9-b09c-dfe77a14d063)
![image](https://github.com/user-attachments/assets/098bea73-56ef-429e-8979-525326a53309)



Desenvolvido por silvana santos ❤️





