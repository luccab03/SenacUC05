CREATE TABLE `Testes`.`pre_agendamento` (
  `Nome` VARCHAR(45) NOT NULL,
  `Telefone` VARCHAR(45) NOT NULL,
  `Data` DATE NOT NULL,
  `Animal` VARCHAR(45) NOT NULL,
  `Descricao` VARCHAR(255) NOT NULL);


insert into pre_agendamento (Nome, Telefone, Data, Animal, Descricao) values ("Nome","Telefone", "2020-05-04 23:55:55", "Animal", "Descricao");

select * from pre_agendamento;