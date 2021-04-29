-- inserir
insert clientes values
(0, 'Maria das Couves','12545854796', 'maria@couves.com.br', null, default, md5('123456'));

-- listar todos
select * from clientes;

-- exibir cliente
select * from clientes where id = 1;

-- atualiza dados do cliente
update clientes 
set nome  = 'Maria das Couves de Oliveira',
email = 'maria.couves@gmail.com',
telefone = '11985854747',
senha = md5('456123') 
where id = 1;

-- excluir
delete from clientes where id = 1;
