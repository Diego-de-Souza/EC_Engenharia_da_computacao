--================================================
/* 
	  ==== Atividade Banco de Dado ====
   nome: Diego de Souza Lima	082220042
   nome: Robson Guilherme Ferrarezi	082220015
*/
--================================================

-- Questão 1
use Telefonica_EC2

alter table Cliente
add
constraint FK_Cod_Cidade
foreign key(Cod_Cidade) references Cidade

select Cliente.*,Cidade.Cidade,Cidade.Estado 
	from Cliente 
		inner join Cidade 
			on Cliente.Cod_cidade=Cidade.Cod_Cidade
/*
Cod_Cliente Nome                                               Endereco                       Cod_cidade Cidade                                             Estado
----------- -------------------------------------------------- ------------------------------ ---------- -------------------------------------------------- ------
1           Ana Maria                                          Rua Souza, 34                  1          Maua                                               SP
2           Paula Francisca                                    Rua Calota, 233                2          Santo Andre                                        SP
3           Carla da Esquina                                   Rua Mantra, 87                 2          Santo Andre                                        SP
4           Cesar Freitas                                      Av. 12 Outubro, 986            7          Cabo Frio                                          RJ
5           Andre Mostardo                                     Av. Atlantica, 43              4          Brasilia                                           DF
6           Felipe Alcantara                                   Rua Figueiras, 332             3          Caldas Novas                                       GO
7           Vitor Hugo                                         Tr. 7 com 8, 8776              5          Campanha                                           MG
8           Maria Anitta                                       Rua Bauro, 888                 1          Maua                                               SP
*/

alter table LinhasTelefonicas
add
constraint FK_Cod_Cliente
foreign key(Cod_Cliente) references Cliente

select LinhasTelefonicas.*,Cliente.Cod_cidade,Cliente.Endereco,Cliente.Nome 
	from LinhasTelefonicas 
		inner join Cliente 
			on LinhasTelefonicas.Cod_Cliente=Cliente.Cod_Cliente

/*
Num_Telefone Cod_Cliente Data_Compra Valor_Compra                            Cod_cidade Endereco                       Nome
------------ ----------- ----------- --------------------------------------- ---------- ------------------------------ --------------------------------------------------
21254788     7           2006-04-22  879.30                                  5          Tr. 7 com 8, 8776              Vitor Hugo
31547791     5           2006-01-30  154.22                                  4          Av. Atlantica, 43              Andre Mostardo
45522547     4           2006-01-17  1547.66                                 7          Av. 12 Outubro, 986            Cesar Freitas
45550204     1           2006-01-15  1500.58                                 1          Rua Souza, 34                  Ana Maria
49930100     1           2006-01-03  1457.36                                 1          Rua Souza, 34                  Ana Maria
49931105     4           2006-02-22  12554.22                                7          Av. 12 Outubro, 986            Cesar Freitas
49971487     5           2006-06-10  15487.99                                4          Av. Atlantica, 43              Andre Mostardo
49975487     2           2006-03-01  541.65                                  2          Rua Calota, 233                Paula Francisca
49990101     5           2006-05-07  1540.00                                 4          Av. Atlantica, 43              Andre Mostardo
54158877     2           2006-03-14  1547.25                                 2          Rua Calota, 233                Paula Francisca
*/

alter table Ligacoes
add
constraint FK_Num_Telefone
foreign key(Num_Telefone) references LinhasTelefonicas

select Ligacoes.*,LinhasTelefonicas.Cod_Cliente, LinhasTelefonicas.Data_Compra,LinhasTelefonicas.Valor_Compra 
	from Ligacoes 
		inner join LinhasTelefonicas 
			on Ligacoes.Num_Telefone=LinhasTelefonicas.Num_Telefone

