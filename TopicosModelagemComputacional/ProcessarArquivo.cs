using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace TopicosModelagemComputacional
{
    public partial class ProcessarArquivo : Form
    {

        private SqlConnection conn;
        public ProcessarArquivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void CriarBase(object sender, EventArgs e)
        {

            string connectionString = "Data Source=SeuServidor;Initial Catalog=SeuBancoDeDados;User ID=seu_usuario;Password=sua_senha;"; // Block Segurança

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Conexão ao banco de dados SQL Server bem-sucedida!");
                    CreateTables();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        private void CreateTables()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Criar tabela specie
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS specie (
                        id bigint NOT NULL IDENTITY(1,1),
                        spuid bigint NOT NULL,
                        formula text,
                        charge smallint,
                        symmetry text,
                        weight numeric(18,9),
                        total_e numeric(18,9),
                        vib_e numeric(18,9),
                        method text,
                        n_solo smallint,
                        n_duo smallint,
                        n_trio smallint,
                        n_quartet smallint,
                        n_quintet smallint,
                        n_ch2 smallint,
                        n_chx smallint,
                        PRIMARY KEY(id),
                        UNIQUE(spuid)
                    );
                ";
                cmd.ExecuteNonQuery();

                // Criar tabela geometry
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS geometry (
                        id bigint NOT NULL IDENTITY(1,1),
                        spuid bigint,
                        [position] int,
                        x numeric(18,9),
                        y numeric(18,9),
                        z numeric(18,9),
                        [type] smallint,
                        PRIMARY KEY(id),
                        FOREIGN KEY(spuid) REFERENCES specie(spuid)
                    );
                ";
                cmd.ExecuteNonQuery();

                // Criar tabela transition
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS transition (
                        id bigint NOT NULL IDENTITY(1,1),
                        spuid bigint,
                        frequency numeric(18,9),
                        intensity numeric(18,9),
                        symmetry text,
                        scale numeric(8,4),
                        PRIMARY KEY(id)
                    );
                ";
                cmd.ExecuteNonQuery();

                // Criar tabela atomcount
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS atomcount (
                        id bigint NOT NULL IDENTITY(1,1),
                        spuid bigint,
                        [type] smallint,
                        count smallint,
                        PRIMARY KEY(id)
                    );
                ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Tabelas criadas com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao criar tabelas: " + ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string xmlFilePath = @"C:\Users\Edinaldo Porto\Downloads\teste\PAH_classes-main\database\data\data.xml"; // Caminho do arquivo XML

            try
            {
                string connectionString = "Server=mssql.edinaldosa.com.br,51433;Database=rfsoluco_Furg;User ID=furg;Password=S5mj2g7^;"; // Substitua suas credenciais

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Conexão ao banco de dados SQL Server bem-sucedida!");

                    // Carregar o arquivo XML
                    XDocument xmlDoc = XDocument.Load(xmlFilePath);

                    foreach (XElement specieNode in xmlDoc.Descendants("specie"))
                    {
                        // Extrair informações do XML
                        int id = int.Parse(specieNode.Attribute("uid").Value);
                        string formula = specieNode.Element("formula").Value;
                        int charge = int.Parse(specieNode.Element("charge").Value);
                        string symmetry = specieNode.Element("symmetry").Value;
                        // Extrair os demais campos do XML conforme necessário...

                        // Inserir dados na tabela specie
                        string insSpecieQuery = @"INSERT INTO specie (id, formula, charge, symmetry) " +
                                                "VALUES (@id, @formula, @charge, @symmetry)";

                        SqlCommand cmdSpecie = new SqlCommand(insSpecieQuery, conn);
                        cmdSpecie.Parameters.AddWithValue("@id", id);
                        cmdSpecie.Parameters.AddWithValue("@formula", formula);
                        cmdSpecie.Parameters.AddWithValue("@charge", charge);
                        cmdSpecie.Parameters.AddWithValue("@symmetry", symmetry);

                        cmdSpecie.ExecuteNonQuery();

                    
                        // Repita o processo para inserir nas demais tabelas (geometry, transition, atomcount)

                        foreach (XElement geometryNode in specieNode.Elements("geometry").Elements("atom"))
                        {
                            int position = int.Parse(geometryNode.Element("position").Value);
                            string x = geometryNode.Element("x").Value;
                            string y = geometryNode.Element("y").Value;
                            string z = geometryNode.Element("z").Value;
                            int type = int.Parse(geometryNode.Element("type").Value);

                            string insGeometryQuery = @"INSERT INTO geometry (spuid, position, x, y, z, type) " +
                                                      "VALUES (@spuid, @position, @x, @y, @z, @type)";

                            SqlCommand cmdGeometry = new SqlCommand(insGeometryQuery, conn);
                            cmdGeometry.Parameters.AddWithValue("@spuid", id);
                            cmdGeometry.Parameters.AddWithValue("@position", position);
                            cmdGeometry.Parameters.AddWithValue("@x", x);
                            cmdGeometry.Parameters.AddWithValue("@y", y);
                            cmdGeometry.Parameters.AddWithValue("@z", z);
                            cmdGeometry.Parameters.AddWithValue("@type", type);

                            cmdGeometry.ExecuteNonQuery();
                        }

                        foreach (XElement transitionNode in specieNode.Elements("transitions").Elements("mode"))
                        {
                            double frequency = double.Parse(transitionNode.Element("frequency").Value);
                            double intensity = double.Parse(transitionNode.Element("intensity").Value);
                            string scale = transitionNode.Element("frequency").Attribute("scale").Value;
                            string symmetryTransition = transitionNode.Element("symmetry").Value;

                            string insTransitionQuery = @"INSERT INTO transition (spuid, frequency, intensity, symmetry, scale) " +
                                                        "VALUES (@spuid, @frequency, @intensity, @symmetryTransition, @scale)";

                            SqlCommand cmdTransition = new SqlCommand(insTransitionQuery, conn);
                            cmdTransition.Parameters.AddWithValue("@spuid", id);
                            cmdTransition.Parameters.AddWithValue("@frequency", frequency);
                            cmdTransition.Parameters.AddWithValue("@intensity", intensity);
                            cmdTransition.Parameters.AddWithValue("@symmetryTransition", symmetryTransition);
                            cmdTransition.Parameters.AddWithValue("@scale", scale);

                            cmdTransition.ExecuteNonQuery();
                        }

                        foreach (XElement atomNode in specieNode.Element("geometry").Elements("atom"))
                        {
                            int atomType = int.Parse(atomNode.Element("type").Value);
                            int count = int.Parse(atomNode.Element("count").Value);

                            string insAtomCountQuery = @"INSERT INTO atomcount (spuid, type, count) " +
                                                        "VALUES (@spuid, @atomType, @count)";

                            SqlCommand cmdAtomCount = new SqlCommand(insAtomCountQuery, conn);
                            cmdAtomCount.Parameters.AddWithValue("@spuid", id);
                            cmdAtomCount.Parameters.AddWithValue("@atomType", atomType);
                            cmdAtomCount.Parameters.AddWithValue("@count", count);

                            cmdAtomCount.ExecuteNonQuery();
                        }

                    }

                    MessageBox.Show("Dados inseridos no banco de dados!");
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo XML ou inserir dados no banco: " + ex.Message);
            }
        }
    }
}
