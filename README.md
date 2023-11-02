# Blog

1. (1.0) Criar um post, o usuário pode definir a data da publicação.
   Testes - OK
2. (1.0) Listar todos os posts com o título, data de publicação e quantidade de comentários. 
	Testes - OK
3. (2.0) Pesquisar os posts por parte do título. 
	Testes - Faltou essa funcionalidade no front.
4. (1.0) Editar um post existente. 
	Teste - Existe o redirecionamento para editar o post mas não ocorre a edição quando clica no botão.
5. (1.0) Excluir um post, com uma confirmação antes da ação.
	Teste - OK
6. (2.0) Exibir os detalhes de um post e os comentários associados.
	Teste - OK
7. (2.0) Na visualização de detalhes de um post, permita que os usuários comentem no post, a data de criação do post deve ser a data e hora atuais.
	Teste - Ocorre o erro 404 ao acessar o endpoint http://localhost:5134/Blog/AddComment?postId=2 