/*
Lancamento Num_Telefone Mes    Qtd_Minutos Valor_Minuto                            Cod_Cliente Data_Compra Valor_Compra
---------- ------------ ------ ----------- --------------------------------------- ----------- ----------- ---------------------------------------
1          31547791     1      14          0.36                                    5           2006-01-30  154.22
2          45522547     1      15          0.45                                    4           2006-01-17  1547.66
3          31547791     1      17          0.87                                    5           2006-01-30  154.22
4          45522547     2      2           0.60                                    4           2006-01-17  1547.66
5          49990101     2      7           0.30                                    5           2006-05-07  1540.00
6          45522547     2      3           0.71                                    4           2006-01-17  1547.66
7          54158877     3      9           0.99                                    2           2006-03-14  1547.25
8          54158877     3      14          0.02                                    2           2006-03-14  1547.25
9          45550204     4      2           0.55                                    1           2006-01-15  1500.58
10         21254788     4      8           0.78                                    7           2006-04-22  879.30
11         31547791     5      2           0.87                                    5           2006-01-30  154.22
12         31547791     5      14          0.36                                    5           2006-01-30  154.22
13         45522547     5      15          0.45                                    4           2006-01-17  1547.66
14         31547791     6      17          0.87                                    5           2006-01-30  154.22
15         45522547     6      2           0.60                                    4           2006-01-17  1547.66
16         49990101     7      7           0.30                                    5           2006-05-07  1540.00
17         45522547     7      3           0.71                                    4           2006-01-17  1547.66
18         54158877     8      9           0.99                                    2           2006-03-14  1547.25
19         54158877     8      14          0.02                                    2           2006-03-14  1547.25
20         45550204     9      2           0.55                                    1           2006-01-15  1500.58
21         21254788     9      8           0.78                                    7           2006-04-22  879.30
22         31547791     10     2           0.87                                    5           2006-01-30  154.22
23         31547791     10     14          0.36                                    5           2006-01-30  154.22
24         45522547     10     15          0.45                                    4           2006-01-17  1547.66
25         31547791     11     17          0.87                                    5           2006-01-30  154.22
26         45522547     11     2           0.60                                    4           2006-01-17  1547.66
27         49990101     12     7           0.30                                    5           2006-05-07  1540.00
28         45522547     12     3           0.71                                    4           2006-01-17  1547.66
29         54158877     12     9           0.99                                    2           2006-03-14  1547.25
30         54158877     1      14          0.02                                    2           2006-03-14  1547.25
31         45550204     2      2           0.55                                    1           2006-01-15  1500.58
32         21254788     3      8           0.78                                    7           2006-04-22  879.30
33         31547791     4      2           0.87                                    5           2006-01-30  154.22
*/

--questão 2

select *
	from Cidade
		order by Cod_Cidade asc
/*
Cod_Cidade Cidade                                             Estado
---------- -------------------------------------------------- ------
1          Maua                                               SP
2          Santo Andre                                        SP
3          Caldas Novas                                       GO
4          Brasilia                                           DF
5          Campanha                                           MG
6          Sao Paulo                                          SP
7          Cabo Frio                                          RJ
*/

-- Questão 3

select *
	from Cliente
		where Cod_cidade not in (2,7)

/*
Cod_Cliente Nome                                               Endereco                       Cod_cidade
----------- -------------------------------------------------- ------------------------------ ----------
1           Ana Maria                                          Rua Souza, 34                  1
5           Andre Mostardo                                     Av. Atlantica, 43              4
6           Felipe Alcantara                                   Rua Figueiras, 332             3
7           Vitor Hugo                                         Tr. 7 com 8, 8776              5
8           Maria Anitta                                       Rua Bauro, 888                 1
*/

-- Questão 4

select COUNT(Num_Telefone) quantidade
	from LinhasTelefonicas
		where Cod_Cliente in (2,4,7)

/*
quantidade
-----------
5
*/

-- Questão 5

set dateformat dmy
select LinhasTelefonicas.Num_Telefone intervalo_linhas
	from LinhasTelefonicas
		where Data_Compra between '01/01/2006' and '20/02/2006'
/*
intervalo_linhas
----------------
31547791
45522547
45550204
49930100
*/

-- Questão 6

select Cidade
	from Cidade
		where Cidade not like '%a'

/*
Cidade
--------------------------------------------------
Santo Andre
Caldas Novas
Sao Paulo
Cabo Frio
*/

-- Questão 7

