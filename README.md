# LTM
  * A solution consiste em um desenvolvimento simples com um crud de cliente e produto, 
  o fronte-end está em uma aplicação mvc5 utilizando o scafoold do proprio visual studio para criação das views.
  Deixando claro que o objetivo do projeto é O back-end, por conta disso que o front-end está simples.

# Estrutura do projeto 
   * O projeto foi estruturado em DDD (Domain Drive Design), focando nas boas praticas e nos padrões,
   para facilitar o desenvolvimento e posterior a manutenção do projeto.
   
 # Dependencias do projeto
   * EntityFramework 6.1.3
   * AutoMapper 3.2.1
   * Ninject.MVC5 3.2.1
   
 # Banco de Dados
  * SQL Server 2016 SP1 Express
   
 # Baixando o projeto  
  * Abra o terminal da sua maquina, e execute o seguinte comando
  * git clone https://github.com/thiagosimaome/LTM.git
 
 # O que esse comando faz
    * O comando git clone, vai o projeto do repositorio e criar uma pasta na sua maquina com o nome do projeto.
      
 # Como Executar o projeto
   * EU subi o projeto com todas as dependencias instaladas, so temos que configurar o banco de dados.
   * Instale o "SQL Server 2016 SP1 Express", e reinicie a maquina.
   * Abra a solution do projeto, e va até o "Package Maneger Console" do visual studio, 
      selecione o projeto "INfra.Data" e execute o comando "Update-Database -verbose -force"
      
 #  O que esse comando Faz
    * Update-Database -verbose -force 
        * O Entityframework tem um automatizador de scripts de banco de dados que chama Migration, 
           Quando executamos o comando  "Update-Database" no "Package Maneger Console" do visual studio,
           no projeto que temos o entityFramework intalado, o MIgrations vai se conectar com 
           o Servidor do banco de dados e criar o banco com as tabelas e relacionamento 
           conforme declarado nas classes de configuração.
       
       * O atributo -verbose, vai expecificar para o migrations que ele tem que mostrar todas as alterações
         feitas no console.
       * O atributo -force, e para forçar a atualização caso haja um banco existente.
       
  
  
  Obs : Utilizei alem do padrão DDD a união de outros padrões como Factory, e DI e Repository.
