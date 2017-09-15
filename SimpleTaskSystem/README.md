Sistema de Tree View

Cada novo nó recebe o nome de "Título X", onde X é o número de nós atuais. Cada nó novo recebe uma descrição default.
Essa descrição é diferente para nós principais e sub-nós (Subtítulos), mas segue a mesma lógica.

A descrição pode ser modificada pelo 'textarea', simplemente reescrever e clicar em "Salvar".

Além disso, o nome do nó também pode ser modificado com clique duplo.

Na base de dados é criada apenas uma tabela na Database "TreeView". Esta tabela tem uma chave estrangeira para ela mesma
apontando para o nó "pai" se ele existir.

A aplicação foi feita usando o template do ASP.NET Boilerplate. https://aspnetboilerplate.com/