select AVG(Valor_Compra) valor_medio
	from LinhasTelefonicas
		where month(Data_Compra)=03 

/*
valor_medio
---------------------------------------
1044.450000
*/

-- Questão 8

select Cliente.*,Cidade.Cidade
	from Cliente
		inner join Cidade
			on Cliente.Cod_cidade=Cidade.Cod_Cidade

/*
Cod_Cliente Nome                                               Endereco                       Cod_cidade Cidade
----------- -------------------------------------------------- ------------------------------ ---------- --------------------------------------------------
1           Ana Maria                                          Rua Souza, 34                  1          Maua
2           Paula Francisca                                    Rua Calota, 233                2          Santo Andre
3           Carla da Esquina                                   Rua Mantra, 87                 2          Santo Andre
4           Cesar Freitas                                      Av. 12 Outubro, 986            7          Cabo Frio
5           Andre Mostardo                                     Av. Atlantica, 43              4          Brasilia
6           Felipe Alcantara                                   Rua Figueiras, 332             3          Caldas Novas
7           Vitor Hugo                                         Tr. 7 com 8, 8776              5          Campanha
8           Maria Anitta                                       Rua Bauro, 888                 1          Maua
*/

-- Questão 09

select LinhasTelefonicas.Num_Telefone,LinhasTelefonicas.Valor_Compra,Cliente.Nome, Cidade.Cidade
	from LinhasTelefonicas
		inner join Cliente
			on LinhasTelefonicas.Cod_Cliente=Cliente.Cod_Cliente
		inner join Cidade
			on Cliente.Cod_cidade=Cidade.Cod_Cidade

/*
Num_Telefone Valor_Compra                            Nome                                               Cidade
------------ --------------------------------------- -------------------------------------------------- --------------------------------------------------
21254788     879.30                                  Vitor Hugo                                         Campanha
31547791     154.22                                  Andre Mostardo                                     Brasilia
45522547     1547.66                                 Cesar Freitas                                      Cabo Frio
45550204     1500.58                                 Ana Maria                                          Maua
49930100     1457.36                                 Ana Maria                                          Maua
49931105     12554.22                                Cesar Freitas                                      Cabo Frio
49971487     15487.99                                Andre Mostardo                                     Brasilia
49975487     541.65                                  Paula Francisca                                    Santo Andre
49990101     1540.00                                 Andre Mostardo                                     Brasilia
54158877     1547.25                                 Paula Francisca                                    Santo Andre
*/

-- Questão 10

select distinct Num_Telefone
	from Ligacoes
		where Mes in (2,3) and Valor_Minuto between 0.03 and 0.80 

/*
Num_Telefone
------------
21254788
45522547
45550204
49990101
*/

--Questão 11

select LinhasTelefonicas.Num_Telefone
	from LinhasTelefonicas
		inner join Cliente
			on LinhasTelefonicas.Cod_Cliente=Cliente.Cod_Cliente
		inner join Cidade
			on Cliente.Cod_cidade=Cidade.Cod_Cidade
		where Cidade.Cidade='Campanha'

/*
Num_Telefone
------------
21254788
*/

--Questão 12

select top 4*
	from LinhasTelefonicas
		order by Valor_Compra desc

/*
Num_Telefone Cod_Cliente Data_Compra Valor_Compra
------------ ----------- ----------- ---------------------------------------
49971487     5           2006-06-10  15487.99
49931105     4           2006-02-22  12554.22
45522547     4           2006-01-17  1547.66
54158877     2           2006-03-14  1547.25
*/

--Questão 13

insert into Cliente values (9, 'Ernesto da Silva',null,null,1);
insert into LinhasTelefonicas values ('45550923',9,'2006/10/05',1000.00);
insert into LinhasTelefonicas values ('32490911',9,'2006/09/05',1000.00);
insert into Ligacoes (Num_Telefone, Mes, Qtd_Minutos, Valor_minuto)
VALUES ('45550923',11,14,0.05);
insert into Ligacoes (Num_Telefone, Mes, Qtd_Minutos, Valor_minuto)
VALUES ('32490911',09,09,0.20);
