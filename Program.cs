﻿namespace GerenciadorEscola
{
    internal class Program
    {
        internal static void Main()
        {
            Escola.Init();

            // Criando três alunos
            Aluno aluno1 = new Aluno(123456, "Joao", new DateTime(1999, 7, 5));
            aluno1.DefinirStatus(false);
            Escola.CadastrarAluno(aluno1);

            Aluno aluno2 = new Aluno(758962, "Maria", new DateTime(2005, 5, 12));
            aluno2.DefinirStatus(true);
            Escola.CadastrarAluno(aluno2);

            Aluno aluno3 = new Aluno(123456, "Pedro", new DateTime(2000, DateTime.Now.Month, DateTime.Now.Day));
            aluno3.DefinirStatus(true);
            Escola.CadastrarAluno(aluno3);

            // Criando duas disciplinas
            Disciplina disciplina1 = new Disciplina
            {
                Titulo = "Introdução à Programação",
                CargaHoraria = 60,
                Ementa = "Esta disciplina introduz os conceitos básicos de programação, incluindo variáveis, tipos de dados, operadores, instruções de controle e funções."
            };

            Disciplina disciplina2 = new Disciplina
            {
                Titulo = "Banco de Dados",
                CargaHoraria = 45,
                Ementa = "Esta disciplina aborda conceitos de bancos de dados relacionais e SQL."
            };

            Disciplina disciplina3 = new Disciplina
            {
                Titulo = "Programação Avançada",
                CargaHoraria = 75,
                Ementa = "Nesta disciplina, você explorará tópicos avançados de programação, incluindo design de software, padrões de projeto e desenvolvimento orientado a objetos."
            };

            Disciplina disciplina4 = new Disciplina
            {
                Titulo = "Redes de Computadores",
                CargaHoraria = 60,
                Ementa = "Esta disciplina cobre os princípios de redes de computadores, protocolos de comunicação e segurança de rede."
            };

            Disciplina disciplina5 = new Disciplina
            {
                Titulo = "Inteligência Artificial",
                CargaHoraria = 90,
                Ementa = "A disciplina de Inteligência Artificial explora técnicas e algoritmos avançados para criar sistemas inteligentes e aprendizado de máquina."
            };

            // Criando três professores
            Professor professor1 = new Professor(789532, "Helena", new DateTime(1985, 10, 5), 6000.00);

            Professor professor2 = new Professor(586723, "Carlos", new DateTime(1990, 6, 1), 6000.00);

            Professor professor3 = new Professor(586723, "Anna", new DateTime(1999, 12, 5), 15000.00);

            // Criando três cursos
            Curso curso1 = new Curso("Ciência da Computação", "CC01", 5000);
            curso1.AdicionarDisciplina(disciplina3);
            curso1.AdicionarDisciplina(disciplina4);
            curso1.AdicionarDisciplina(disciplina5);
            curso1.AdicionarAluno(aluno1);
            curso1.AdicionarAluno(aluno2);

            Curso curso2 = new Curso("Engenharia Elétrica", "EE02", 4500);
            curso2.AdicionarDisciplina(disciplina1);
            curso2.AdicionarAluno(aluno2);
            curso2.AdicionarAluno(aluno3);

            Curso curso3 = new Curso("Matemática Aplicada", "MA03", 2000);
            curso3.AdicionarDisciplina(disciplina2);
            curso3.AdicionarDisciplina(disciplina5);
            curso3.AdicionarAluno(aluno1);
            curso3.AdicionarAluno(aluno3);

            // Adicionando as disciplinas à lista
            Escola.CadastrarDisciplina(disciplina1);
            Escola.CadastrarDisciplina(disciplina2);
            Escola.CadastrarDisciplina(disciplina3);
            Escola.CadastrarDisciplina(disciplina4);
            Escola.CadastrarDisciplina(disciplina5);

            // cadastrando cursos na lista
            Escola.CadastrarCurso(curso1);
            Escola.CadastrarCurso(curso2);
            Escola.CadastrarCurso(curso3);

            // cadastrando professores na Escola
            Escola.CadastrarProfessor(professor1);
            Escola.CadastrarProfessor(professor2);
            Escola.CadastrarProfessor(professor3);

            // atribuindo professores a cada disciplina
            disciplina1.AtribuirProfessor(professor1);
            disciplina2.AtribuirProfessor(professor2);
            disciplina2.AtribuirProfessor(professor3);
            disciplina3.AtribuirProfessor(professor1);
            disciplina3.AtribuirProfessor(professor2);
            disciplina3.AtribuirProfessor(professor3);
            disciplina4.AtribuirProfessor(professor1);
            disciplina4.AtribuirProfessor(professor2);
            disciplina5.AtribuirProfessor(professor3);


            // Imprimindo alunos e disciplinas
            Console.WriteLine("                                                             Lista de alunos\n");
            Escola.ListarAlunos();
            Console.WriteLine("\n                                                           Lista de professores\n");
            Escola.ListarProfessores();
            Console.WriteLine("\n                                                           Lista de cursos\n");
            Escola.ListarCursos();
            Console.WriteLine("\n                                                           Lista de disciplinas\n");
            Escola.ListarDisciplinas();

        }
    }
}